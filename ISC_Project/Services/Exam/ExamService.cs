using ISC_Project.Data;
using ISC_Project.DTOs.Exam;
using ISC_Project.Interface.Exam;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ISC_Project.Services.Exam
{
    public class ExamService: IExamService
    {
        private readonly ISC_ProjectDbContext _context;

        public ExamService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateExamAsync(ExamCreationDto examDto, int teacherUserId)
        {
            // 1. Xác thực giáo viên và môn học
            var teacherProfile = await _context.TeacherProfiles
                .FirstOrDefaultAsync(t => t.UserId == teacherUserId);

            if (teacherProfile == null || !teacherProfile.SubjectId.HasValue)
            {
                throw new Exception("Không tìm thấy giáo viên hoặc giáo viên chưa được phân công môn học.");
            }

            // 2. Tạo bài kiểm tra (LabSchedule)
            var labSchedule = new LabSchedule
            {
                LabName = examDto.Name,
                LabStartDate = examDto.StartDate,
                LabEndDate = examDto.EndDate,
                UserId = teacherUserId,
                SubjectId = teacherProfile.SubjectId.Value,
                Status = "Scheduled"
            };
            _context.LabSchedules.Add(labSchedule);
            await _context.SaveChangesAsync(); // Lưu để lấy LabSchedules_ID

            // 3. Thêm các câu hỏi đã chọn vào bài kiểm tra
            foreach (var questionId in examDto.QuestionIds)
            {
                var examQuestion = new LabSchedule_Questions
                {
                    LabSchedules_ID = labSchedule.LabSchedulesId,
                    Questions_ID = questionId
                };
                _context.LabSchedule_Questions.Add(examQuestion);
            }

            // 4. Gán bài kiểm tra cho các lớp
            foreach (var classId in examDto.ClassIds)
            {
                var scheduleClass = new LabScheduleClass
                {
                    LabSchedulesId = labSchedule.LabSchedulesId,
                    ClassId = classId
                };
                _context.LabScheduleClasses.Add(scheduleClass);
            }

            await _context.SaveChangesAsync();
            return labSchedule.LabSchedulesId;
        }

        public async Task<StartedExamDto> StartExamAsync(int labScheduleId, int studentUserId)
        {
            // 1. Tạo một lượt làm bài mới
            var submission = new StudentSubmission
            {
                SubmissionTime = DateTime.UtcNow,
                UserId = studentUserId,
                LabSchedules_ID = labScheduleId,
                // Các trường khác có thể set giá trị mặc định
            };
            _context.StudentSubmissions.Add(submission);
            await _context.SaveChangesAsync();

            // 2. Lấy danh sách câu hỏi và hoán đổi vị trí
            var questions = await _context.LabSchedule_Questions
                .Where(lq => lq.LabSchedules_ID == labScheduleId)
                .Include(lq => lq.Question)
                    .ThenInclude(q => q.QuestionOptions)
                .Select(lq => lq.Question)
                .ToListAsync();

            // Logic hoán đổi ngẫu nhiên
            var random = new Random();
            var shuffledQuestions = questions.OrderBy(q => random.Next()).ToList();

            // 3. Chuyển đổi sang DTO để gửi về cho client
            var resultDto = new StartedExamDto
            {
                SubmissionId = submission.SubmissionsId,
                ShuffledQuestions = shuffledQuestions.Select(q => new QuestionForStudentDto
                {
                    QuestionId = q.QuestionsId,
                    QuestionText = q.QuestionsText,
                    Options = q.QuestionOptions.Select(o => new OptionDto
                    {
                        OptionId = o.QuestionOptionsId,
                        OptionText = o.OptionText
                    }).ToList()
                }).ToList()
            };

            return resultDto;
        }

        public async Task SubmitAnswerAsync(SubmitAnswerDto answerDto)
        {
            var studentAnswer = new StudentMcqanswer
            {
                SubmissionsId = answerDto.SubmissionId,
                QuestionsId = answerDto.QuestionId,
                QuestionOptionsId = answerDto.SelectedOptionId
            };
            _context.StudentMcqanswers.Add(studentAnswer);
            await _context.SaveChangesAsync();
        }

        public async Task<double> FinalizeAndGradeExamAsync(int submissionId)
        {
            // Lấy tất cả câu trả lời của học sinh cho lượt làm bài này
            var studentAnswers = await _context.StudentMcqanswers
                .Where(a => a.SubmissionsId == submissionId)
                .ToListAsync();

            if (!studentAnswers.Any()) return 0;

            var questionIds = studentAnswers.Select(a => a.QuestionsId).ToList();

            // Lấy tất cả các đáp án đúng cho các câu hỏi đó
            var correctOptions = await _context.QuestionOptions
                .Where(o => questionIds.Contains(o.QuestionsId) && o.IsCorrect == true)
                .ToDictionaryAsync(o => o.QuestionsId, o => o.QuestionOptionsId);


            int correctCount = 0;
            foreach (var answer in studentAnswers)
            {
                // Kiểm tra xem câu trả lời của học sinh có khớp với đáp án đúng không
                if (correctOptions.ContainsKey(answer.QuestionsId) &&
                    correctOptions[answer.QuestionsId] == answer.QuestionOptionsId)
                {
                    correctCount++;
                }
            }

            double score = (double)correctCount / studentAnswers.Count * 10; // Thang điểm 10

            // Lưu điểm vào bảng Student_Grades
            var grade = new StudentGrade
            {
                Score = score,
                GradedTime = DateTime.UtcNow,
                SubmissionId = submissionId
                // Các trường khác...
            };
            _context.StudentGrades.Add(grade);
            await _context.SaveChangesAsync();

            return score;
        }
    }
}
