using Application.Features.Users.Commands.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthController(IMediator mediator) => _mediator = mediator;

    /// <summary>
    /// Login User
    /// </summary>
    /// <param name="loginUserCommandRequest"></param>
    /// <returns></returns>
    [HttpPost("[action]")]
    public async Task<IActionResult> Login([FromBody] LoginUserCommandRequest loginUserCommandRequest) => Ok(await _mediator.Send(loginUserCommandRequest));
}
