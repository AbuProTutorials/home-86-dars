using MediatR;                                                      // IMediator |ishlashi uchun  
using Microsoft.AspNetCore.Mvc;                                     // ApiController, ControllerBase |ishlashi uchun
using Users.Application.UseCases.GameStoreUser.Commands;            // CreateUserCommand, UpdateUserCommand, DeleteUserCommand |ishlashi uchun
using Users.Application.UseCases.GameStoreUser.Queries;             // GetAllUsersQuery |ishlashi uchun
using Users.Domain.Entities;

namespace Users.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            return _mediator.Send(new GetAllUsersQuery()).Result;
        }

        [HttpPost]
        public ResponseModel CreateUser(CreateUserCommand request)
        {
            return _mediator.Send(request).Result;
        }

        [HttpPut]
        public ResponseModel UpdateUser(UpdateUserCommand request)
        {
            return _mediator.Send(request).Result;
        }

        [HttpDelete]
        public ResponseModel DeleteUser(DeleteUserCommand request)
        {
            return _mediator.Send(request).Result;
        }
    }
}
