using MediatR;                      // IRequest |ishlashi uchun
using Users.Domain.Entities;        // ResponseModel |ishlashi uchun

namespace Users.Application.UseCases.GameStoreUser.Commands
{
    public class CreateUserCommand:IRequest<ResponseModel>
    {
        public string Fullname { get; set; }
        public int Age { get; set; }
    }
}
