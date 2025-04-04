namespace DotNet8.Clean.Application.Features.Blog.PatchBlog;

public class PatchBlogCommandHandler  : IRequestHandler<PatchBlogCommand, Result<BlogModel>> 
{
	private readonly IBlogRepository _blogRepository;

	public PatchBlogCommandHandler(IBlogRepository blogRepository)
	{
		_blogRepository = blogRepository;
	}

	#region PatchBlogCommandHandler

	public async Task<Result<BlogModel>> Handle(PatchBlogCommand request, CancellationToken cancellationToken)
	{
		Result<BlogModel> result;

		if(request.BlogId <= 0)
		{
			result = Result<BlogModel>.Fail(MessageResource.InvalidId);
			goto result;
		}

		result = await _blogRepository.PatchBlogAsync(request.BlogRequestModel, request.BlogId, cancellationToken);

		result:
		return result;
	}

	#endregion
}
