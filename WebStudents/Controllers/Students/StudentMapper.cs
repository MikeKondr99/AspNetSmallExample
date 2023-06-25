using Riok.Mapperly.Abstractions;
using WebStudents.Models;

namespace WebStudents.Controllers;

[Mapper]
public partial class StudentMapper
{
    public partial Student FromUpdate(StudentUpdateDto data);
    
    public partial Student FromCreate(StudentCreateDto data);
}