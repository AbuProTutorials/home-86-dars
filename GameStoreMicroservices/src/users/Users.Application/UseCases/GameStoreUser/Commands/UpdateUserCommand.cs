using MediatR;                      // IRequest |ishlashi uchun
using Users.Domain.Entities;        // ResponseModel |ishlashi uchun

namespace Users.Application.UseCases.GameStoreUser.Commands
{
    public class UpdateUserCommand:IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
    }
}
