using WebStudents.Services;

namespace WebStudents.Repositories;

public interface IRepository<T, in TKey> where T : IHasKey<TKey>
{
    IEnumerable<T> GetAll();

    T GetById(TKey id);
    
    T Remove(TKey id);
    
    T Add(T data);
    
    T Update(T data);
}