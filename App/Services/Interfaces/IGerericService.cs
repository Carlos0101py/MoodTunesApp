namespace MoodTunesApp.App.Services.Interfaces
{
    public interface IGerericService<T>
    {
        Task Add(T entity);
        T Update(T entity);
        T Delete(string id);
        T GetById(string id);
        Task<IEnumerable<T>> GetAll();
    }
}