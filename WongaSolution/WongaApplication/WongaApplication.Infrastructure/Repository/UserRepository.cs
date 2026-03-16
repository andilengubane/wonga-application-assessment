using Microsoft.EntityFrameworkCore;
using WongaApplication.Domain.Entities;
using WongaApplication.Domain.Interface;
using WongaApplication.Infrastructure.Data;

namespace WongaApplication.Infrastructure.Repository
{
    public class UserRepository(WongaApplicationContext _wongaApplicationContext) : IUserRepository
    {
        public async Task<IEnumerable<UserEntitiy>> GetAllUserAsync()
        {
            return await _wongaApplicationContext.User.ToListAsync();
        }

        public async Task<UserEntitiy> GetUserByIdAsync(string password, string usernae)
        {
            var userEntitiy = await _wongaApplicationContext.User.FirstOrDefaultAsync(u => u.Password == password && u.Username == usernae);

            if (userEntitiy == null)
                throw new KeyNotFoundException($"No user  registration found with Id: {usernae}");

            return userEntitiy;
        }

        public async Task<UserEntitiy> AddUserAsync(UserEntitiy user)
        {
            user.Id = Guid.NewGuid();
            _wongaApplicationContext.Add(user);
            await _wongaApplicationContext.SaveChangesAsync();
            return user;
        }
    }
}
