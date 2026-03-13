using WongaApplication.Domain.Entities;

namespace WongaApplication.Domain.Interface
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllPurchaseAirtimeTokenAsync();
        Task<User> GetUserByIdAsync(Guid Id);
        Task<User> AddUserAsync(User user);
    }
}
