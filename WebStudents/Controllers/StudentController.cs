using Microsoft.AspNetCore.Mvc;
using WebStudents.Models;
using WebStudents.Repositories;

namespace WebStudents.Controllers;

[Route("/api/students")]
public class StudentController
{
    private readonly IStudentsRepository _repository;
    private readonly StudentMapper _mapper;

    public StudentController(IStudentsRepository repository,StudentMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet]
    public IEnumerable<Student> GetAll()
    {
        return _repository.GetAll();
    }
    
    [HttpGet("{id}")]
    public Student GetOne([FromRoute] int id)
    {
        return _repository.GetById(id);
    }
    
    [HttpDelete("{id}")]
    public Student Delete([FromRoute] int id)
    {
        return _repository.Remove(id);
    }
    
    [HttpPost]
    public Student Create([FromBody] StudentCreateDto data)
    {
        return _repository.Add(_mapper.FromCreate(data));
    }
    
    [HttpPut("{id}")]
    public Student Update([FromRoute] int id,[FromBody] StudentUpdateDto data)
    {
        return _repository.Add(_mapper.FromUpdate(data));
    }
}