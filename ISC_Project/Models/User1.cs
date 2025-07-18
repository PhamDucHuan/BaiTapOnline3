using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class User1
    {
        public User1()
        {
            AcceptingSchoolTransfers = new HashSet<AcceptingSchoolTransfer>();
            ClassDetails = new HashSet<ClassDetail>();
            ClassSessions = new HashSet<ClassSession>();
            Classes = new HashSet<Class>();
            CourseOfferings = new HashSet<CourseOffering>();
            Disciplines = new HashSet<Discipline>();
            DiscussionThreads = new HashSet<DiscussionThread>();
            EmploymentHistories = new HashSet<EmploymentHistory>();
            Exemptions = new HashSet<Exemption>();
            FacultyStudyBlocks = new HashSet<FacultyStudyBlock>();
            LabSchedules = new HashSet<LabSchedule>();
            LearningOutcomes = new HashSet<LearningOutcome>();
            Notifications = new HashSet<Notification>();
            PastClasses = new HashSet<PastClass>();
            Qualifications = new HashSet<Qualification>();
            Registrations = new HashSet<Registration>();
            Reserveds = new HashSet<Reserved>();
            Rewards = new HashSet<Reward>();
            StudentGrades = new HashSet<StudentGrade>();
            StudentSubmissions = new HashSet<StudentSubmission>();
            StudentsChangeClasses = new HashSet<StudentsChangeClass>();
            Subjects = new HashSet<Subject>();
            TeacherProfiles = new HashSet<TeacherProfile>();
            TeachingAssessments = new HashSet<TeachingAssessment>();
            TeamDepartments = new HashSet<TeamDepartment>();
            ThreadPosts = new HashSet<ThreadPost>();
            TotalCoursesTakens = new HashSet<TotalCoursesTaken>();
            UpcomingClasses = new HashSet<UpcomingClass>();
            WorkHistories = new HashSet<WorkHistory>();
        }

        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? AvatarUrl { get; set; }
        public string? Status { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? Token { get; set; }
        public int? HistoryId { get; set; }
        public int? GroupId { get; set; }
        public int? RoleId { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual Role1? Role { get; set; }
        public virtual ICollection<AcceptingSchoolTransfer> AcceptingSchoolTransfers { get; set; }
        public virtual ICollection<ClassDetail> ClassDetails { get; set; }
        public virtual ICollection<ClassSession> ClassSessions { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<CourseOffering> CourseOfferings { get; set; }
        public virtual ICollection<Discipline> Disciplines { get; set; }
        public virtual ICollection<DiscussionThread> DiscussionThreads { get; set; }
        public virtual ICollection<EmploymentHistory> EmploymentHistories { get; set; }
        public virtual ICollection<Exemption> Exemptions { get; set; }
        public virtual ICollection<FacultyStudyBlock> FacultyStudyBlocks { get; set; }
        public virtual ICollection<LabSchedule> LabSchedules { get; set; }
        public virtual ICollection<LearningOutcome> LearningOutcomes { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<PastClass> PastClasses { get; set; }
        public virtual ICollection<Qualification> Qualifications { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<Reserved> Reserveds { get; set; }
        public virtual ICollection<Reward> Rewards { get; set; }
        public virtual ICollection<StudentGrade> StudentGrades { get; set; }
        public virtual ICollection<StudentSubmission> StudentSubmissions { get; set; }
        public virtual ICollection<StudentsChangeClass> StudentsChangeClasses { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<TeacherProfile> TeacherProfiles { get; set; }
        public virtual ICollection<TeachingAssessment> TeachingAssessments { get; set; }
        public virtual ICollection<TeamDepartment> TeamDepartments { get; set; }
        public virtual ICollection<ThreadPost> ThreadPosts { get; set; }
        public virtual ICollection<TotalCoursesTaken> TotalCoursesTakens { get; set; }
        public virtual ICollection<UpcomingClass> UpcomingClasses { get; set; }
        public virtual ICollection<WorkHistory> WorkHistories { get; set; }
    }
}
