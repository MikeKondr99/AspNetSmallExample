using System.Dynamic;
using Microsoft.EntityFrameworkCore;
using WebStudents.Database;
using WebStudents.Models;
using WebStudents.Repositories;

namespace WebStudents.Services;

public class StudentsDbTable : IStudentsRepository
{
    private readonly DatabaseContext _context;
    
    public StudentsDbTable(DatabaseContext context)
    {
        _context = context;
    }
    
    public IEnumerable<Student> GetAll()
    {
        return _context.Students.ToList();
    }

    public Student GetById(int id)
    {
        return _context.Students.Find(id) ?? throw new NotImplementedException();
    }

    public Student Remove(int id)
    {
        var found = GetById(id);
        _context.Students.Remove(found);
        _context.SaveChanges();
        return found;
    }

    public Student Add(Student data)
    {
        _context.Students.Add(data);
        _context.SaveChanges();
        return GetById(data.Id);
    }

    public Student Update(Student data)
    {
        _context.Students.Update(data);
        _context.SaveChanges();
        return GetById(data.Id);
    }
}