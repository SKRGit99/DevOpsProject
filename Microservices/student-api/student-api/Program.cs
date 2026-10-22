var builder = WebApplication.CreateBuilder(args);

// 1. Add services to the dependency injection container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Enables automatic OpenAPI/Swagger documentation

var app = builder.Build();

// 2. Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Interactive UI at /swagger
}

app.UseHttpsRedirection();

// 3. In-memory data store for testing
var students = new List<Student>
{
    new(1, "Sampat Kumar Rahul"),
    new(2, "Rahul Kumar"),
    new(3, "Kaushal Kumar")
};

// 4. Define REST Endpoints

// GET: /api/products (Retrieve all)
app.MapGet("/api/students", () => Results.Ok(students));

// GET: /api/students/{id} (Retrieve by ID)

app.MapGet("/api/students/{id:int}", (int id) =>
{
    var student = students.FirstOrDefault(p => p.Id == id);
    return student is not null ? Results.Ok(student) : Results.NotFound();
});

// POST: /api/students (Create new)
app.MapPost("/api/students", (CreateStudentDto dto) =>
{
    var newId = students.Any() ? students.Max(p => p.Id) + 1 : 1;
    var newStudent = new Student(newId, dto.Name);
    students.Add(newStudent);
    return Results.Created($"/api/students/{newId}", newStudent);
});

// DELETE: /api/students/{id} (Delete)
app.MapDelete("/api/students/{id:int}", (int id) =>
{
    var student = students.FirstOrDefault(p => p.Id == id);
    if (student is null) return Results.NotFound();
    students.Remove(student);
    return Results.NoContent();
});

app.Run();

// Data Models
record Student(int Id, string Name);
record CreateStudentDto(string Name);
