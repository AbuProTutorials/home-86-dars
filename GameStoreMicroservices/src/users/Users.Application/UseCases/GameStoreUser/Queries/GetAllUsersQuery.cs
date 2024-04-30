using MediatR;                      // IRequest |ishlashi uchun
using Users.Domain.Entities;        // ResponseModel |ishlashi uchun

namespace Users.Application.UseCases.GameStoreUser.Queries
{
    public class GetAllUsersQuery:IRequest<IEnumerable<User>>
    {
    }
}
