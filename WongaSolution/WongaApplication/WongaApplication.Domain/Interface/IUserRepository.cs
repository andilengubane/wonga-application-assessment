using WongaApplication.Domain.Entities;

namespace WongaApplication.Domain.Interface
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserEntitiy>> GetAllUserAsync();
        Task<UserEntitiy> GetUserByIdAsync(Guid Id);
        Task<UserEntitiy> AddUserAsync(UserEntitiy user);
    }
}
