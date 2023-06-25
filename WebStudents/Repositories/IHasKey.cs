namespace WebStudents.Repositories;

public interface IHasKey<T>
{
    T Id { get; set; }
}