using MediatR;                                                      // IRequestHandler |ishlashi uchun
using Users.Application.Abstractions;                               // IUserDbContext |ishlashi uchun
using Users.Application.UseCases.GameStoreUser.Queries;             // GetAllUsersQuery |ishlashi uchun
using Users.Domain.Entities;                                        // User |ishlashi uchun

namespace Users.Application.UseCases.GameStoreUser.Handlers.QueryHandlers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery,IEnumerable<User>>
    {
        private readonly IUserDbContext _userDbContext;

        public GetAllUsersQueryHandler(IUserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }

        Task<IEnumerable<User>> IRequestHandler<GetAllUsersQuery, IEnumerable<User>>.Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult((IEnumerable<User>)_userDbContext.Users.ToList());
        }
    }
}
