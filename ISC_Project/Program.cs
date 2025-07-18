using ISC_Project.Data;
using ISC_Project.Infrastructure.Services;
using ISC_Project.Interface;
using ISC_Project.Interface.AuthService;
using ISC_Project.Interface.Exam;
using ISC_Project.Services;
using ISC_Project.Services.AuthService;
using ISC_Project.Services.Exam;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        // Thêm dòng này vào ngay đầu file Program.cs
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        var builder = WebApplication.CreateBuilder(args);
        var configuration = builder.Configuration;

        // == ĐĂNG KÝ SERVICE VÀ INTERFACE ==
        builder.Services.AddScoped<IAuthService, AuthService>();
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<IJwtService, JwtService>();

        // Đăng ký các services vào IoC container
        builder.Services.AddScoped<IUserManagementService, UserManagementService>();
        builder.Services.AddScoped<IRewardDisciplineService, RewardDisciplineService>();
        builder.Services.AddScoped<IQuestionBankService, QuestionBankService>();
        builder.Services.AddScoped<IExemptionService, ExemptionService>();

        builder.Services.AddScoped<IRoleService, RoleService>();
        builder.Services.AddScoped<IStudentProfileService, StudentProfileService>();
        builder.Services.AddScoped<ISchoolProfileService, SchoolProfileService>();
        builder.Services.AddScoped<ITeamDepartmentService, TeamDepartmentService>();
        builder.Services.AddScoped<IClassTypeService, ClassTypeService>();
        builder.Services.AddScoped<IClassService, ClassService>();
        builder.Services.AddScoped<IClassSubjectService, ClassSubjectService>();
        builder.Services.AddScoped<IClassHistoryService, ClassHistoryService>();
        builder.Services.AddScoped<ISubjectService, SubjectService>();

        builder.Services.AddScoped<IExamService, ExamService>();

        builder.Services.AddScoped<ITeacherProfileService, TeacherProfileService>();
        builder.Services.AddScoped<ISchoolYearService, SchoolYearService>();
        builder.Services.AddScoped<ICourseCategoryService, CourseCategoryService>();
        builder.Services.AddScoped<ICourseService, CourseService>();
        builder.Services.AddScoped<ICourseOfferingService, CourseOfferingService>();
        builder.Services.AddScoped<ICourseLessonService, CourseLessonService>();
        builder.Services.AddScoped<IRegistrationService, RegistrationService>();

        builder.Services.AddScoped<IDiscussionThreadService, DiscussionThreadService>();
        builder.Services.AddScoped<IThreadPostService, ThreadPostService>();
        builder.Services.AddScoped<ILiveChatMessageService, LiveChatMessageService>();
        builder.Services.AddScoped<ILiveSessionService, LiveSessionService>();

        builder.Services.AddScoped<INotificationService, NotificationService>();


        // 1. Cấu hình DbContext để sử dụng PostgreSQL
        var connectionJwtString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<ISC_ProjectDbContext>(options =>
            options.UseNpgsql(connectionJwtString)); 

        //2.Cấu hình JWT Authentication(giữ nguyên như cũ)
        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]))
                };

                options.Events = new JwtBearerEvents
                {
                    OnChallenge = context =>
                    {
                        // Ghi đè lên phản hồi mặc định
                        context.HandleResponse(); // Bỏ qua xử lý mặc định

                        // Trả về mã lỗi 401
                        context.Response.StatusCode = 401;
                        context.Response.ContentType = "application/json";

                        // Tạo thông báo lỗi tùy chỉnh
                        var result = JsonSerializer.Serialize(new { message = "Vui lòng đăng nhập để thực hiện chức năng này." });
                        return context.Response.WriteAsync(result);
                    }
                };
            });
        //Thêm hỗ trợ cho Newtonsoft.Json để xử lý Enum dưới dạng string và các vòng lặp tham chiếu
        builder.Services.AddControllers().AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        });

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            // Cấu hình thông tin cơ bản cho Swagger
            options.SwaggerDoc("v1", new OpenApiInfo { Title = "My Project API", Version = "v1" });

            // 1. Định nghĩa Security Scheme (phương thức bảo mật)
            // Dòng này khai báo cho Swagger biết có một phương thức bảo mật tên là 'Bearer'
            // sử dụng JWT thông qua Header 'Authorization'.
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Vui lòng nhập Access Token với tiền tố 'Bearer ' vào ô bên dưới. Ví dụ: 'Bearer a1b2c3d4e5'",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "Bearer"
            });

            // 2. Thêm Security Requirement
            // Dòng này yêu cầu Swagger phải áp dụng Security Scheme đã định nghĩa ở trên
            // cho tất cả các API cần xác thực.
            options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[]{}
        }
    });
        });

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseStatusCodePages(async context =>
        {
            // Nếu mã lỗi là 403 Forbidden
            if (context.HttpContext.Response.StatusCode == 403)
            {
                context.HttpContext.Response.ContentType = "application/json";
                await context.HttpContext.Response.WriteAsJsonAsync(new { message = "Bạn không có quyền truy cập chức năng này." });
            }
        });
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}