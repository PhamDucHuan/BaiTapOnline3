using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ISC_Project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ISC_Project");

            migrationBuilder.CreateTable(
                name: "ClassType",
                schema: "ISC_Project",
                columns: table => new
                {
                    ClassType_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClassTypeName = table.Column<string>(type: "text", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassType", x => x.ClassType_ID);
                });

            migrationBuilder.CreateTable(
                name: "CourseCategories",
                schema: "ISC_Project",
                columns: table => new
                {
                    CourseCategories_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CourseCategoriesName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CourseCategories_pkey", x => x.CourseCategories_ID);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                schema: "ISC_Project",
                columns: table => new
                {
                    Enrollments_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Enrollments_pkey", x => x.Enrollments_ID);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                schema: "ISC_Project",
                columns: table => new
                {
                    Permissions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Feature_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Action_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Permissions_pkey", x => x.Permissions_ID);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                schema: "ISC_Project",
                columns: table => new
                {
                    Questions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Questions_Text = table.Column<string>(type: "text", nullable: true),
                    QuestionsType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    Subject_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Questions_pkey", x => x.Questions_ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "ISC_Project",
                columns: table => new
                {
                    Role_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Is_admin = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Role_ID);
                });

            migrationBuilder.CreateTable(
                name: "SchoolProfile",
                schema: "ISC_Project",
                columns: table => new
                {
                    School_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SchoolName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    SchoolCode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ProvinceCity = table.Column<string>(name: "Province/City", type: "character varying(100)", maxLength: 100, nullable: true),
                    CommuneWard = table.Column<string>(name: "Commune/Ward", type: "character varying(100)", maxLength: 100, nullable: true),
                    District = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Headoffice = table.Column<string>(name: "Head office", type: "character varying(255)", maxLength: 255, nullable: true),
                    SchoolType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    PhoneFax = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DateEstablishment = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Trainingmodel = table.Column<string>(name: "Training model", type: "character varying(255)", maxLength: 255, nullable: true),
                    Webside = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    PrincipalName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    PhonePrincipal = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    FileURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SchoolProfile_pkey", x => x.School_ID);
                });

            migrationBuilder.CreateTable(
                name: "StudentsChangeSchool",
                schema: "ISC_Project",
                columns: table => new
                {
                    StudentsChangeSchool_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reason = table.Column<string>(type: "text", nullable: true),
                    NameSchoolTransferred = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    AddressSchoolTransferred = table.Column<string>(name: "AddressSchool Transferred", type: "character varying(512)", maxLength: 512, nullable: true),
                    FileURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsChangeSchool", x => x.StudentsChangeSchool_ID);
                });

            migrationBuilder.CreateTable(
                name: "StudentsProfile",
                schema: "ISC_Project",
                columns: table => new
                {
                    StudentsProfile_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    StudentCode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Sex = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Nation = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Religion = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Admissiondate = table.Column<DateTime>(name: "Admission date", type: "timestamp without time zone", nullable: true),
                    Form = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    NumberRewards = table.Column<int>(type: "integer", nullable: true),
                    NumberDisciplinaryActions = table.Column<int>(type: "integer", nullable: true),
                    FileURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true),
                    Department_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsProfile", x => x.StudentsProfile_ID);
                });

            migrationBuilder.CreateTable(
                name: "SubjectType",
                schema: "ISC_Project",
                columns: table => new
                {
                    SubjectType_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SubjectTypeName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectType", x => x.SubjectType_ID);
                });

            migrationBuilder.CreateTable(
                name: "Syllabus_topics",
                schema: "ISC_Project",
                columns: table => new
                {
                    Syllabus_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Teaching_ID = table.Column<int>(type: "integer", nullable: true),
                    Topic_title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Order_index = table.Column<int>(type: "integer", nullable: true),
                    StarTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Syllabus_topics_pkey", x => x.Syllabus_ID);
                });

            migrationBuilder.CreateTable(
                name: "SystemSettings",
                schema: "ISC_Project",
                columns: table => new
                {
                    Setting_key = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Setting_value = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SystemSettings_pkey", x => x.Setting_key);
                });

            migrationBuilder.CreateTable(
                name: "TrainingLevels",
                schema: "ISC_Project",
                columns: table => new
                {
                    Training_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    TrainingForm = table.Column<string>(type: "text", nullable: true),
                    Is_credit_based = table.Column<bool>(type: "boolean", nullable: true),
                    Is_credit_year_based = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Duration_years = table.Column<int>(type: "integer", nullable: true),
                    Required_credits = table.Column<int>(type: "integer", nullable: true),
                    Elective_credits = table.Column<int>(type: "integer", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true),
                    Is_active = table.Column<bool>(type: "boolean", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TrainingLevels_pkey", x => x.Training_ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                schema: "ISC_Project",
                columns: table => new
                {
                    Courses_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Syllabus = table.Column<string>(type: "text", nullable: true),
                    Default_price = table.Column<decimal>(type: "numeric(12,2)", precision: 12, scale: 2, nullable: true),
                    Courses_image_url = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    CourseCategories_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Courses_pkey", x => x.Courses_ID);
                    table.ForeignKey(
                        name: "FK_Courses.CourseCategories_ID",
                        column: x => x.CourseCategories_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "CourseCategories",
                        principalColumn: "CourseCategories_ID");
                });

            migrationBuilder.CreateTable(
                name: "AssessmentQuestions",
                schema: "ISC_Project",
                columns: table => new
                {
                    AssessmentQuestions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Question_order = table.Column<int>(type: "integer", nullable: true),
                    Questions_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("AssessmentQuestions_pkey", x => x.AssessmentQuestions_ID);
                    table.ForeignKey(
                        name: "FK_AssessmentQuestions.Questions_ID",
                        column: x => x.Questions_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Questions",
                        principalColumn: "Questions_ID");
                });

            migrationBuilder.CreateTable(
                name: "QuestionOptions",
                schema: "ISC_Project",
                columns: table => new
                {
                    QuestionOptions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Questions_ID = table.Column<int>(type: "integer", nullable: true),
                    Option_text = table.Column<string>(type: "text", nullable: true),
                    Is_correct = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("QuestionOptions_pkey", x => x.QuestionOptions_ID);
                    table.ForeignKey(
                        name: "FK_QuestionOptions.Questions_ID",
                        column: x => x.Questions_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Questions",
                        principalColumn: "Questions_ID");
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                schema: "ISC_Project",
                columns: table => new
                {
                    Role_ID = table.Column<int>(type: "integer", nullable: true),
                    Permissions_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_RolePermissions.Permissions_ID",
                        column: x => x.Permissions_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Permissions",
                        principalColumn: "Permissions_ID");
                    table.ForeignKey(
                        name: "FK_RolePermissions.Role_ID",
                        column: x => x.Role_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Role",
                        principalColumn: "Role_ID");
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "ISC_Project",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    FullName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    AvatarURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Token = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    History_ID = table.Column<int>(type: "integer", nullable: true),
                    Group_ID = table.Column<int>(type: "integer", nullable: true),
                    Role_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.User_ID);
                    table.ForeignKey(
                        name: "FK_User.Role_ID",
                        column: x => x.Role_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Role",
                        principalColumn: "Role_ID");
                });

            migrationBuilder.CreateTable(
                name: "Campuses",
                schema: "ISC_Project",
                columns: table => new
                {
                    Campuses_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    phone_number = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Manager_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    School_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Campuses_pkey", x => x.Campuses_ID);
                    table.ForeignKey(
                        name: "FK_Campuses.School_ID",
                        column: x => x.School_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "SchoolProfile",
                        principalColumn: "School_ID");
                });

            migrationBuilder.CreateTable(
                name: "School Year",
                schema: "ISC_Project",
                columns: table => new
                {
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SchoolYearName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    StarTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    School_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School Year", x => x.SchoolYear_ID);
                    table.ForeignKey(
                        name: "FK_School Year.School_ID",
                        column: x => x.School_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "SchoolProfile",
                        principalColumn: "School_ID");
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                schema: "ISC_Project",
                columns: table => new
                {
                    Grade_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GradesName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    GradesCode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    Training_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Grade_ID);
                    table.ForeignKey(
                        name: "FK_Grades.Training_ID",
                        column: x => x.Training_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "TrainingLevels",
                        principalColumn: "Training_ID");
                });

            migrationBuilder.CreateTable(
                name: "AcceptingSchoolTransfers",
                schema: "ISC_Project",
                columns: table => new
                {
                    AcceptingSchoolTransfers_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MoveinDate = table.Column<DateTime>(name: "Move-in Date", type: "timestamp without time zone", nullable: true),
                    SemesterMoveIn = table.Column<int>(type: "integer", nullable: true),
                    Province = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    District = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Convertfrom = table.Column<string>(name: "Convert from", type: "character varying(255)", maxLength: 255, nullable: true),
                    Reason = table.Column<string>(type: "text", nullable: true),
                    FileURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("AcceptingSchoolTransfers_pkey", x => x.AcceptingSchoolTransfers_ID);
                    table.ForeignKey(
                        name: "FK_AcceptingSchoolTransfers.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "CourseOfferings",
                schema: "ISC_Project",
                columns: table => new
                {
                    CourseOfferings_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StarTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    MaxStudent = table.Column<int>(type: "integer", nullable: true),
                    Price = table.Column<decimal>(type: "numeric(12,2)", precision: 12, scale: 2, nullable: true),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Courses_ID = table.Column<int>(type: "integer", nullable: true),
                    Instructor_user_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CourseOfferings_pkey", x => x.CourseOfferings_ID);
                    table.ForeignKey(
                        name: "FK_CourseOfferings.Courses_ID",
                        column: x => x.Courses_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Courses",
                        principalColumn: "Courses_ID");
                    table.ForeignKey(
                        name: "FK_CourseOfferings.Instructor_user_id",
                        column: x => x.Instructor_user_id,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Employment_History",
                schema: "ISC_Project",
                columns: table => new
                {
                    History_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Effective_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true),
                    Certificate = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Form = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DecidedRetireURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    CreatedByID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Employment_History_pkey", x => x.History_ID);
                    table.ForeignKey(
                        name: "FK_Employment_History.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "FamilyInformation",
                schema: "ISC_Project",
                columns: table => new
                {
                    FamilyName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    BirthOfFamily = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    JobFamily = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    PhoneFamily = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    FamilyType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_FamilyInformation.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                schema: "ISC_Project",
                columns: table => new
                {
                    Notification_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReceivingObject = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Notification_ID);
                    table.ForeignKey(
                        name: "FK_Notification.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                schema: "ISC_Project",
                columns: table => new
                {
                    Qualifications_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Institution = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Major = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Study_form = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    StarTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Endtime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Degree_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Attachment_url = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Qualifications_pkey", x => x.Qualifications_ID);
                    table.ForeignKey(
                        name: "FK_Qualifications.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Reserved",
                schema: "ISC_Project",
                columns: table => new
                {
                    Reason_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reason = table.Column<string>(type: "text", nullable: true),
                    DateReserved = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ReservedPeriod = table.Column<int>(type: "integer", nullable: true),
                    FileURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    Class_IDPresent = table.Column<int>(type: "integer", nullable: true),
                    Class_IDMoveTo = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Reserved_pkey", x => x.Reason_ID);
                    table.ForeignKey(
                        name: "FK_Reserved.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Reward",
                schema: "ISC_Project",
                columns: table => new
                {
                    Reward_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RewardDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: true),
                    Field = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DecisionRewardURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Decisionday = table.Column<string>(name: "Decision day", type: "character varying(50)", maxLength: 50, nullable: true),
                    FileURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reward", x => x.Reward_ID);
                    table.ForeignKey(
                        name: "FK_Reward.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Student_Grades",
                schema: "ISC_Project",
                columns: table => new
                {
                    Student_Grades_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Score = table.Column<double>(type: "double precision", nullable: true),
                    Comments = table.Column<string>(type: "text", nullable: true),
                    Graded_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Submission_id = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Student_Grades_pkey", x => x.Student_Grades_ID);
                    table.ForeignKey(
                        name: "FK_Student_Grades.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "StudentsChangeClasses",
                schema: "ISC_Project",
                columns: table => new
                {
                    StudentsChangeClasses_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reason = table.Column<string>(type: "text", nullable: true),
                    FileURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Class_IDPresent = table.Column<int>(type: "integer", nullable: true),
                    Class_IDMoveTo = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("StudentsChangeClasses_pkey", x => x.StudentsChangeClasses_ID);
                    table.ForeignKey(
                        name: "FK_StudentsChangeClasses.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Team-Department",
                schema: "ISC_Project",
                columns: table => new
                {
                    Department_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DepartmentName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    School_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Team-Department_pkey", x => x.Department_ID);
                    table.ForeignKey(
                        name: "FK_Team-Department.School_ID",
                        column: x => x.School_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "SchoolProfile",
                        principalColumn: "School_ID");
                    table.ForeignKey(
                        name: "FK_Team-Department.SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "TotalCoursesTaken",
                schema: "ISC_Project",
                columns: table => new
                {
                    TotalCourses_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TotalNumberCourses = table.Column<int>(type: "integer", nullable: true),
                    TotalPayment = table.Column<decimal>(type: "numeric(12,2)", precision: 12, scale: 2, nullable: true),
                    CoursesLearned_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TotalCoursesTaken_pkey", x => x.TotalCourses_ID);
                    table.ForeignKey(
                        name: "FK_TotalCoursesTaken.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "WorkHistories",
                schema: "ISC_Project",
                columns: table => new
                {
                    Word_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Organization_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Department = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Position = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    StarTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Endtime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CertificateName = table.Column<string>(type: "text", nullable: true),
                    TrainingType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("WorkHistories_pkey", x => x.Word_ID);
                    table.ForeignKey(
                        name: "FK_WorkHistories.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Faculty - StudyBlock",
                schema: "ISC_Project",
                columns: table => new
                {
                    Faculty_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FacultyName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    FacultyCode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    School_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Faculty - StudyBlock_pkey", x => x.Faculty_ID);
                    table.ForeignKey(
                        name: "FK_Faculty - StudyBlock.School_ID",
                        column: x => x.School_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "SchoolProfile",
                        principalColumn: "School_ID");
                    table.ForeignKey(
                        name: "FK_Faculty - StudyBlock.SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "School Year",
                        principalColumn: "SchoolYear_ID");
                    table.ForeignKey(
                        name: "FK_Faculty - StudyBlock.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Semester",
                schema: "ISC_Project",
                columns: table => new
                {
                    Semester_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SemesterName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    LessonOfSemester = table.Column<int>(type: "integer", nullable: true),
                    StarTimeSemester = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndTimeSemester = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Is_Current = table.Column<bool>(type: "boolean", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semester", x => x.Semester_ID);
                    table.ForeignKey(
                        name: "FK_Semester.SchoolYear_ID",
                        column: x => x.SchoolYear_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "School Year",
                        principalColumn: "SchoolYear_ID");
                });

            migrationBuilder.CreateTable(
                name: "CourseLessons",
                schema: "ISC_Project",
                columns: table => new
                {
                    CourseLessons_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    LessonTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    RoomNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CourseOfferings_ID = table.Column<int>(type: "integer", nullable: true),
                    School_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CourseLessons_pkey", x => x.CourseLessons_ID);
                    table.ForeignKey(
                        name: "FK_CourseLessons.CourseOfferings_ID",
                        column: x => x.CourseOfferings_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "CourseOfferings",
                        principalColumn: "CourseOfferings_ID");
                    table.ForeignKey(
                        name: "FK_CourseLessons.School_ID",
                        column: x => x.School_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "SchoolProfile",
                        principalColumn: "School_ID");
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                schema: "ISC_Project",
                columns: table => new
                {
                    Registrations_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Registration_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CourserName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Campus = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    StudentName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    BirdDay = table.Column<DateOnly>(type: "date", nullable: true),
                    Sex = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Nationality = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Educationlevel = table.Column<string>(name: "Education level", type: "character varying(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Payment_status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Registrations_Image_Url = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Student_user_ID = table.Column<int>(type: "integer", nullable: true),
                    CourseOfferings_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Registrations_pkey", x => x.Registrations_ID);
                    table.ForeignKey(
                        name: "FK_Registrations.CourseOfferings_ID",
                        column: x => x.CourseOfferings_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "CourseOfferings",
                        principalColumn: "CourseOfferings_ID");
                    table.ForeignKey(
                        name: "FK_Registrations.Student_user_ID",
                        column: x => x.Student_user_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Class",
                schema: "ISC_Project",
                columns: table => new
                {
                    Class_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClassName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ClassCode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ClassPassword = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    StudentNumber = table.Column<int>(type: "integer", nullable: true),
                    Classification = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    FileClassURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Numberofsessions = table.Column<int>(name: "Number of sessions", type: "integer", nullable: true),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    StarTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ClassURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Join_code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Join_password = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    Department_ID = table.Column<int>(type: "integer", nullable: true),
                    ClassType_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Class_ID);
                    table.ForeignKey(
                        name: "FK_Class.ClassType_ID",
                        column: x => x.ClassType_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "ClassType",
                        principalColumn: "ClassType_ID");
                    table.ForeignKey(
                        name: "FK_Class.Department_ID",
                        column: x => x.Department_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Team-Department",
                        principalColumn: "Department_ID");
                    table.ForeignKey(
                        name: "FK_Class.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                schema: "ISC_Project",
                columns: table => new
                {
                    Subjects_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SubjectCode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    SubjectsName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    StarTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    SubjectType_ID = table.Column<int>(type: "integer", nullable: true),
                    Department_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Subjects_pkey", x => x.Subjects_ID);
                    table.ForeignKey(
                        name: "FK_Subjects.Department_ID",
                        column: x => x.Department_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Team-Department",
                        principalColumn: "Department_ID");
                    table.ForeignKey(
                        name: "FK_Subjects.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "CoursesLearned",
                schema: "ISC_Project",
                columns: table => new
                {
                    CoursesLearned_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Syllabus = table.Column<string>(type: "text", nullable: true),
                    Default_price = table.Column<decimal>(type: "numeric(12,2)", precision: 12, scale: 2, nullable: true),
                    Courses_image_url = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    TotalCourses_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesLearned", x => x.CoursesLearned_ID);
                    table.ForeignKey(
                        name: "FK_CoursesLearned.TotalCourses_ID",
                        column: x => x.TotalCourses_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "TotalCoursesTaken",
                        principalColumn: "TotalCourses_ID");
                });

            migrationBuilder.CreateTable(
                name: "RelativesInformation",
                schema: "ISC_Project",
                columns: table => new
                {
                    RelativesInformation_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RelativesName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Registrations_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelativesInformation", x => x.RelativesInformation_ID);
                    table.ForeignKey(
                        name: "FK_RelativesInformation.Registrations_ID",
                        column: x => x.Registrations_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Registrations",
                        principalColumn: "Registrations_ID");
                });

            migrationBuilder.CreateTable(
                name: "Class_Detail",
                schema: "ISC_Project",
                columns: table => new
                {
                    Detail_Class_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Admissiondate = table.Column<DateTime>(name: "Admission date", type: "timestamp without time zone", nullable: true),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    NumberOfSubjects = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Student_ID = table.Column<int>(type: "integer", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true),
                    Department_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Class_Detail_pkey", x => x.Detail_Class_ID);
                    table.ForeignKey(
                        name: "FK_Class_Detail.Class_ID",
                        column: x => x.Class_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Class",
                        principalColumn: "Class_ID");
                    table.ForeignKey(
                        name: "FK_Class_Detail.Department_ID",
                        column: x => x.Department_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Team-Department",
                        principalColumn: "Department_ID");
                    table.ForeignKey(
                        name: "FK_Class_Detail.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "ClassHistory",
                schema: "ISC_Project",
                columns: table => new
                {
                    History_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Decription = table.Column<string>(type: "text", nullable: true),
                    TotalSessisons = table.Column<int>(type: "integer", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true),
                    Subject_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ClassHistory_pkey", x => x.History_ID);
                    table.ForeignKey(
                        name: "FK_ClassHistory.Class_ID",
                        column: x => x.Class_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Class",
                        principalColumn: "Class_ID");
                });

            migrationBuilder.CreateTable(
                name: "ClassroomSettings",
                schema: "ISC_Project",
                columns: table => new
                {
                    ClassroomSettings_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ClassroomSettings_pkey", x => x.ClassroomSettings_ID);
                    table.ForeignKey(
                        name: "FK_ClassroomSettings.Class_ID",
                        column: x => x.Class_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Class",
                        principalColumn: "Class_ID");
                });

            migrationBuilder.CreateTable(
                name: "ClassSessions",
                schema: "ISC_Project",
                columns: table => new
                {
                    Session_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Topic = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Duration_hours = table.Column<int>(type: "integer", nullable: true),
                    Duration_minutes = table.Column<int>(type: "integer", nullable: true),
                    StartTIMESTAMP = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndTIMESTAMP = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsPrivate = table.Column<bool>(type: "boolean", nullable: true),
                    AutoStart = table.Column<bool>(type: "boolean", nullable: true),
                    EnableRecording = table.Column<bool>(type: "boolean", nullable: true),
                    AllowSharing = table.Column<bool>(type: "boolean", nullable: true),
                    ShareLink = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ClassSessions_pkey", x => x.Session_ID);
                    table.ForeignKey(
                        name: "FK_ClassSessions.Class_ID",
                        column: x => x.Class_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Class",
                        principalColumn: "Class_ID");
                    table.ForeignKey(
                        name: "FK_ClassSessions.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Discipline",
                schema: "ISC_Project",
                columns: table => new
                {
                    Discipline_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DisciplineDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: true),
                    DisciplineRewardURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Decisionday = table.Column<DateTime>(name: "Decision day", type: "timestamp without time zone", nullable: true),
                    FileURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discipline", x => x.Discipline_ID);
                    table.ForeignKey(
                        name: "FK_Discipline.Class_ID",
                        column: x => x.Class_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Class",
                        principalColumn: "Class_ID");
                    table.ForeignKey(
                        name: "FK_Discipline.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Exemptions",
                schema: "ISC_Project",
                columns: table => new
                {
                    Exemptions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExemptionObjects = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    FormExemption = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Exemptions_pkey", x => x.Exemptions_ID);
                    table.ForeignKey(
                        name: "FK_Exemptions.Class_ID",
                        column: x => x.Class_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Class",
                        principalColumn: "Class_ID");
                    table.ForeignKey(
                        name: "FK_Exemptions.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "LabSchedules",
                schema: "ISC_Project",
                columns: table => new
                {
                    LabSchedules_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Term_number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Lab_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Lab_start_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Lab_end_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Duration_minutes = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Subject_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LabSchedules_pkey", x => x.LabSchedules_ID);
                    table.ForeignKey(
                        name: "FK_LabSchedules.Subject_ID",
                        column: x => x.Subject_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Subjects",
                        principalColumn: "Subjects_ID");
                    table.ForeignKey(
                        name: "FK_LabSchedules.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "PastClasses",
                schema: "ISC_Project",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    Subject_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PastClasses_pkey", x => x.ClassID);
                    table.ForeignKey(
                        name: "FK_PastClasses.Subject_ID",
                        column: x => x.Subject_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Subjects",
                        principalColumn: "Subjects_ID");
                    table.ForeignKey(
                        name: "FK_PastClasses.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Score",
                schema: "ISC_Project",
                columns: table => new
                {
                    Score_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScoreType = table.Column<string>(type: "text", nullable: true),
                    Coefficient = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ScoreNumber = table.Column<int>(type: "integer", nullable: true),
                    AverageScore = table.Column<int>(type: "integer", nullable: true),
                    Semester = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Subjects_ID = table.Column<int>(type: "integer", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.Score_ID);
                    table.ForeignKey(
                        name: "FK_Score.Subjects_ID",
                        column: x => x.Subjects_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Subjects",
                        principalColumn: "Subjects_ID");
                });

            migrationBuilder.CreateTable(
                name: "Subjects_Class",
                schema: "ISC_Project",
                columns: table => new
                {
                    Subjects_ID = table.Column<int>(type: "integer", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Subjects_Class.Class_ID",
                        column: x => x.Class_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Class",
                        principalColumn: "Class_ID");
                    table.ForeignKey(
                        name: "FK_Subjects_Class.Subjects_ID",
                        column: x => x.Subjects_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Subjects",
                        principalColumn: "Subjects_ID");
                });

            migrationBuilder.CreateTable(
                name: "TeacherProfile",
                schema: "ISC_Project",
                columns: table => new
                {
                    Teacher_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TeacherName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    TeacherCode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Position = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Member = table.Column<bool>(type: "boolean", nullable: true),
                    Partymember = table.Column<bool>(name: "Party member", type: "boolean", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Nation = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Religion = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Admissiondate = table.Column<DateTime>(name: "Admission date", type: "timestamp without time zone", nullable: true),
                    Form = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    NumberRewards = table.Column<int>(type: "integer", nullable: true),
                    NumberDisciplinaryActions = table.Column<int>(type: "integer", nullable: true),
                    FileURL = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Subject_ID = table.Column<int>(type: "integer", nullable: true),
                    Department_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TeacherProfile_pkey", x => x.Teacher_ID);
                    table.ForeignKey(
                        name: "FK_TeacherProfile.Class_ID",
                        column: x => x.Class_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Class",
                        principalColumn: "Class_ID");
                    table.ForeignKey(
                        name: "FK_TeacherProfile.Department_ID",
                        column: x => x.Department_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Team-Department",
                        principalColumn: "Department_ID");
                    table.ForeignKey(
                        name: "FK_TeacherProfile.Subject_ID",
                        column: x => x.Subject_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Subjects",
                        principalColumn: "Subjects_ID");
                    table.ForeignKey(
                        name: "FK_TeacherProfile.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Teaching_Assessment",
                schema: "ISC_Project",
                columns: table => new
                {
                    Teaching_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AssignmentType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Semester = table.Column<int>(type: "integer", nullable: true),
                    StarTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true),
                    Subject_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Teaching_Assessment_pkey", x => x.Teaching_ID);
                    table.ForeignKey(
                        name: "FK_Teaching_Assessment.Class_ID",
                        column: x => x.Class_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Class",
                        principalColumn: "Class_ID");
                    table.ForeignKey(
                        name: "FK_Teaching_Assessment.Subject_ID",
                        column: x => x.Subject_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Subjects",
                        principalColumn: "Subjects_ID");
                    table.ForeignKey(
                        name: "FK_Teaching_Assessment.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "UpcomingClass",
                schema: "ISC_Project",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Subject_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UpcomingClass_pkey", x => x.ClassID);
                    table.ForeignKey(
                        name: "FK_UpcomingClass.Subject_ID",
                        column: x => x.Subject_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Subjects",
                        principalColumn: "Subjects_ID");
                    table.ForeignKey(
                        name: "FK_UpcomingClass.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "ClassHistorySession",
                schema: "ISC_Project",
                columns: table => new
                {
                    SessisonHistory_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SessisonTotal = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    StarTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    History_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ClassHistorySession_pkey", x => x.SessisonHistory_ID);
                    table.ForeignKey(
                        name: "FK_ClassHistorySession.History_ID",
                        column: x => x.History_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "ClassHistory",
                        principalColumn: "History_ID");
                });

            migrationBuilder.CreateTable(
                name: "LabGraders",
                schema: "ISC_Project",
                columns: table => new
                {
                    LabSchedules_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_LabGraders.LabSchedules_ID",
                        column: x => x.LabSchedules_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "LabSchedules",
                        principalColumn: "LabSchedules_ID");
                    table.ForeignKey(
                        name: "FK_LabGraders.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "LabScheduleClasses",
                schema: "ISC_Project",
                columns: table => new
                {
                    LabSchedules_ID = table.Column<int>(type: "integer", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_LabScheduleClasses.Class_ID",
                        column: x => x.Class_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Class",
                        principalColumn: "Class_ID");
                    table.ForeignKey(
                        name: "FK_LabScheduleClasses.LabSchedules_ID",
                        column: x => x.LabSchedules_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "LabSchedules",
                        principalColumn: "LabSchedules_ID");
                });

            migrationBuilder.CreateTable(
                name: "LearningOutcomes",
                schema: "ISC_Project",
                columns: table => new
                {
                    LearningOutcomes = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Conduct = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Averagescore = table.Column<int>(name: "Average score", type: "integer", nullable: true),
                    AcademicPerformance = table.Column<bool>(type: "boolean", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Score_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LearningOutcomes_pkey", x => x.LearningOutcomes);
                    table.ForeignKey(
                        name: "FK_LearningOutcomes.Score_ID",
                        column: x => x.Score_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Score",
                        principalColumn: "Score_ID");
                    table.ForeignKey(
                        name: "FK_LearningOutcomes.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                schema: "ISC_Project",
                columns: table => new
                {
                    Assignment_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Format = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Assignment_scope = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Category = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    StarTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Assignment_Url = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    PartitionType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CraeteAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Teaching_ID = table.Column<int>(type: "integer", nullable: true),
                    Faculty_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Assignment_ID);
                    table.ForeignKey(
                        name: "FK_Assignments.Teaching_ID",
                        column: x => x.Teaching_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Teaching_Assessment",
                        principalColumn: "Teaching_ID");
                });

            migrationBuilder.CreateTable(
                name: "DiscussionThreads",
                schema: "ISC_Project",
                columns: table => new
                {
                    Discussion_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Visibility = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Is_resolved = table.Column<bool>(type: "boolean", nullable: true),
                    View_count = table.Column<int>(type: "integer", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    Teaching_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DiscussionThreads_pkey", x => x.Discussion_ID);
                    table.ForeignKey(
                        name: "FK_DiscussionThreads.Teaching_ID",
                        column: x => x.Teaching_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Teaching_Assessment",
                        principalColumn: "Teaching_ID");
                    table.ForeignKey(
                        name: "FK_DiscussionThreads.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "LiveSessions",
                schema: "ISC_Project",
                columns: table => new
                {
                    LiveSessions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Scheduled_start_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Actual_start_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Actual_end_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Recording_url = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Teaching_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LiveSessions_pkey", x => x.LiveSessions_ID);
                    table.ForeignKey(
                        name: "FK_LiveSessions.Teaching_ID",
                        column: x => x.Teaching_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Teaching_Assessment",
                        principalColumn: "Teaching_ID");
                });

            migrationBuilder.CreateTable(
                name: "AssessmentParts",
                schema: "ISC_Project",
                columns: table => new
                {
                    AssessmentParts_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Part_order = table.Column<int>(type: "integer", nullable: true),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Assignment_url = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    StarTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Assignment_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("AssessmentParts_pkey", x => x.AssessmentParts_ID);
                    table.ForeignKey(
                        name: "FK_AssessmentParts.Assignment_ID",
                        column: x => x.Assignment_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Assignments",
                        principalColumn: "Assignment_ID");
                });

            migrationBuilder.CreateTable(
                name: "Assignment_Group",
                schema: "ISC_Project",
                columns: table => new
                {
                    Assignments_ID = table.Column<int>(type: "integer", nullable: true),
                    Class_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Assignment_Group.Assignments_ID",
                        column: x => x.Assignments_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Assignments",
                        principalColumn: "Assignment_ID");
                    table.ForeignKey(
                        name: "FK_Assignment_Group.Class_ID",
                        column: x => x.Class_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Class",
                        principalColumn: "Class_ID");
                });

            migrationBuilder.CreateTable(
                name: "ThreadPosts",
                schema: "ISC_Project",
                columns: table => new
                {
                    ThreadPosts_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    Created_at = table.Column<DateOnly>(type: "date", nullable: true),
                    Attachment_url = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Discussion_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ThreadPosts_pkey", x => x.ThreadPosts_ID);
                    table.ForeignKey(
                        name: "FK_ThreadPosts.Discussion_ID",
                        column: x => x.Discussion_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "DiscussionThreads",
                        principalColumn: "Discussion_ID");
                    table.ForeignKey(
                        name: "FK_ThreadPosts.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "LiveChatMessages",
                schema: "ISC_Project",
                columns: table => new
                {
                    LiveChatMessages_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MessageType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Message_content = table.Column<string>(type: "text", nullable: true),
                    SentAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Recording_url = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    IsPinned = table.Column<bool>(type: "boolean", nullable: true),
                    LiveSessions_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LiveChatMessages_pkey", x => x.LiveChatMessages_ID);
                    table.ForeignKey(
                        name: "FK_LiveChatMessages.LiveSessions_ID",
                        column: x => x.LiveSessions_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "LiveSessions",
                        principalColumn: "LiveSessions_ID");
                });

            migrationBuilder.CreateTable(
                name: "Student_Submissions",
                schema: "ISC_Project",
                columns: table => new
                {
                    Submissions_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Submission_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    File_url = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    Text_answer = table.Column<string>(type: "text", nullable: true),
                    AssessmentParts_ID = table.Column<int>(type: "integer", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true),
                    SchoolYear_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Student_Submissions_pkey", x => x.Submissions_ID);
                    table.ForeignKey(
                        name: "FK_Student_Submissions.AssessmentParts_ID",
                        column: x => x.AssessmentParts_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "AssessmentParts",
                        principalColumn: "AssessmentParts_ID");
                    table.ForeignKey(
                        name: "FK_Student_Submissions.User_ID",
                        column: x => x.User_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "StudentMCQAnswers",
                schema: "ISC_Project",
                columns: table => new
                {
                    StudentMCQAnswers_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Submissions_ID = table.Column<int>(type: "integer", nullable: true),
                    Questions_ID = table.Column<int>(type: "integer", nullable: true),
                    QuestionOptions_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("StudentMCQAnswers_pkey", x => x.StudentMCQAnswers_ID);
                    table.ForeignKey(
                        name: "FK_StudentMCQAnswers.QuestionOptions_ID",
                        column: x => x.QuestionOptions_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "QuestionOptions",
                        principalColumn: "QuestionOptions_ID");
                    table.ForeignKey(
                        name: "FK_StudentMCQAnswers.Questions_ID",
                        column: x => x.Questions_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Questions",
                        principalColumn: "Questions_ID");
                    table.ForeignKey(
                        name: "FK_StudentMCQAnswers.Submissions_ID",
                        column: x => x.Submissions_ID,
                        principalSchema: "ISC_Project",
                        principalTable: "Student_Submissions",
                        principalColumn: "Submissions_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcceptingSchoolTransfers_User_ID",
                schema: "ISC_Project",
                table: "AcceptingSchoolTransfers",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentParts_Assignment_ID",
                schema: "ISC_Project",
                table: "AssessmentParts",
                column: "Assignment_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentQuestions_Questions_ID",
                schema: "ISC_Project",
                table: "AssessmentQuestions",
                column: "Questions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_Group_Assignments_ID",
                schema: "ISC_Project",
                table: "Assignment_Group",
                column: "Assignments_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_Group_Class_ID",
                schema: "ISC_Project",
                table: "Assignment_Group",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_Teaching_ID",
                schema: "ISC_Project",
                table: "Assignments",
                column: "Teaching_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Campuses_School_ID",
                schema: "ISC_Project",
                table: "Campuses",
                column: "School_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_ClassType_ID",
                schema: "ISC_Project",
                table: "Class",
                column: "ClassType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Department_ID",
                schema: "ISC_Project",
                table: "Class",
                column: "Department_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_User_ID",
                schema: "ISC_Project",
                table: "Class",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Detail_Class_ID",
                schema: "ISC_Project",
                table: "Class_Detail",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Detail_Department_ID",
                schema: "ISC_Project",
                table: "Class_Detail",
                column: "Department_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Detail_User_ID",
                schema: "ISC_Project",
                table: "Class_Detail",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassHistory_Class_ID",
                schema: "ISC_Project",
                table: "ClassHistory",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassHistorySession_History_ID",
                schema: "ISC_Project",
                table: "ClassHistorySession",
                column: "History_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassroomSettings_Class_ID",
                schema: "ISC_Project",
                table: "ClassroomSettings",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSessions_Class_ID",
                schema: "ISC_Project",
                table: "ClassSessions",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSessions_User_ID",
                schema: "ISC_Project",
                table: "ClassSessions",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_CourseOfferings_ID",
                schema: "ISC_Project",
                table: "CourseLessons",
                column: "CourseOfferings_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_School_ID",
                schema: "ISC_Project",
                table: "CourseLessons",
                column: "School_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseOfferings_Courses_ID",
                schema: "ISC_Project",
                table: "CourseOfferings",
                column: "Courses_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseOfferings_Instructor_user_id",
                schema: "ISC_Project",
                table: "CourseOfferings",
                column: "Instructor_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseCategories_ID",
                schema: "ISC_Project",
                table: "Courses",
                column: "CourseCategories_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesLearned_TotalCourses_ID",
                schema: "ISC_Project",
                table: "CoursesLearned",
                column: "TotalCourses_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Discipline_Class_ID",
                schema: "ISC_Project",
                table: "Discipline",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Discipline_User_ID",
                schema: "ISC_Project",
                table: "Discipline",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionThreads_Teaching_ID",
                schema: "ISC_Project",
                table: "DiscussionThreads",
                column: "Teaching_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionThreads_User_ID",
                schema: "ISC_Project",
                table: "DiscussionThreads",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employment_History_User_ID",
                schema: "ISC_Project",
                table: "Employment_History",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Exemptions_Class_ID",
                schema: "ISC_Project",
                table: "Exemptions",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Exemptions_User_ID",
                schema: "ISC_Project",
                table: "Exemptions",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty - StudyBlock_School_ID",
                schema: "ISC_Project",
                table: "Faculty - StudyBlock",
                column: "School_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty - StudyBlock_SchoolYear_ID",
                schema: "ISC_Project",
                table: "Faculty - StudyBlock",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty - StudyBlock_User_ID",
                schema: "ISC_Project",
                table: "Faculty - StudyBlock",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyInformation_User_ID",
                schema: "ISC_Project",
                table: "FamilyInformation",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_Training_ID",
                schema: "ISC_Project",
                table: "Grades",
                column: "Training_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LabGraders_LabSchedules_ID",
                schema: "ISC_Project",
                table: "LabGraders",
                column: "LabSchedules_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LabGraders_User_ID",
                schema: "ISC_Project",
                table: "LabGraders",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LabScheduleClasses_Class_ID",
                schema: "ISC_Project",
                table: "LabScheduleClasses",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LabScheduleClasses_LabSchedules_ID",
                schema: "ISC_Project",
                table: "LabScheduleClasses",
                column: "LabSchedules_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LabSchedules_Subject_ID",
                schema: "ISC_Project",
                table: "LabSchedules",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LabSchedules_User_ID",
                schema: "ISC_Project",
                table: "LabSchedules",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LearningOutcomes_Score_ID",
                schema: "ISC_Project",
                table: "LearningOutcomes",
                column: "Score_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LearningOutcomes_User_ID",
                schema: "ISC_Project",
                table: "LearningOutcomes",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LiveChatMessages_LiveSessions_ID",
                schema: "ISC_Project",
                table: "LiveChatMessages",
                column: "LiveSessions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LiveSessions_Teaching_ID",
                schema: "ISC_Project",
                table: "LiveSessions",
                column: "Teaching_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_User_ID",
                schema: "ISC_Project",
                table: "Notification",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PastClasses_Subject_ID",
                schema: "ISC_Project",
                table: "PastClasses",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PastClasses_User_ID",
                schema: "ISC_Project",
                table: "PastClasses",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_User_ID",
                schema: "ISC_Project",
                table: "Qualifications",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_Questions_ID",
                schema: "ISC_Project",
                table: "QuestionOptions",
                column: "Questions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_CourseOfferings_ID",
                schema: "ISC_Project",
                table: "Registrations",
                column: "CourseOfferings_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_Student_user_ID",
                schema: "ISC_Project",
                table: "Registrations",
                column: "Student_user_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RelativesInformation_Registrations_ID",
                schema: "ISC_Project",
                table: "RelativesInformation",
                column: "Registrations_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Reserved_User_ID",
                schema: "ISC_Project",
                table: "Reserved",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Reward_User_ID",
                schema: "ISC_Project",
                table: "Reward",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_Permissions_ID",
                schema: "ISC_Project",
                table: "RolePermissions",
                column: "Permissions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_Role_ID",
                schema: "ISC_Project",
                table: "RolePermissions",
                column: "Role_ID");

            migrationBuilder.CreateIndex(
                name: "IX_School Year_School_ID",
                schema: "ISC_Project",
                table: "School Year",
                column: "School_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Score_Subjects_ID",
                schema: "ISC_Project",
                table: "Score",
                column: "Subjects_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Semester_SchoolYear_ID",
                schema: "ISC_Project",
                table: "Semester",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Grades_User_ID",
                schema: "ISC_Project",
                table: "Student_Grades",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Submissions_AssessmentParts_ID",
                schema: "ISC_Project",
                table: "Student_Submissions",
                column: "AssessmentParts_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Submissions_User_ID",
                schema: "ISC_Project",
                table: "Student_Submissions",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMCQAnswers_QuestionOptions_ID",
                schema: "ISC_Project",
                table: "StudentMCQAnswers",
                column: "QuestionOptions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMCQAnswers_Questions_ID",
                schema: "ISC_Project",
                table: "StudentMCQAnswers",
                column: "Questions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMCQAnswers_Submissions_ID",
                schema: "ISC_Project",
                table: "StudentMCQAnswers",
                column: "Submissions_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsChangeClasses_User_ID",
                schema: "ISC_Project",
                table: "StudentsChangeClasses",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Department_ID",
                schema: "ISC_Project",
                table: "Subjects",
                column: "Department_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_User_ID",
                schema: "ISC_Project",
                table: "Subjects",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Class_Class_ID",
                schema: "ISC_Project",
                table: "Subjects_Class",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Class_Subjects_ID",
                schema: "ISC_Project",
                table: "Subjects_Class",
                column: "Subjects_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherProfile_Class_ID",
                schema: "ISC_Project",
                table: "TeacherProfile",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherProfile_Department_ID",
                schema: "ISC_Project",
                table: "TeacherProfile",
                column: "Department_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherProfile_Subject_ID",
                schema: "ISC_Project",
                table: "TeacherProfile",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherProfile_User_ID",
                schema: "ISC_Project",
                table: "TeacherProfile",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teaching_Assessment_Class_ID",
                schema: "ISC_Project",
                table: "Teaching_Assessment",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teaching_Assessment_Subject_ID",
                schema: "ISC_Project",
                table: "Teaching_Assessment",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teaching_Assessment_User_ID",
                schema: "ISC_Project",
                table: "Teaching_Assessment",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Team-Department_School_ID",
                schema: "ISC_Project",
                table: "Team-Department",
                column: "School_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Team-Department_SchoolYear_ID",
                schema: "ISC_Project",
                table: "Team-Department",
                column: "SchoolYear_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ThreadPosts_Discussion_ID",
                schema: "ISC_Project",
                table: "ThreadPosts",
                column: "Discussion_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ThreadPosts_User_ID",
                schema: "ISC_Project",
                table: "ThreadPosts",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TotalCoursesTaken_User_ID",
                schema: "ISC_Project",
                table: "TotalCoursesTaken",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_UpcomingClass_Subject_ID",
                schema: "ISC_Project",
                table: "UpcomingClass",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_UpcomingClass_User_ID",
                schema: "ISC_Project",
                table: "UpcomingClass",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_Role_ID",
                schema: "ISC_Project",
                table: "User",
                column: "Role_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistories_User_ID",
                schema: "ISC_Project",
                table: "WorkHistories",
                column: "User_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcceptingSchoolTransfers",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "AssessmentQuestions",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Assignment_Group",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Campuses",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Class_Detail",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "ClassHistorySession",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "ClassroomSettings",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "ClassSessions",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "CourseLessons",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "CoursesLearned",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Discipline",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Employment_History",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Enrollments",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Exemptions",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Faculty - StudyBlock",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "FamilyInformation",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Grades",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "LabGraders",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "LabScheduleClasses",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "LearningOutcomes",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "LiveChatMessages",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Notification",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "PastClasses",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Qualifications",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "RelativesInformation",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Reserved",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Reward",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "RolePermissions",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Semester",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Student_Grades",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "StudentMCQAnswers",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "StudentsChangeClasses",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "StudentsChangeSchool",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "StudentsProfile",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Subjects_Class",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "SubjectType",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Syllabus_topics",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "SystemSettings",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "TeacherProfile",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "ThreadPosts",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "UpcomingClass",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "WorkHistories",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "ClassHistory",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "TotalCoursesTaken",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "TrainingLevels",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "LabSchedules",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Score",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "LiveSessions",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Registrations",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Permissions",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "School Year",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "QuestionOptions",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Student_Submissions",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "DiscussionThreads",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "CourseOfferings",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Questions",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "AssessmentParts",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Courses",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Assignments",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "CourseCategories",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Teaching_Assessment",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Class",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Subjects",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "ClassType",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Team-Department",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "SchoolProfile",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "User",
                schema: "ISC_Project");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "ISC_Project");
        }
    }
}
