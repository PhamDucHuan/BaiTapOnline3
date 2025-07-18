using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ISC_Project.Models;

namespace ISC_Project.Data
{
    public partial class ISC_ProjectDbContext : DbContext
    {
        public ISC_ProjectDbContext()
        {
        }

        public ISC_ProjectDbContext(DbContextOptions<ISC_ProjectDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcceptingSchoolTransfer> AcceptingSchoolTransfers { get; set; } = null!;
        public virtual DbSet<AllowAccess> AllowAccesses { get; set; } = null!;
        public virtual DbSet<AllowAccess1> AllowAccesses1 { get; set; } = null!;
        public virtual DbSet<AssessmentPart> AssessmentParts { get; set; } = null!;
        public virtual DbSet<AssessmentQuestion> AssessmentQuestions { get; set; } = null!;
        public virtual DbSet<Assignment> Assignments { get; set; } = null!;
        public virtual DbSet<AssignmentGroup> AssignmentGroups { get; set; } = null!;
        public virtual DbSet<Campus> Campuses { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<ClassDetail> ClassDetails { get; set; } = null!;
        public virtual DbSet<ClassHistory> ClassHistories { get; set; } = null!;
        public virtual DbSet<ClassHistorySession> ClassHistorySessions { get; set; } = null!;
        public virtual DbSet<ClassSession> ClassSessions { get; set; } = null!;
        public virtual DbSet<ClassType> ClassTypes { get; set; } = null!;
        public virtual DbSet<ClassroomSetting> ClassroomSettings { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<CourseCategory> CourseCategories { get; set; } = null!;
        public virtual DbSet<CourseLesson> CourseLessons { get; set; } = null!;
        public virtual DbSet<CourseOffering> CourseOfferings { get; set; } = null!;
        public virtual DbSet<CoursesLearned> CoursesLearneds { get; set; } = null!;
        public virtual DbSet<Discipline> Disciplines { get; set; } = null!;
        public virtual DbSet<DiscussionThread> DiscussionThreads { get; set; } = null!;
        public virtual DbSet<EmploymentHistory> EmploymentHistories { get; set; } = null!;
        public virtual DbSet<Enrollment> Enrollments { get; set; } = null!;
        public virtual DbSet<Exemption> Exemptions { get; set; } = null!;
        public virtual DbSet<FacultyStudyBlock> FacultyStudyBlocks { get; set; } = null!;
        public virtual DbSet<FamilyInformation> FamilyInformations { get; set; } = null!;
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<Intern> Interns { get; set; } = null!;
        public virtual DbSet<Intern1> Interns1 { get; set; } = null!;
        public virtual DbSet<LabGrader> LabGraders { get; set; } = null!;
        public virtual DbSet<LabSchedule> LabSchedules { get; set; } = null!;
        public virtual DbSet<LabScheduleClass> LabScheduleClasses { get; set; } = null!;
        public virtual DbSet<LearningOutcome> LearningOutcomes { get; set; } = null!;
        public virtual DbSet<LiveChatMessage> LiveChatMessages { get; set; } = null!;
        public virtual DbSet<LiveSession> LiveSessions { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<PastClass> PastClasses { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<Qualification> Qualifications { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<QuestionOption> QuestionOptions { get; set; } = null!;
        public virtual DbSet<Registration> Registrations { get; set; } = null!;
        public virtual DbSet<RelativesInformation> RelativesInformations { get; set; } = null!;
        public virtual DbSet<Reserved> Reserveds { get; set; } = null!;
        public virtual DbSet<Reward> Rewards { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Role1> Roles1 { get; set; } = null!;
        public virtual DbSet<Role2> Roles2 { get; set; } = null!;
        public virtual DbSet<RolePermission> RolePermissions { get; set; } = null!;
        public virtual DbSet<SchoolProfile> SchoolProfiles { get; set; } = null!;
        public virtual DbSet<SchoolYear> SchoolYears { get; set; } = null!;
        public virtual DbSet<Score> Scores { get; set; } = null!;
        public virtual DbSet<Semester> Semesters { get; set; } = null!;
        public virtual DbSet<StudentGrade> StudentGrades { get; set; } = null!;
        public virtual DbSet<StudentMcqanswer> StudentMcqanswers { get; set; } = null!;
        public virtual DbSet<StudentSubmission> StudentSubmissions { get; set; } = null!;
        public virtual DbSet<StudentsChangeClass> StudentsChangeClasses { get; set; } = null!;
        public virtual DbSet<StudentsChangeSchool> StudentsChangeSchools { get; set; } = null!;
        public virtual DbSet<StudentsProfile> StudentsProfiles { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<SubjectType> SubjectTypes { get; set; } = null!;
        public virtual DbSet<SubjectsClass> SubjectsClasses { get; set; } = null!;
        public virtual DbSet<SyllabusTopic> SyllabusTopics { get; set; } = null!;
        public virtual DbSet<SystemSetting> SystemSettings { get; set; } = null!;
        public virtual DbSet<TeacherProfile> TeacherProfiles { get; set; } = null!;
        public virtual DbSet<TeachingAssessment> TeachingAssessments { get; set; } = null!;
        public virtual DbSet<TeamDepartment> TeamDepartments { get; set; } = null!;
        public virtual DbSet<ThreadPost> ThreadPosts { get; set; } = null!;
        public virtual DbSet<TotalCoursesTaken> TotalCoursesTakens { get; set; } = null!;
        public virtual DbSet<TrainingLevel> TrainingLevels { get; set; } = null!;
        public virtual DbSet<UpcomingClass> UpcomingClasses { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<User1> Users1 { get; set; } = null!;
        public virtual DbSet<User2> Users2 { get; set; } = null!;
        public virtual DbSet<WorkHistory> WorkHistories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcceptingSchoolTransfer>(entity =>
            {
                entity.HasKey(e => e.AcceptingSchoolTransfersId)
                    .HasName("AcceptingSchoolTransfers_pkey");

                entity.ToTable("AcceptingSchoolTransfers", "ISC_Project");

                entity.Property(e => e.AcceptingSchoolTransfersId).HasColumnName("AcceptingSchoolTransfers_ID");

                entity.Property(e => e.ConvertFrom)
                    .HasMaxLength(255)
                    .HasColumnName("Convert from");

                entity.Property(e => e.District).HasMaxLength(100);

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(512)
                    .HasColumnName("FileURL");

                entity.Property(e => e.MoveInDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Move-in Date");

                entity.Property(e => e.Province).HasMaxLength(100);

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AcceptingSchoolTransfers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AcceptingSchoolTransfers.User_ID");
            });

            modelBuilder.Entity<AllowAccess>(entity =>
            {
                entity.ToTable("AllowAccesses", "ProjectOnline3");

                entity.HasIndex(e => e.RoleId, "IX_AllowAccesses_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AllowAccesses)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AllowAccess1>(entity =>
            {
                entity.HasKey(e => e.AllowAccessId);

                entity.ToTable("AllowAccesses", "ISC_Project");

                entity.HasIndex(e => e.RoleId, "IX_AllowAccesses_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AllowAccess1s)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AssessmentPart>(entity =>
            {
                entity.HasKey(e => e.AssessmentPartsId)
                    .HasName("AssessmentParts_pkey");

                entity.ToTable("AssessmentParts", "ISC_Project");

                entity.Property(e => e.AssessmentPartsId).HasColumnName("AssessmentParts_ID");

                entity.Property(e => e.AssignmentId).HasColumnName("Assignment_ID");

                entity.Property(e => e.AssignmentUrl)
                    .HasMaxLength(512)
                    .HasColumnName("Assignment_url");

                entity.Property(e => e.EndTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PartOrder).HasColumnName("Part_order");

                entity.Property(e => e.StarTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.AssessmentParts)
                    .HasForeignKey(d => d.AssignmentId)
                    .HasConstraintName("FK_AssessmentParts.Assignment_ID");
            });

            modelBuilder.Entity<AssessmentQuestion>(entity =>
            {
                entity.HasKey(e => e.AssessmentQuestionsId)
                    .HasName("AssessmentQuestions_pkey");

                entity.ToTable("AssessmentQuestions", "ISC_Project");

                entity.Property(e => e.AssessmentQuestionsId).HasColumnName("AssessmentQuestions_ID");

                entity.Property(e => e.QuestionOrder).HasColumnName("Question_order");

                entity.Property(e => e.QuestionsId).HasColumnName("Questions_ID");

                entity.HasOne(d => d.Questions)
                    .WithMany(p => p.AssessmentQuestions)
                    .HasForeignKey(d => d.QuestionsId)
                    .HasConstraintName("FK_AssessmentQuestions.Questions_ID");
            });

            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.ToTable("Assignments", "ISC_Project");

                entity.Property(e => e.AssignmentId).HasColumnName("Assignment_ID");

                entity.Property(e => e.AssignmentScope)
                    .HasMaxLength(100)
                    .HasColumnName("Assignment_scope");

                entity.Property(e => e.AssignmentUrl)
                    .HasMaxLength(512)
                    .HasColumnName("Assignment_Url");

                entity.Property(e => e.Category).HasMaxLength(100);

                entity.Property(e => e.CraeteAt).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EndTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FacultyId).HasColumnName("Faculty_ID");

                entity.Property(e => e.Format).HasMaxLength(100);

                entity.Property(e => e.PartitionType).HasMaxLength(100);

                entity.Property(e => e.StarTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.TeachingId).HasColumnName("Teaching_ID");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Teaching)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.TeachingId)
                    .HasConstraintName("FK_Assignments.Teaching_ID");
            });

            modelBuilder.Entity<AssignmentGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Assignment_Group", "ISC_Project");

                entity.Property(e => e.AssignmentsId).HasColumnName("Assignments_ID");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.HasOne(d => d.Assignments)
                    .WithMany()
                    .HasForeignKey(d => d.AssignmentsId)
                    .HasConstraintName("FK_Assignment_Group.Assignments_ID");

                entity.HasOne(d => d.Class)
                    .WithMany()
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_Assignment_Group.Class_ID");
            });

            modelBuilder.Entity<Campus>(entity =>
            {
                entity.HasKey(e => e.CampusesId)
                    .HasName("Campuses_pkey");

                entity.ToTable("Campuses", "ISC_Project");

                entity.Property(e => e.CampusesId).HasColumnName("Campuses_ID");

                entity.Property(e => e.Address).HasMaxLength(512);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.ManagerName)
                    .HasMaxLength(255)
                    .HasColumnName("Manager_name");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .HasColumnName("phone_number");

                entity.Property(e => e.SchoolId).HasColumnName("School_ID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Campuses)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Campuses.School_ID");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class", "ISC_Project");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.ClassCode).HasMaxLength(50);

                entity.Property(e => e.ClassName).HasMaxLength(100);

                entity.Property(e => e.ClassPassword).HasMaxLength(255);

                entity.Property(e => e.ClassTypeId).HasColumnName("ClassType_ID");

                entity.Property(e => e.ClassUrl)
                    .HasMaxLength(512)
                    .HasColumnName("ClassURL");

                entity.Property(e => e.Classification).HasMaxLength(100);

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.EndTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FileClassUrl)
                    .HasMaxLength(512)
                    .HasColumnName("FileClassURL");

                entity.Property(e => e.JoinCode)
                    .HasMaxLength(50)
                    .HasColumnName("Join_code");

                entity.Property(e => e.JoinPassword)
                    .HasMaxLength(255)
                    .HasColumnName("Join_password");

                entity.Property(e => e.NumberOfSessions).HasColumnName("Number of sessions");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.StarTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.ClassType)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.ClassTypeId)
                    .HasConstraintName("FK_Class.ClassType_ID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Class.Department_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Class.User_ID");
            });

            modelBuilder.Entity<ClassDetail>(entity =>
            {
                entity.HasKey(e => e.DetailClassId)
                    .HasName("Class_Detail_pkey");

                entity.ToTable("Class_Detail", "ISC_Project");

                entity.Property(e => e.DetailClassId).HasColumnName("Detail_Class_ID");

                entity.Property(e => e.AdmissionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Admission date");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.StudentId).HasColumnName("Student_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassDetails)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_Class_Detail.Class_ID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ClassDetails)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Class_Detail.Department_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClassDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Class_Detail.User_ID");
            });

            modelBuilder.Entity<ClassHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("ClassHistory_pkey");

                entity.ToTable("ClassHistory", "ISC_Project");

                entity.Property(e => e.HistoryId).HasColumnName("History_ID");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassHistories)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_ClassHistory.Class_ID");
            });

            modelBuilder.Entity<ClassHistorySession>(entity =>
            {
                entity.HasKey(e => e.SessisonHistoryId)
                    .HasName("ClassHistorySession_pkey");

                entity.ToTable("ClassHistorySession", "ISC_Project");

                entity.Property(e => e.SessisonHistoryId).HasColumnName("SessisonHistory_ID");

                entity.Property(e => e.EndTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.HistoryId).HasColumnName("History_ID");

                entity.Property(e => e.SessisonTotal).HasMaxLength(50);

                entity.Property(e => e.StarTime).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.History)
                    .WithMany(p => p.ClassHistorySessions)
                    .HasForeignKey(d => d.HistoryId)
                    .HasConstraintName("FK_ClassHistorySession.History_ID");
            });

            modelBuilder.Entity<ClassSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("ClassSessions_pkey");

                entity.ToTable("ClassSessions", "ISC_Project");

                entity.Property(e => e.SessionId).HasColumnName("Session_ID");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.DurationHours).HasColumnName("Duration_hours");

                entity.Property(e => e.DurationMinutes).HasColumnName("Duration_minutes");

                entity.Property(e => e.EndTimestamp)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("EndTIMESTAMP");

                entity.Property(e => e.ShareLink).HasMaxLength(512);

                entity.Property(e => e.StartTimestamp)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("StartTIMESTAMP");

                entity.Property(e => e.Topic).HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassSessions)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_ClassSessions.Class_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClassSessions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ClassSessions.User_ID");
            });

            modelBuilder.Entity<ClassType>(entity =>
            {
                entity.ToTable("ClassType", "ISC_Project");

                entity.Property(e => e.ClassTypeId).HasColumnName("ClassType_ID");
            });

            modelBuilder.Entity<ClassroomSetting>(entity =>
            {
                entity.HasKey(e => e.ClassroomSettingsId)
                    .HasName("ClassroomSettings_pkey");

                entity.ToTable("ClassroomSettings", "ISC_Project");

                entity.Property(e => e.ClassroomSettingsId).HasColumnName("ClassroomSettings_ID");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassroomSettings)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_ClassroomSettings.Class_ID");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CoursesId)
                    .HasName("Courses_pkey");

                entity.ToTable("Courses", "ISC_Project");

                entity.Property(e => e.CoursesId).HasColumnName("Courses_ID");

                entity.Property(e => e.CourseCategoriesId).HasColumnName("CourseCategories_ID");

                entity.Property(e => e.CoursesImageUrl)
                    .HasMaxLength(512)
                    .HasColumnName("Courses_image_url");

                entity.Property(e => e.DefaultPrice)
                    .HasPrecision(12, 2)
                    .HasColumnName("Default_price");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.CourseCategories)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.CourseCategoriesId)
                    .HasConstraintName("FK_Courses.CourseCategories_ID");
            });

            modelBuilder.Entity<CourseCategory>(entity =>
            {
                entity.HasKey(e => e.CourseCategoriesId)
                    .HasName("CourseCategories_pkey");

                entity.ToTable("CourseCategories", "ISC_Project");

                entity.Property(e => e.CourseCategoriesId).HasColumnName("CourseCategories_ID");

                entity.Property(e => e.CourseCategoriesName).HasMaxLength(255);
            });

            modelBuilder.Entity<CourseLesson>(entity =>
            {
                entity.HasKey(e => e.CourseLessonsId)
                    .HasName("CourseLessons_pkey");

                entity.ToTable("CourseLessons", "ISC_Project");

                entity.Property(e => e.CourseLessonsId).HasColumnName("CourseLessons_ID");

                entity.Property(e => e.CourseOfferingsId).HasColumnName("CourseOfferings_ID");

                entity.Property(e => e.LessonTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.RoomNumber).HasMaxLength(50);

                entity.Property(e => e.SchoolId).HasColumnName("School_ID");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.HasOne(d => d.CourseOfferings)
                    .WithMany(p => p.CourseLessons)
                    .HasForeignKey(d => d.CourseOfferingsId)
                    .HasConstraintName("FK_CourseLessons.CourseOfferings_ID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.CourseLessons)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_CourseLessons.School_ID");
            });

            modelBuilder.Entity<CourseOffering>(entity =>
            {
                entity.HasKey(e => e.CourseOfferingsId)
                    .HasName("CourseOfferings_pkey");

                entity.ToTable("CourseOfferings", "ISC_Project");

                entity.Property(e => e.CourseOfferingsId).HasColumnName("CourseOfferings_ID");

                entity.Property(e => e.CoursesId).HasColumnName("Courses_ID");

                entity.Property(e => e.EndTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.InstructorUserId).HasColumnName("Instructor_user_id");

                entity.Property(e => e.Price).HasPrecision(12, 2);

                entity.Property(e => e.StarTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.HasOne(d => d.Courses)
                    .WithMany(p => p.CourseOfferings)
                    .HasForeignKey(d => d.CoursesId)
                    .HasConstraintName("FK_CourseOfferings.Courses_ID");

                entity.HasOne(d => d.InstructorUser)
                    .WithMany(p => p.CourseOfferings)
                    .HasForeignKey(d => d.InstructorUserId)
                    .HasConstraintName("FK_CourseOfferings.Instructor_user_id");
            });

            modelBuilder.Entity<CoursesLearned>(entity =>
            {
                entity.ToTable("CoursesLearned", "ISC_Project");

                entity.Property(e => e.CoursesLearnedId).HasColumnName("CoursesLearned_ID");

                entity.Property(e => e.CoursesImageUrl)
                    .HasMaxLength(512)
                    .HasColumnName("Courses_image_url");

                entity.Property(e => e.DefaultPrice)
                    .HasPrecision(12, 2)
                    .HasColumnName("Default_price");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.TotalCoursesId).HasColumnName("TotalCourses_ID");

                entity.HasOne(d => d.TotalCourses)
                    .WithMany(p => p.CoursesLearneds)
                    .HasForeignKey(d => d.TotalCoursesId)
                    .HasConstraintName("FK_CoursesLearned.TotalCourses_ID");
            });

            modelBuilder.Entity<Discipline>(entity =>
            {
                entity.ToTable("Discipline", "ISC_Project");

                entity.Property(e => e.DisciplineId).HasColumnName("Discipline_ID");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.DecisionDay)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Decision day");

                entity.Property(e => e.DisciplineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisciplineRewardUrl)
                    .HasMaxLength(512)
                    .HasColumnName("DisciplineRewardURL");

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(512)
                    .HasColumnName("FileURL");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Disciplines)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_Discipline.Class_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Disciplines)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Discipline.User_ID");
            });

            modelBuilder.Entity<DiscussionThread>(entity =>
            {
                entity.HasKey(e => e.DiscussionId)
                    .HasName("DiscussionThreads_pkey");

                entity.ToTable("DiscussionThreads", "ISC_Project");

                entity.Property(e => e.DiscussionId).HasColumnName("Discussion_ID");

                entity.Property(e => e.CreateAt).HasColumnType("timestamp without time zone");

                entity.Property(e => e.IsResolved).HasColumnName("Is_resolved");

                entity.Property(e => e.TeachingId).HasColumnName("Teaching_ID");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.ViewCount).HasColumnName("View_count");

                entity.Property(e => e.Visibility).HasMaxLength(50);

                entity.HasOne(d => d.Teaching)
                    .WithMany(p => p.DiscussionThreads)
                    .HasForeignKey(d => d.TeachingId)
                    .HasConstraintName("FK_DiscussionThreads.Teaching_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DiscussionThreads)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_DiscussionThreads.User_ID");
            });

            modelBuilder.Entity<EmploymentHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("Employment_History_pkey");

                entity.ToTable("Employment_History", "ISC_Project");

                entity.Property(e => e.HistoryId).HasColumnName("History_ID");

                entity.Property(e => e.Certificate).HasMaxLength(255);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");

                entity.Property(e => e.DecidedRetireUrl)
                    .HasMaxLength(512)
                    .HasColumnName("DecidedRetireURL");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Effective_date");

                entity.Property(e => e.Form).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EmploymentHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Employment_History.User_ID");
            });

            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasKey(e => e.EnrollmentsId)
                    .HasName("Enrollments_pkey");

                entity.ToTable("Enrollments", "ISC_Project");

                entity.Property(e => e.EnrollmentsId).HasColumnName("Enrollments_ID");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<Exemption>(entity =>
            {
                entity.HasKey(e => e.ExemptionsId)
                    .HasName("Exemptions_pkey");

                entity.ToTable("Exemptions", "ISC_Project");

                entity.Property(e => e.ExemptionsId).HasColumnName("Exemptions_ID");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.ExemptionObjects).HasMaxLength(100);

                entity.Property(e => e.FormExemption).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Exemptions)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_Exemptions.Class_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Exemptions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Exemptions.User_ID");
            });

            modelBuilder.Entity<FacultyStudyBlock>(entity =>
            {
                entity.HasKey(e => e.FacultyId)
                    .HasName("Faculty - StudyBlock_pkey");

                entity.ToTable("Faculty - StudyBlock", "ISC_Project");

                entity.Property(e => e.FacultyId).HasColumnName("Faculty_ID");

                entity.Property(e => e.FacultyCode).HasMaxLength(50);

                entity.Property(e => e.FacultyName).HasMaxLength(100);

                entity.Property(e => e.SchoolId).HasColumnName("School_ID");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.FacultyStudyBlocks)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Faculty - StudyBlock.School_ID");

                entity.HasOne(d => d.SchoolYear)
                    .WithMany(p => p.FacultyStudyBlocks)
                    .HasForeignKey(d => d.SchoolYearId)
                    .HasConstraintName("FK_Faculty - StudyBlock.SchoolYear_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FacultyStudyBlocks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Faculty - StudyBlock.User_ID");
            });

            modelBuilder.Entity<FamilyInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FamilyInformation", "ISC_Project");

                entity.Property(e => e.BirthOfFamily).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.FamilyType).HasMaxLength(50);

                entity.Property(e => e.JobFamily).HasMaxLength(255);

                entity.Property(e => e.PhoneFamily).HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_FamilyInformation.User_ID");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("Grades", "ISC_Project");

                entity.Property(e => e.GradeId).HasColumnName("Grade_ID");

                entity.Property(e => e.CreateAt).HasColumnType("timestamp without time zone");

                entity.Property(e => e.GradesCode).HasMaxLength(50);

                entity.Property(e => e.GradesName).HasMaxLength(100);

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.TrainingId).HasColumnName("Training_ID");

                entity.Property(e => e.UpdateAt).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Training)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.TrainingId)
                    .HasConstraintName("FK_Grades.Training_ID");
            });

            modelBuilder.Entity<Intern>(entity =>
            {
                entity.ToTable("Interns", "ISC_Project");
            });

            modelBuilder.Entity<Intern1>(entity =>
            {
                entity.ToTable("Interns", "ProjectOnline3");
            });

            modelBuilder.Entity<LabGrader>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LabGraders", "ISC_Project");

                entity.Property(e => e.LabSchedulesId).HasColumnName("LabSchedules_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.LabSchedules)
                    .WithMany()
                    .HasForeignKey(d => d.LabSchedulesId)
                    .HasConstraintName("FK_LabGraders.LabSchedules_ID");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_LabGraders.User_ID");
            });

            modelBuilder.Entity<LabSchedule>(entity =>
            {
                entity.HasKey(e => e.LabSchedulesId)
                    .HasName("LabSchedules_pkey");

                entity.ToTable("LabSchedules", "ISC_Project");

                entity.Property(e => e.LabSchedulesId).HasColumnName("LabSchedules_ID");

                entity.Property(e => e.DurationMinutes).HasColumnName("Duration_minutes");

                entity.Property(e => e.LabEndDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Lab_end_date");

                entity.Property(e => e.LabName)
                    .HasMaxLength(255)
                    .HasColumnName("Lab_name");

                entity.Property(e => e.LabStartDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Lab_start_date");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.SubjectId).HasColumnName("Subject_ID");

                entity.Property(e => e.TermNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Term_number");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.LabSchedules)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_LabSchedules.Subject_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LabSchedules)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_LabSchedules.User_ID");

                entity.HasMany(d => d.Questions)
                    .WithMany(p => p.LabSchedules)
                    .UsingEntity<Dictionary<string, object>>(
                        "LabScheduleQuestion",
                        l => l.HasOne<Question>().WithMany().HasForeignKey("QuestionsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_LabSchedule_Questions.Questions_ID"),
                        r => r.HasOne<LabSchedule>().WithMany().HasForeignKey("LabSchedulesId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_LabSchedule_Questions.LabSchedules_ID"),
                        j =>
                        {
                            j.HasKey("LabSchedulesId", "QuestionsId").HasName("LabSchedule_Questions_pkey");

                            j.ToTable("LabSchedule_Questions", "ISC_Project");

                            j.IndexerProperty<int>("LabSchedulesId").HasColumnName("LabSchedules_ID");

                            j.IndexerProperty<int>("QuestionsId").HasColumnName("Questions_ID");
                        });
            });

            modelBuilder.Entity<LabScheduleClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LabScheduleClasses", "ISC_Project");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.LabSchedulesId).HasColumnName("LabSchedules_ID");

                entity.HasOne(d => d.Class)
                    .WithMany()
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_LabScheduleClasses.Class_ID");

                entity.HasOne(d => d.LabSchedules)
                    .WithMany()
                    .HasForeignKey(d => d.LabSchedulesId)
                    .HasConstraintName("FK_LabScheduleClasses.LabSchedules_ID");
            });

            modelBuilder.Entity<LearningOutcome>(entity =>
            {
                entity.HasKey(e => e.LearningOutcomes)
                    .HasName("LearningOutcomes_pkey");

                entity.ToTable("LearningOutcomes", "ISC_Project");

                entity.Property(e => e.AverageScore).HasColumnName("Average score");

                entity.Property(e => e.Conduct).HasMaxLength(50);

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.ScoreId).HasColumnName("Score_ID");

                entity.Property(e => e.UpdateAt).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Score)
                    .WithMany(p => p.LearningOutcomes)
                    .HasForeignKey(d => d.ScoreId)
                    .HasConstraintName("FK_LearningOutcomes.Score_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LearningOutcomes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_LearningOutcomes.User_ID");
            });

            modelBuilder.Entity<LiveChatMessage>(entity =>
            {
                entity.HasKey(e => e.LiveChatMessagesId)
                    .HasName("LiveChatMessages_pkey");

                entity.ToTable("LiveChatMessages", "ISC_Project");

                entity.Property(e => e.LiveChatMessagesId).HasColumnName("LiveChatMessages_ID");

                entity.Property(e => e.LiveSessionsId).HasColumnName("LiveSessions_ID");

                entity.Property(e => e.MessageContent).HasColumnName("Message_content");

                entity.Property(e => e.MessageType).HasMaxLength(50);

                entity.Property(e => e.RecordingUrl)
                    .HasMaxLength(512)
                    .HasColumnName("Recording_url");

                entity.Property(e => e.SentAt).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.LiveSessions)
                    .WithMany(p => p.LiveChatMessages)
                    .HasForeignKey(d => d.LiveSessionsId)
                    .HasConstraintName("FK_LiveChatMessages.LiveSessions_ID");
            });

            modelBuilder.Entity<LiveSession>(entity =>
            {
                entity.HasKey(e => e.LiveSessionsId)
                    .HasName("LiveSessions_pkey");

                entity.ToTable("LiveSessions", "ISC_Project");

                entity.Property(e => e.LiveSessionsId).HasColumnName("LiveSessions_ID");

                entity.Property(e => e.ActualEndTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Actual_end_time");

                entity.Property(e => e.ActualStartTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Actual_start_time");

                entity.Property(e => e.RecordingUrl)
                    .HasMaxLength(512)
                    .HasColumnName("Recording_url");

                entity.Property(e => e.ScheduledStartTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Scheduled_start_time");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.TeachingId).HasColumnName("Teaching_ID");

                entity.HasOne(d => d.Teaching)
                    .WithMany(p => p.LiveSessions)
                    .HasForeignKey(d => d.TeachingId)
                    .HasConstraintName("FK_LiveSessions.Teaching_ID");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification", "ISC_Project");

                entity.Property(e => e.NotificationId).HasColumnName("Notification_ID");

                entity.Property(e => e.CreateAt).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ReceivingObject).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.UpdateAt).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Notification.User_ID");
            });

            modelBuilder.Entity<PastClass>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PastClasses_pkey");

                entity.ToTable("PastClasses", "ISC_Project");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.StartTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.PastClasses)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_PastClasses.Subject_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PastClasses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PastClasses.User_ID");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.PermissionsId)
                    .HasName("Permissions_pkey");

                entity.ToTable("Permissions", "ISC_Project");

                entity.Property(e => e.PermissionsId).HasColumnName("Permissions_ID");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .HasColumnName("Action_name");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FeatureName)
                    .HasMaxLength(100)
                    .HasColumnName("Feature_name");
            });

            modelBuilder.Entity<Qualification>(entity =>
            {
                entity.HasKey(e => e.QualificationsId)
                    .HasName("Qualifications_pkey");

                entity.ToTable("Qualifications", "ISC_Project");

                entity.Property(e => e.QualificationsId).HasColumnName("Qualifications_ID");

                entity.Property(e => e.AttachmentUrl)
                    .HasMaxLength(512)
                    .HasColumnName("Attachment_url");

                entity.Property(e => e.DegreeName)
                    .HasMaxLength(255)
                    .HasColumnName("Degree_name");

                entity.Property(e => e.Endtime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Institution).HasMaxLength(255);

                entity.Property(e => e.Major).HasMaxLength(255);

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.StarTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.StudyForm)
                    .HasMaxLength(100)
                    .HasColumnName("Study_form");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Qualifications)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Qualifications.User_ID");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.QuestionsId)
                    .HasName("Questions_pkey");

                entity.ToTable("Questions", "ISC_Project");

                entity.Property(e => e.QuestionsId).HasColumnName("Questions_ID");

                entity.Property(e => e.QuestionsText).HasColumnName("Questions_Text");

                entity.Property(e => e.QuestionsType).HasMaxLength(100);

                entity.Property(e => e.SubjectId).HasColumnName("Subject_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<QuestionOption>(entity =>
            {
                entity.HasKey(e => e.QuestionOptionsId)
                    .HasName("QuestionOptions_pkey");

                entity.ToTable("QuestionOptions", "ISC_Project");

                entity.Property(e => e.QuestionOptionsId).HasColumnName("QuestionOptions_ID");

                entity.Property(e => e.IsCorrect).HasColumnName("Is_correct");

                entity.Property(e => e.OptionText).HasColumnName("Option_text");

                entity.Property(e => e.QuestionsId).HasColumnName("Questions_ID");

                entity.HasOne(d => d.Questions)
                    .WithMany(p => p.QuestionOptions)
                    .HasForeignKey(d => d.QuestionsId)
                    .HasConstraintName("FK_QuestionOptions.Questions_ID");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.RegistrationsId)
                    .HasName("Registrations_pkey");

                entity.ToTable("Registrations", "ISC_Project");

                entity.Property(e => e.RegistrationsId).HasColumnName("Registrations_ID");

                entity.Property(e => e.Campus).HasMaxLength(255);

                entity.Property(e => e.CourseOfferingsId).HasColumnName("CourseOfferings_ID");

                entity.Property(e => e.CourserName).HasMaxLength(255);

                entity.Property(e => e.EducationLevel)
                    .HasMaxLength(100)
                    .HasColumnName("Education level");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Nationality).HasMaxLength(100);

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Payment_status");

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Registration_date");

                entity.Property(e => e.RegistrationsImageUrl)
                    .HasMaxLength(512)
                    .HasColumnName("Registrations_Image_Url");

                entity.Property(e => e.Sex).HasMaxLength(100);

                entity.Property(e => e.StudentName).HasMaxLength(255);

                entity.Property(e => e.StudentUserId).HasColumnName("Student_user_ID");

                entity.HasOne(d => d.CourseOfferings)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.CourseOfferingsId)
                    .HasConstraintName("FK_Registrations.CourseOfferings_ID");

                entity.HasOne(d => d.StudentUser)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.StudentUserId)
                    .HasConstraintName("FK_Registrations.Student_user_ID");
            });

            modelBuilder.Entity<RelativesInformation>(entity =>
            {
                entity.ToTable("RelativesInformation", "ISC_Project");

                entity.Property(e => e.RelativesInformationId).HasColumnName("RelativesInformation_ID");

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.RegistrationsId).HasColumnName("Registrations_ID");

                entity.Property(e => e.RelativesName).HasMaxLength(255);

                entity.HasOne(d => d.Registrations)
                    .WithMany(p => p.RelativesInformations)
                    .HasForeignKey(d => d.RegistrationsId)
                    .HasConstraintName("FK_RelativesInformation.Registrations_ID");
            });

            modelBuilder.Entity<Reserved>(entity =>
            {
                entity.HasKey(e => e.ReasonId)
                    .HasName("Reserved_pkey");

                entity.ToTable("Reserved", "ISC_Project");

                entity.Property(e => e.ReasonId).HasColumnName("Reason_ID");

                entity.Property(e => e.ClassIdmoveTo).HasColumnName("Class_IDMoveTo");

                entity.Property(e => e.ClassIdpresent).HasColumnName("Class_IDPresent");

                entity.Property(e => e.DateReserved).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(512)
                    .HasColumnName("FileURL");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reserveds)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Reserved.User_ID");
            });

            modelBuilder.Entity<Reward>(entity =>
            {
                entity.ToTable("Reward", "ISC_Project");

                entity.Property(e => e.RewardId).HasColumnName("Reward_ID");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.DecisionDay)
                    .HasMaxLength(50)
                    .HasColumnName("Decision day");

                entity.Property(e => e.DecisionRewardUrl)
                    .HasMaxLength(512)
                    .HasColumnName("DecisionRewardURL");

                entity.Property(e => e.Field).HasMaxLength(255);

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(512)
                    .HasColumnName("FileURL");

                entity.Property(e => e.RewardDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Rewards)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Reward.User_ID");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Roles", "ISC_Project");
            });

            modelBuilder.Entity<Role1>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("Role_pkey");

                entity.ToTable("Role", "ISC_Project");

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.IsAdmin).HasColumnName("Is_admin");

                entity.Property(e => e.RoleName).HasMaxLength(100);
            });

            modelBuilder.Entity<Role2>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("Roles", "ProjectOnline3");
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RolePermissions", "ISC_Project");

                entity.Property(e => e.PermissionsId).HasColumnName("Permissions_ID");

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.HasOne(d => d.Permissions)
                    .WithMany()
                    .HasForeignKey(d => d.PermissionsId)
                    .HasConstraintName("FK_RolePermissions.Permissions_ID");

                entity.HasOne(d => d.Role)
                    .WithMany()
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RolePermissions.Role_ID");
            });

            modelBuilder.Entity<SchoolProfile>(entity =>
            {
                entity.HasKey(e => e.SchoolId)
                    .HasName("SchoolProfile_pkey");

                entity.ToTable("SchoolProfile", "ISC_Project");

                entity.Property(e => e.SchoolId).HasColumnName("School_ID");

                entity.Property(e => e.CommuneWard)
                    .HasMaxLength(100)
                    .HasColumnName("Commune/Ward");

                entity.Property(e => e.DateEstablishment).HasMaxLength(50);

                entity.Property(e => e.District).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(512)
                    .HasColumnName("FileURL");

                entity.Property(e => e.HeadOffice)
                    .HasMaxLength(255)
                    .HasColumnName("Head office");

                entity.Property(e => e.PhoneFax).HasMaxLength(20);

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.PhonePrincipal).HasMaxLength(20);

                entity.Property(e => e.PrincipalName).HasMaxLength(255);

                entity.Property(e => e.ProvinceCity)
                    .HasMaxLength(100)
                    .HasColumnName("Province/City");

                entity.Property(e => e.SchoolCode).HasMaxLength(50);

                entity.Property(e => e.SchoolName).HasMaxLength(255);

                entity.Property(e => e.SchoolType).HasMaxLength(100);

                entity.Property(e => e.TrainingModel)
                    .HasMaxLength(255)
                    .HasColumnName("Training model");

                entity.Property(e => e.Webside).HasMaxLength(255);
            });

            modelBuilder.Entity<SchoolYear>(entity =>
            {
                entity.ToTable("School Year", "ISC_Project");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.EndTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SchoolId).HasColumnName("School_ID");

                entity.Property(e => e.SchoolYearName).HasMaxLength(100);

                entity.Property(e => e.StarTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.SchoolYears)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_School Year.School_ID");
            });

            modelBuilder.Entity<Score>(entity =>
            {
                entity.ToTable("Score", "ISC_Project");

                entity.Property(e => e.ScoreId).HasColumnName("Score_ID");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.Coefficient).HasMaxLength(100);

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.Semester).HasMaxLength(20);

                entity.Property(e => e.SubjectsId).HasColumnName("Subjects_ID");

                entity.HasOne(d => d.Subjects)
                    .WithMany(p => p.Scores)
                    .HasForeignKey(d => d.SubjectsId)
                    .HasConstraintName("FK_Score.Subjects_ID");
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.ToTable("Semester", "ISC_Project");

                entity.Property(e => e.SemesterId).HasColumnName("Semester_ID");

                entity.Property(e => e.EndTimeSemester).HasColumnType("timestamp without time zone");

                entity.Property(e => e.IsCurrent).HasColumnName("Is_Current");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.SemesterName).HasMaxLength(100);

                entity.Property(e => e.StarTimeSemester).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.SchoolYear)
                    .WithMany(p => p.Semesters)
                    .HasForeignKey(d => d.SchoolYearId)
                    .HasConstraintName("FK_Semester.SchoolYear_ID");
            });

            modelBuilder.Entity<StudentGrade>(entity =>
            {
                entity.HasKey(e => e.StudentGradesId)
                    .HasName("Student_Grades_pkey");

                entity.ToTable("Student_Grades", "ISC_Project");

                entity.Property(e => e.StudentGradesId).HasColumnName("Student_Grades_ID");

                entity.Property(e => e.GradedTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Graded_time");

                entity.Property(e => e.SubmissionId).HasColumnName("Submission_id");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StudentGrades)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Student_Grades.User_ID");
            });

            modelBuilder.Entity<StudentMcqanswer>(entity =>
            {
                entity.HasKey(e => e.StudentMcqanswersId)
                    .HasName("StudentMCQAnswers_pkey");

                entity.ToTable("StudentMCQAnswers", "ISC_Project");

                entity.Property(e => e.StudentMcqanswersId).HasColumnName("StudentMCQAnswers_ID");

                entity.Property(e => e.QuestionOptionsId).HasColumnName("QuestionOptions_ID");

                entity.Property(e => e.QuestionsId).HasColumnName("Questions_ID");

                entity.Property(e => e.SubmissionsId).HasColumnName("Submissions_ID");

                entity.HasOne(d => d.QuestionOptions)
                    .WithMany(p => p.StudentMcqanswers)
                    .HasForeignKey(d => d.QuestionOptionsId)
                    .HasConstraintName("FK_StudentMCQAnswers.QuestionOptions_ID");

                entity.HasOne(d => d.Questions)
                    .WithMany(p => p.StudentMcqanswers)
                    .HasForeignKey(d => d.QuestionsId)
                    .HasConstraintName("FK_StudentMCQAnswers.Questions_ID");

                entity.HasOne(d => d.Submissions)
                    .WithMany(p => p.StudentMcqanswers)
                    .HasForeignKey(d => d.SubmissionsId)
                    .HasConstraintName("FK_StudentMCQAnswers.Submissions_ID");
            });

            modelBuilder.Entity<StudentSubmission>(entity =>
            {
                entity.HasKey(e => e.SubmissionsId)
                    .HasName("Student_Submissions_pkey");

                entity.ToTable("Student_Submissions", "ISC_Project");

                entity.Property(e => e.SubmissionsId).HasColumnName("Submissions_ID");

                entity.Property(e => e.AssessmentPartsId).HasColumnName("AssessmentParts_ID");

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(512)
                    .HasColumnName("File_url");

                entity.Property(e => e.LabSchedulesId).HasColumnName("LabSchedules_ID");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.SubmissionTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Submission_time");

                entity.Property(e => e.TextAnswer).HasColumnName("Text_answer");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.AssessmentParts)
                    .WithMany(p => p.StudentSubmissions)
                    .HasForeignKey(d => d.AssessmentPartsId)
                    .HasConstraintName("FK_Student_Submissions.AssessmentParts_ID");

                entity.HasOne(d => d.LabSchedules)
                    .WithMany(p => p.StudentSubmissions)
                    .HasForeignKey(d => d.LabSchedulesId)
                    .HasConstraintName("FK_Student_Submissions.LabSchedules_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StudentSubmissions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Student_Submissions.User_ID");
            });

            modelBuilder.Entity<StudentsChangeClass>(entity =>
            {
                entity.HasKey(e => e.StudentsChangeClassesId)
                    .HasName("StudentsChangeClasses_pkey");

                entity.ToTable("StudentsChangeClasses", "ISC_Project");

                entity.Property(e => e.StudentsChangeClassesId).HasColumnName("StudentsChangeClasses_ID");

                entity.Property(e => e.ClassIdmoveTo).HasColumnName("Class_IDMoveTo");

                entity.Property(e => e.ClassIdpresent).HasColumnName("Class_IDPresent");

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(512)
                    .HasColumnName("FileURL");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StudentsChangeClasses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_StudentsChangeClasses.User_ID");
            });

            modelBuilder.Entity<StudentsChangeSchool>(entity =>
            {
                entity.ToTable("StudentsChangeSchool", "ISC_Project");

                entity.Property(e => e.StudentsChangeSchoolId).HasColumnName("StudentsChangeSchool_ID");

                entity.Property(e => e.AddressSchoolTransferred)
                    .HasMaxLength(512)
                    .HasColumnName("AddressSchool Transferred");

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(512)
                    .HasColumnName("FileURL");

                entity.Property(e => e.NameSchoolTransferred).HasMaxLength(255);

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<StudentsProfile>(entity =>
            {
                entity.ToTable("StudentsProfile", "ISC_Project");

                entity.Property(e => e.StudentsProfileId).HasColumnName("StudentsProfile_ID");

                entity.Property(e => e.AdmissionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Admission date");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.DateOfBirth).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(512)
                    .HasColumnName("FileURL");

                entity.Property(e => e.Form).HasMaxLength(100);

                entity.Property(e => e.Nation).HasMaxLength(100);

                entity.Property(e => e.PlaceOfBirth).HasMaxLength(255);

                entity.Property(e => e.Religion).HasMaxLength(100);

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.Sex).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.StudentCode).HasMaxLength(50);

                entity.Property(e => e.StudentName).HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.SubjectsId)
                    .HasName("Subjects_pkey");

                entity.ToTable("Subjects", "ISC_Project");

                entity.Property(e => e.SubjectsId).HasColumnName("Subjects_ID");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.EndTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.StarTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SubjectCode).HasMaxLength(50);

                entity.Property(e => e.SubjectTypeId).HasColumnName("SubjectType_ID");

                entity.Property(e => e.SubjectsName).HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Subjects.Department_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Subjects.User_ID");
            });

            modelBuilder.Entity<SubjectType>(entity =>
            {
                entity.ToTable("SubjectType", "ISC_Project");

                entity.Property(e => e.SubjectTypeId).HasColumnName("SubjectType_ID");
            });

            modelBuilder.Entity<SubjectsClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Subjects_Class", "ISC_Project");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.SubjectsId).HasColumnName("Subjects_ID");

                entity.HasOne(d => d.Class)
                    .WithMany()
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_Subjects_Class.Class_ID");

                entity.HasOne(d => d.Subjects)
                    .WithMany()
                    .HasForeignKey(d => d.SubjectsId)
                    .HasConstraintName("FK_Subjects_Class.Subjects_ID");
            });

            modelBuilder.Entity<SyllabusTopic>(entity =>
            {
                entity.HasKey(e => e.SyllabusId)
                    .HasName("Syllabus_topics_pkey");

                entity.ToTable("Syllabus_topics", "ISC_Project");

                entity.Property(e => e.SyllabusId).HasColumnName("Syllabus_ID");

                entity.Property(e => e.EndTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OrderIndex).HasColumnName("Order_index");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.StarTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.TeachingId).HasColumnName("Teaching_ID");

                entity.Property(e => e.TopicTitle)
                    .HasMaxLength(255)
                    .HasColumnName("Topic_title");
            });

            modelBuilder.Entity<SystemSetting>(entity =>
            {
                entity.HasKey(e => e.SettingKey)
                    .HasName("SystemSettings_pkey");

                entity.ToTable("SystemSettings", "ISC_Project");

                entity.Property(e => e.SettingKey)
                    .HasMaxLength(100)
                    .HasColumnName("Setting_key");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.SettingValue).HasColumnName("Setting_value");
            });

            modelBuilder.Entity<TeacherProfile>(entity =>
            {
                entity.HasKey(e => e.TeacherId)
                    .HasName("TeacherProfile_pkey");

                entity.ToTable("TeacherProfile", "ISC_Project");

                entity.Property(e => e.TeacherId).HasColumnName("Teacher_ID");

                entity.Property(e => e.Address).HasMaxLength(512);

                entity.Property(e => e.AdmissionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Admission date");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.DateOfBirth).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(512)
                    .HasColumnName("FileURL");

                entity.Property(e => e.Form).HasMaxLength(100);

                entity.Property(e => e.Nation).HasMaxLength(100);

                entity.Property(e => e.PartyMember).HasColumnName("Party member");

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.PlaceOfBirth).HasMaxLength(255);

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.Religion).HasMaxLength(100);

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.SubjectId).HasColumnName("Subject_ID");

                entity.Property(e => e.TeacherCode).HasMaxLength(50);

                entity.Property(e => e.TeacherName).HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TeacherProfiles)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_TeacherProfile.Class_ID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TeacherProfiles)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_TeacherProfile.Department_ID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TeacherProfiles)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_TeacherProfile.Subject_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TeacherProfiles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_TeacherProfile.User_ID");
            });

            modelBuilder.Entity<TeachingAssessment>(entity =>
            {
                entity.HasKey(e => e.TeachingId)
                    .HasName("Teaching_Assessment_pkey");

                entity.ToTable("Teaching_Assessment", "ISC_Project");

                entity.Property(e => e.TeachingId).HasColumnName("Teaching_ID");

                entity.Property(e => e.AssignmentType).HasMaxLength(100);

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.EndTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.StarTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TeachingAssessments)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_Teaching_Assessment.Class_ID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TeachingAssessments)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_Teaching_Assessment.Subject_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TeachingAssessments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Teaching_Assessment.User_ID");
            });

            modelBuilder.Entity<TeamDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("Team-Department_pkey");

                entity.ToTable("Team-Department", "ISC_Project");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.DepartmentName).HasMaxLength(100);

                entity.Property(e => e.SchoolId).HasColumnName("School_ID");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.TeamDepartments)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Team-Department.School_ID");

                entity.HasOne(d => d.SchoolYear)
                    .WithMany(p => p.TeamDepartments)
                    .HasForeignKey(d => d.SchoolYearId)
                    .HasConstraintName("FK_Team-Department.SchoolYear_ID");
            });

            modelBuilder.Entity<ThreadPost>(entity =>
            {
                entity.HasKey(e => e.ThreadPostsId)
                    .HasName("ThreadPosts_pkey");

                entity.ToTable("ThreadPosts", "ISC_Project");

                entity.Property(e => e.ThreadPostsId).HasColumnName("ThreadPosts_ID");

                entity.Property(e => e.AttachmentUrl)
                    .HasMaxLength(512)
                    .HasColumnName("Attachment_url");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_at");

                entity.Property(e => e.DiscussionId).HasColumnName("Discussion_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Discussion)
                    .WithMany(p => p.ThreadPosts)
                    .HasForeignKey(d => d.DiscussionId)
                    .HasConstraintName("FK_ThreadPosts.Discussion_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ThreadPosts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ThreadPosts.User_ID");
            });

            modelBuilder.Entity<TotalCoursesTaken>(entity =>
            {
                entity.HasKey(e => e.TotalCoursesId)
                    .HasName("TotalCoursesTaken_pkey");

                entity.ToTable("TotalCoursesTaken", "ISC_Project");

                entity.Property(e => e.TotalCoursesId).HasColumnName("TotalCourses_ID");

                entity.Property(e => e.CoursesLearnedId).HasColumnName("CoursesLearned_ID");

                entity.Property(e => e.TotalPayment).HasPrecision(12, 2);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TotalCoursesTakens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_TotalCoursesTaken.User_ID");
            });

            modelBuilder.Entity<TrainingLevel>(entity =>
            {
                entity.HasKey(e => e.TrainingId)
                    .HasName("TrainingLevels_pkey");

                entity.ToTable("TrainingLevels", "ISC_Project");

                entity.Property(e => e.TrainingId).HasColumnName("Training_ID");

                entity.Property(e => e.DurationYears).HasColumnName("Duration_years");

                entity.Property(e => e.ElectiveCredits).HasColumnName("Elective_credits");

                entity.Property(e => e.IsActive).HasColumnName("Is_active");

                entity.Property(e => e.IsCreditBased).HasColumnName("Is_credit_based");

                entity.Property(e => e.IsCreditYearBased)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("Is_credit_year_based");

                entity.Property(e => e.RequiredCredits).HasColumnName("Required_credits");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.TrainingName).HasMaxLength(255);
            });

            modelBuilder.Entity<UpcomingClass>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("UpcomingClass_pkey");

                entity.ToTable("UpcomingClass", "ISC_Project");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.StartTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.SubjectId).HasColumnName("Subject_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.UpcomingClasses)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_UpcomingClass.Subject_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UpcomingClasses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UpcomingClass.User_ID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users", "ProjectOnline3");

                entity.HasIndex(e => e.RoleId, "IX_Users_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<User1>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("User_pkey");

                entity.ToTable("User", "ISC_Project");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.AvatarUrl)
                    .HasMaxLength(512)
                    .HasColumnName("AvatarURL");

                entity.Property(e => e.CreateAt).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.HistoryId).HasColumnName("History_ID");

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.Token).HasMaxLength(512);

                entity.Property(e => e.UpdateAt).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User1s)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_User.Role_ID");
            });

            modelBuilder.Entity<User2>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Users", "ISC_Project");

                entity.HasIndex(e => e.RoleId, "IX_Users_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User2s)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<WorkHistory>(entity =>
            {
                entity.HasKey(e => e.WordId)
                    .HasName("WorkHistories_pkey");

                entity.ToTable("WorkHistories", "ISC_Project");

                entity.Property(e => e.WordId).HasColumnName("Word_ID");

                entity.Property(e => e.ClassId).HasColumnName("Class_ID");

                entity.Property(e => e.Department).HasMaxLength(100);

                entity.Property(e => e.Endtime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OrganizationName)
                    .HasMaxLength(255)
                    .HasColumnName("Organization_name");

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.SchoolYearId).HasColumnName("SchoolYear_ID");

                entity.Property(e => e.StarTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.TrainingType).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WorkHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_WorkHistories.User_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
