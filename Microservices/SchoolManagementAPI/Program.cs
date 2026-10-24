using SchoolManagementAPI.Abstract;
using SchoolManagementAPI.Repo;
using SchoolManagementAPI.BusinessAccessLayer;

var builder = WebApplication.CreateBuilder(args);

// 1. Essential: Register Controller services
builder.Services.AddControllers();

// 2. Register Swagger / OpenAPI generation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 3. Dependency Injection
builder.Services.AddScoped<IStudent, StudentRepo>();
builder.Services.AddScoped<StudentBAL>();

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