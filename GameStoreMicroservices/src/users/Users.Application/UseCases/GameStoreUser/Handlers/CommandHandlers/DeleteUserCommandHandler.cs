using MediatR;                                                      // IRequestHandler |ishlashi uchun
using Users.Application.Abstractions;                               // IUserDbContext |ishlashi uchun
using Users.Application.UseCases.GameStoreUser.Commands;            // CreateUserCommand |ishlashi uchun
using Users.Domain.Entities;                                        // User |ishlashi uchun

namespace Users.Application.UseCases.GameStoreUser.Handlers.CommandHandlers
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, ResponseModel>
    {
        private readonly IUserDbContext _userDbContext;

        public DeleteUserCommandHandler(IUserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }

        public Task<ResponseModel> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            User user = _userDbContext.Users.FirstOrDefault(user => user.Id == request.Id);
            if (user == null)
            {
                return Task.FromResult(new ResponseModel
                {
                    IsSuccess = false,
                    StatusCode = 404,
                    Message = "User Not Found!"
                });
            }

            _userDbContext.Users.Remove(user);
            _userDbContext.SaveChangesAsync(cancellationToken);

            return Task.FromResult(new ResponseModel
            {
                IsSuccess = true,
                StatusCode = 204,
                Message = "Deleted!"
            });
        }
    }
}
