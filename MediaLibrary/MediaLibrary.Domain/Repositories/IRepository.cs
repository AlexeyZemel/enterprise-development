namespace MediaLibrary.Domain.Repositories;

public interface IRepository<T>
{
    public IEnumerable<T> GetAll();
    public T? GetById(int id);
    public void Post(T entity);
    public bool Put(int id, T entity);
    public bool Delete(int id);
}
