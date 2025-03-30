using Microsoft.EntityFrameworkCore;
using MoodTunesApp.App.DataBase;
using MoodTunesApp.App.Models;
using MoodTunesApp.App.Services.Interfaces;

namespace MoodTunesApp.App.Repositories
{
    public class UserRepository : IGerericService<User>
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Add(User user)
        {
            _appDbContext.User.Add(user);
            await _appDbContext.SaveChangesAsync();
        }

        public User Delete(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _appDbContext.User.ToListAsync();
        }

        public User GetById(string id)
        {
            throw new NotImplementedException();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}