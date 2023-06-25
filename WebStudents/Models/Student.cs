using System.ComponentModel.DataAnnotations.Schema;
using WebStudents.Repositories;
using WebStudents.Services;

namespace WebStudents.Models;

public class Student : IHasKey<int>
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
}