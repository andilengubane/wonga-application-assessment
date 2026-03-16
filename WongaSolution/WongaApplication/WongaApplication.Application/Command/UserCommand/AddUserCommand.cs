using MediatR;
using WongaApplication.Domain.Entities;
using WongaApplication.Domain.Interface;

namespace WongaApplication.Application.Command.UserCommand
{
    public record AddUserCommand(UserEntitiy userEntitiy) : IRequest<UserEntitiy>;
    public class AddUserCommandHandler(IUserRepository _userRepository) : IRequestHandler<AddUserCommand, UserEntitiy>
    {
        public async Task<UserEntitiy> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var purchaseAirtimeToken = await _userRepository.AddUserAsync(request.userEntitiy);
            return purchaseAirtimeToken;
        }
    }
}
