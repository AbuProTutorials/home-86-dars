using MediatR;                                                      // IRequestHandler |ishlashi uchun
using Users.Application.Abstractions;                               // IUserDbContext |ishlashi uchun
using Users.Application.UseCases.GameStoreUser.Commands;            // CreateUserCommand |ishlashi uchun
using Users.Domain.Entities;                                        // User |ishlashi uchun

namespace Users.Application.UseCases.GameStoreUser.Handlers.CommandHandlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, ResponseModel>
    {
        private readonly IUserDbContext _userDbContext;

        public CreateUserCommandHandler(IUserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }

        public Task<ResponseModel> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User user = new User
            {
                Fullname = request.Fullname,
                Age = request.Age
            };

            _userDbContext.Users.Add(user);
            _userDbContext.SaveChangesAsync(cancellationToken);

            return Task.FromResult(new ResponseModel
            {
                IsSuccess = true,
                StatusCode = 200,
                Message = "Created!"
            });
        }
    }
}
