using Application.Features.Articles.Commands.CreateArticle;
using Application.Features.Articles.Commands.RemoveArticle;
using Application.Features.Articles.Commands.UpdateArticle;
using Application.Features.Articles.Queries.GetAllArticle;
using Application.Features.Articles.Queries.GetByIdArticle;
using Application.Services;
using Domain.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArticlesController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMailService _mailService;

    public ArticlesController(IMediator mediator, IMailService mailService) 
    {
        _mailService = mailService;
    }


    /// <summary>
    /// Create Article
    /// </summary>
    /// <param name="createArticleCommandRequest"></param>
    /// <returns></returns>
    [HttpPost("[action]")]
    public async Task<IActionResult> Add([FromBody] CreateArticleCommandRequest createArticleCommandRequest) => Ok(await _mediator.Send(createArticleCommandRequest));

    /// <summary>
    /// Update Article
    /// </summary>
    /// <param name="updateArticleCommandRequest"></param>
    /// <returns></returns>
    [HttpPut("[action]")]
    public async Task<IActionResult> Update([FromBody] UpdateArticleCommandRequest updateArticleCommandRequest) => Ok(await _mediator.Send(updateArticleCommandRequest));

    /// <summary>
    /// Delete Article
    /// </summary>
    /// <param name="removeArticleCommandRequest"></param>
    /// <returns></returns>
    [HttpDelete("[action]/{Id}")]
    public async Task<IActionResult> Delete([FromRoute] RemoveArticleCommandRequest removeArticleCommandRequest) => Ok(await _mediator.Send(removeArticleCommandRequest));

    /// <summary>
    /// Get By Id Article
    /// </summary>
    /// <param name="getByIdArticleQueryRequest"></param>
    /// <returns></returns>
    [HttpGet("[action]/{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdArticleQueryRequest getByIdArticleQueryRequest) => Ok(await _mediator.Send(getByIdArticleQueryRequest));

    /// <summary>
    /// Get All Article
    /// </summary>
    /// <param name="getAllArticleQueryRequest"></param>
    /// <returns></returns>
    [HttpGet("[action]")]
    public async Task<IActionResult> GetAll([FromQuery] GetAllArticleQueryRequest getAllArticleQueryRequest) => Ok(await _mediator.Send(getAllArticleQueryRequest));
}
