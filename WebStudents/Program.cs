using Microsoft.EntityFrameworkCore;
using WebStudents;
using WebStudents.Controllers;
using WebStudents.Database;
using WebStudents.Repositories;
using WebStudents.Services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddCors();

services.AddControllers(cfg =>
{
    cfg.Filters.Add<ExceptionFilter>();
});


services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlite("Data Source=./db.sqlite");
});

services.AddScoped<IStudentsRepository, StudentsDbTable>();

services.AddScoped<StudentMapper>();

var app = builder.Build();

app.MapControllers();

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.Run();