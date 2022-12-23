using Application.Features.Authors.Commands.CreateAuthor;
using Application.Features.Authors.Commands.CreateAuthorImage;
using Application.Features.Authors.Commands.RemoveAuthor;
using Application.Features.Authors.Commands.RemoveAuthorImage;
using Application.Features.Authors.Commands.UpdateAuthor;
using Application.Features.Authors.Queries.GetAllAuthor;
using Application.Features.Authors.Queries.GetByIdAuthor;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Web.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Admin")]
public class AuthorsController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthorsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Create Author
    /// </summary>
    /// <param name="createAuthorCommandRequest"></param>
    /// <returns></returns>
    [HttpPost("[action]")]
    public async Task<IActionResult> Add([FromBody] CreateAuthorCommandRequest createAuthorCommandRequest) => Ok(await _mediator.Send(createAuthorCommandRequest));

    /// <summary>
    /// Update Author
    /// </summary>
    /// <param name="updateAuthorCommandRequest"></param>
    /// <returns></returns>
    [HttpPut("[action]")]
    public async Task<IActionResult> Update([FromBody] UpdateAuthorCommandRequest updateAuthorCommandRequest) => Ok(await _mediator.Send(updateAuthorCommandRequest));

    /// <summary>
    /// Delete Author
    /// </summary>
    /// <param name="removeAuthorCommandReqeust"></param>
    /// <returns></returns>
    [HttpDelete("[action]/{Id}")]
    public async Task<IActionResult> Delete([FromRoute] RemoveAuthorCommandReqeust removeAuthorCommandReqeust) => Ok(await _mediator.Send(removeAuthorCommandReqeust));

    /// <summary>
    /// Get All Author
    /// </summary>
    /// <param name="getAllAuthorQueryRequest"></param>
    /// <returns></returns>
    [HttpGet("[action]")]
    public async Task<IActionResult> GetAll([FromQuery] GetAllAuthorQueryRequest getAllAuthorQueryRequest) => Ok(await _mediator.Send(getAllAuthorQueryRequest));

    /// <summary>
    /// Get By Id Author
    /// </summary>
    /// <param name="getByIdAuthorQueryReqeust"></param>
    /// <returns></returns>
    [HttpGet("[action]/{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdAuthorQueryReqeust getByIdAuthorQueryReqeust) => Ok(await _mediator.Send(getByIdAuthorQueryReqeust));

    /// <summary>
    /// Upload Author Image
    /// </summary>
    /// <param name="uploadAuthorImageCommandRequest"></param>
    /// <returns></returns>
    [HttpPost("[action]")]
    public async Task<IActionResult> UploadImage([FromQuery] UploadAuthorImageCommandRequest uploadAuthorImageCommandRequest) => Ok(await _mediator.Send(uploadAuthorImageCommandRequest));

    /// <summary>
    /// Delete Author Image
    /// </summary>
    /// <param name="removeAuthorImageCommandRequest"></param>
    /// <returns></returns>
    [HttpDelete("[action]/{Id}")]
    public async Task<IActionResult> DeleteImage([FromRoute] RemoveAuthorImageCommandRequest removeAuthorImageCommandRequest) => Ok(await _mediator.Send(removeAuthorImageCommandRequest));
}
