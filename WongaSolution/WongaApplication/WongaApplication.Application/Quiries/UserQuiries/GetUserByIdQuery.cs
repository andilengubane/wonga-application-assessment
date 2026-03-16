using MediatR;
using WongaApplication.Domain.Entities;
using WongaApplication.Domain.Interface;

namespace WongaApplication.Application.Quiries.UserQuiries
{
    public record GetUserByIdQuery(string password, string username) : IRequest<UserEntitiy>;
     
    public class GetUserByIdQueryHandler(IUserRepository _userRepository) : IRequestHandler<GetUserByIdQuery, UserEntitiy>
    {
        public async Task<UserEntitiy> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetUserByIdAsync(request.password, request.username);
        }
    }
}
