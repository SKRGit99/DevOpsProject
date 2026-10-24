using SchoolManagementAPI.Abstract;
using SchoolManagementAPI.Repo;
using SchoolManagementAPI.BusinessAccessLayer;
using SchoolManagementAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. Essential: Register Controller services
builder.Services.AddControllers();

// 2. Register Swagger / OpenAPI generation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 3. Dependency Injection
builder.Services.AddScoped<IStudent, StudentRepo>();
builder.Services.AddScoped<StudentBAL>();

builder.Services.AddScoped<ICentralStudent, CentralRepo>();

// Register Repository
builder.Services.AddScoped<ICentralStudent, CentralRepo>();

// Register Typed HttpClient with BaseUrl pointing to the other container
builder.Services.AddHttpClient<IStudentSyncService, StudentSyncService>(client =>
{
    var baseUrl = builder.Configuration["StudentApiSettings:BaseUrl"] ?? "http://StudentManagementAPI:8080";
    client.BaseAddress = new Uri(baseUrl);
    client.Timeout = TimeSpan.FromSeconds(30);
});

var app = builder.Build();

// 4. Configure HTTP Request Pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Student API v1");
        c.RoutePrefix = "swagger"; // Available at http://localhost:<port>/swagger
    });
}

// Comment out HttpsRedirection if you plan to test in Docker over HTTP (port 8080)
// app.UseHttpsRedirection();

app.UseAuthorization();

// 5. Essential: Map API Attribute Routes
app.MapControllers();

app.Run();