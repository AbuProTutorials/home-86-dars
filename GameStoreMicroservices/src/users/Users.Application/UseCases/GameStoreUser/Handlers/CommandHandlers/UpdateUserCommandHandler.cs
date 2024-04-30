using MediatR;                                                      // IRequestHandler |ishlashi uchun
using Users.Application.Abstractions;                               // IUserDbContext |ishlashi uchun
using Users.Application.UseCases.GameStoreUser.Commands;            // CreateUserCommand |ishlashi uchun
using Users.Domain.Entities;                                        // User |ishlashi uchun

namespace Users.Application.UseCases.GameStoreUser.Handlers.CommandHandlers
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, ResponseModel>
    {
        private readonly IUserDbContext _userDbContext;

        public UpdateUserCommandHandler(IUserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }

        Task<ResponseModel> IRequestHandler<UpdateUserCommand, ResponseModel>.Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            User user = _userDbContext.Users.FirstOrDefault(user=>user.Id == request.Id);
            if(user is null)
            {
                return Task.FromResult(new ResponseModel
                {
                    IsSuccess = false,
                    StatusCode = 404,
                    Message = "User Not Found!"
                });
            }

            user.Fullname = request.Fullname;
            user.Age = request.Age;

            _userDbContext.Users.Update(user);
            _userDbContext.SaveChangesAsync(cancellationToken);

            return Task.FromResult(new ResponseModel
            {
                IsSuccess = true,
                StatusCode = 203,
                Message = "Updated!"
            });
        }
    }
}
