namespace MoodTunesApp.App.Repositories.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(string id);
        T GetById(string id);
        Task<IEnumerable<T>> GetAll();
    }
}