using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using WebStudents.Models;

namespace WebStudents.Database;

public class DatabaseContext : DbContext
{
    
    // Версия до C# 11
    // public DbSet<Student> Students => Set<Student>();
    // Альтернатива после C# 11
    public required DbSet<Student> Students { get; init; }
    
    public DatabaseContext()
    {
        Database.EnsureCreated();
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    
}