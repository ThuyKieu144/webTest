using Infrastructure.Mapper;
using Microsoft.EntityFrameworkCore;
using ttxaphuong.Data;
using ttxaphuong.Interfaces;
using ttxaphuong.Services;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using WebDoAn2.Exceptions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),

            RoleClaimType = ClaimTypes.Role, // ✅ Sửa thành ClaimTypes.Role
            NameClaimType = ClaimTypes.Name
        };

    });

//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("Admin", policy => policy.RequireRole("Admin"));
//    options.AddPolicy("Manager", policy => policy.RequireRole("Manager"));
//});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 2))));

//Đoạn Services cho chức năng Logic hoạt động
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddScoped<ICategoriesService, CategoriesService>();
builder.Services.AddScoped<INews_eventsService, News_eventsService>();

builder.Services.AddScoped<ICategory_documentsService, Category_documentsService>();
builder.Services.AddScoped<IDocumentsService, DocumentsService>();

builder.Services.AddScoped<ICategories_introduceService, Categories_introduceService>();
builder.Services.AddScoped<IIntroduceService, IntroduceService>();

builder.Services.AddScoped<ICategory_fieldService, CategoryFieldService>();
builder.Services.AddScoped<IProceduresService, ProceduresService>();

builder.Services.AddScoped<IFeedbacksService, FeedbacksService>();

builder.Services.AddScoped<IUploadFileService, UploadFileService>();
builder.Services.AddScoped<IFolderService, FolderService>();

builder.Services.AddScoped<IUploadFilePdfService, UploadFilePdfService>();
builder.Services.AddScoped<IFolderPdfService, FolderPdfService>();

builder.Services.AddScoped<IStatisticsService, StatisticsService>();

builder.Services.AddScoped<IWebsiteSettingsService, WebsiteSettingsService>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp",
        policy =>
        {
            policy.WithOrigins("https://localhost:4200") // Địa chỉ của ứng dụng 
           // policy.WithOrigins("https://congtt123.id.vn") // Địa chỉ của ứng dụng 
                  .AllowAnyHeader()
                  .AllowAnyMethod();
                  //.AllowCredentials(); // ✅ Cho phép gửi Authorization header
        });
});

builder.WebHost.ConfigureKestrel(options =>
{
    options.ConfigureHttpsDefaults(opts => {
        // Tắt HTTPS bắt buộc nếu không có chứng chỉ
        opts.ServerCertificate = null;
    });
});

var app = builder.Build();

// 🛠 Tạo thư mục nếu chưa có
var uploadsPath = Path.Combine(builder.Environment.ContentRootPath, "Uploads");
var pdfPath = Path.Combine(builder.Environment.ContentRootPath, "Pdf");

if (!Directory.Exists(uploadsPath))
{
    Directory.CreateDirectory(uploadsPath);
}

if (!Directory.Exists(pdfPath))
{
    Directory.CreateDirectory(pdfPath);
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(uploadsPath),
    RequestPath = "/api/images"
});

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(pdfPath),
    RequestPath = "/api/pdf"
});

app.UseCors("AllowAngularApp");

app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthentication();  // Đảm bảo đã gọi middleware xác thực

app.UseAuthorization();  // Đảm bảo đã gọi middleware phân quyền

app.MapControllers();

app.Run();
