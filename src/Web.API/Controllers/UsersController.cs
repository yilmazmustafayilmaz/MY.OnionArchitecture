using Application.Features.Users.Commands.CreateUser;
using Application.Features.Users.Commands.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator) => _mediator = mediator;

    /// <summary>
    /// Create User
    /// </summary>
    /// <param name="createUserCommandRequest"></param>
    /// <returns></returns>
    [HttpPost("[action]")]
    public async Task<IActionResult> Create([FromBody] CreateUserCommandRequest createUserCommandRequest) => Ok(await _mediator.Send(createUserCommandRequest));

    
}
