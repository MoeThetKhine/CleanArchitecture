﻿using DotNet8.Clean.Application.Features.Blog.CreateBlog;
using DotNet8.Clean.Application.Features.Blog.GetBlogById;
using DotNet8.Clean.Application.Features.Blog.GetBlogList;
using DotNet8.Clean.DTO.Features.Blog;
using MediatR;

namespace DotNet8.Clean.Presentation.Controllers.Blog;

[Route("api/[controller]")]
[ApiController]
public class BlogController : BaseController
{
	private readonly IMediator _mediator;

	public BlogController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async Task<IActionResult> GetBlogAsync(int pageNo, int  pageSize, CancellationToken cancellationToken)
	{
		var query = new GetBlogListQuery(pageNo, pageSize);
		var result = await _mediator.Send(query,cancellationToken);

		return Content(result);
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> GetBlogByIdAsync(int id, CancellationToken cancellationToken)
	{
		var query = new GetBlogByIdQuery(id);
		var result =  await _mediator.Send(query, cancellationToken);

		return Content(result);
	}

	[HttpPost]
	public async Task<IActionResult> CreateBlogAsync([FromBody] BlogRequestModel requestModel, CancellationToken cancellationToken)
	{
		var command = new CreateBlogCommand(requestModel);
		var result = await _mediator.Send(command, cancellationToken);

		return Content(result);
	}


}
