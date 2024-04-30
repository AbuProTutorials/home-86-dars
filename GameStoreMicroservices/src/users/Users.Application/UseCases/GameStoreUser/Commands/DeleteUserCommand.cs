using MediatR;                      // IRequest |ishlashi uchun
using Users.Domain.Entities;        // ResponseModel |ishlashi uchun

namespace Users.Application.UseCases.GameStoreUser.Commands
{
    public class DeleteUserCommand:IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
    }
}
