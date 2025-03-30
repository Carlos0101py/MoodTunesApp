using MoodTunesApp.App.DataBase;
using MoodTunesApp.App.Models;
using MoodTunesApp.App.Repositories.Interfaces;
using MoodTunesApp.App.Services.Interfaces;

namespace MoodTunesApp.App.Repositories
{
    public class LibraryRepository : IGenericRepository<Library>
    {
        private readonly AppDbContext _appDbContext;

        public LibraryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Add(Library library)
        {
            _appDbContext.Library.Add(library);
            await _appDbContext.SaveChangesAsync();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Library>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Library GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Library entity)
        {
            throw new NotImplementedException();
        }
    }
}