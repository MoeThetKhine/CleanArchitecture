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

	#region GetBlogAsync

	[HttpGet]
	public async Task<IActionResult> GetBlogAsync(int pageNo, int  pageSize, CancellationToken cancellationToken)
	{
		var query = new GetBlogListQuery(pageNo, pageSize);
		var result = await _mediator.Send(query,cancellationToken);

		return Content(result);
	}

	#endregion

	#region GetBlogByIdAsync

	[HttpGet("{id}")]
	public async Task<IActionResult> GetBlogByIdAsync(int id, CancellationToken cancellationToken)
	{
		var query = new GetBlogByIdQuery(id);
		var result =  await _mediator.Send(query, cancellationToken);

		return Content(result);
	}

	#endregion

	#region CreateBlogAsync

	[HttpPost]
	public async Task<IActionResult> CreateBlogAsync([FromBody] BlogRequestModel requestModel, CancellationToken cancellationToken)
	{
		var command = new CreateBlogCommand(requestModel);
		var result = await _mediator.Send(command, cancellationToken);

		return Content(result);
	}

	#endregion

	#region UpdateBlogAsync

	[HttpPut("{id}")]
	public async Task<IActionResult> UpdateBlogAsync([FromBody] BlogRequestModel requestModel, int id, CancellationToken cancellationToken)
	{
		var command = new UpdateBlogCommand(requestModel, id);
		var result = await _mediator.Send(command,cancellationToken);

		return Content(result);
	}

	#endregion

	#region PatchBlogAsync

	[HttpPatch("{id}")]
	public async Task<IActionResult> PatchBlogAsync([FromBody] BlogRequestModel requestModel, int id, CancellationToken cancellationToken)
	{
		var command = new PatchBlogCommand(requestModel, id);
		var result = await _mediator.Send(command, cancellationToken);

		return Content(result);
	}

	#endregion

	#region DeleteBlogAsync

	[HttpDelete("{id}")]
	public async Task<IActionResult> DeleteBlogAsync(int id, CancellationToken cancellationToken)
	{
		var command = new DeleteBlogCommand(id);
		var result = await _mediator.Send(command, cancellationToken);
		return Content(result);
	}

	#endregion

}
