using WebStudents.Models;
using WebStudents.Services;

namespace WebStudents.Repositories;

public interface IStudentsRepository : IRepository<Student,int> { }