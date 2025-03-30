using MoodTunesApp.App.DataBase;
using MoodTunesApp.App.Models;
using MoodTunesApp.App.Repositories.Interfaces;

namespace MoodTunesApp.App.Repositories
{
    public class MoodMaterRepository : IGenericRepository<MoodMater>
    {
        private readonly AppDbContext _appDbContext;

        public MoodMaterRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task Add(MoodMater moodMater)
        {
            _appDbContext.MoodMater.Add(moodMater);
            await _appDbContext.SaveChangesAsync();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MoodMater>> GetAll()
        {
            throw new NotImplementedException();
        }

        public MoodMater GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task Update(MoodMater entity)
        {
            throw new NotImplementedException();
        }
    }
}