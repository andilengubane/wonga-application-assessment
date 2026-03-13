using Microsoft.EntityFrameworkCore;
using WongaApplication.Domain.Entities;
using WongaApplication.Domain.Interface;
using WongaApplication.Infrastructure.Data;

namespace WongaApplication.Infrastructure.Repository
{
    public class UserRepository(WongaApplicationContext _wongaApplicationContext) : IUserRepository
    {
        public async Task<IEnumerable<User>> GetAllPurchaseAirtimeTokenAsync()
        {
            return await _wongaApplicationContext.User.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(Guid Id)
        {
            var purchaseAirtimeToken = await _wongaApplicationContext.User.FirstOrDefaultAsync(u => u.Id == Id);

            if (purchaseAirtimeToken == null)
                throw new KeyNotFoundException($"No user  registration found with Id: {Id}");

            return purchaseAirtimeToken;
        }

        public async Task<User> AddUserAsync(User user)
        {
            user.Id = Guid.NewGuid();
            _wongaApplicationContext.Add(user);
            await _wongaApplicationContext.SaveChangesAsync();
            return user;
        }
    }
}
