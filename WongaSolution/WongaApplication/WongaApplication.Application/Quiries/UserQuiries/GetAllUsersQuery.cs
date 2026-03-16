using MediatR;
using WongaApplication.Domain.Entities;
using WongaApplication.Domain.Interface;

namespace WongaApplication.Application.Quiries.UserQuiries
{
    public record GetAllUsersQuery: IRequest<IEnumerable<UserEntitiy>>;
    public class GetAllUsersQueryHandler(IUserRepository _userRepository) : IRequestHandler<GetAllUsersQuery, IEnumerable<UserEntitiy>>
    {
        public async Task<IEnumerable<UserEntitiy>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetAllUserAsync();
        }
    }
}