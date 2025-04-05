namespace DotNet8.Clean.Application.Features.Blog.DeleteBlog;

public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand, Result<BlogModel>>
{
	private readonly IBlogRepository _blogRepository;

	public DeleteBlogCommandHandler(IBlogRepository blogRepository)
	{
		_blogRepository = blogRepository;
	}

	public async Task<Result<BlogModel>> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
	{
		Result<BlogModel> result;

		if(request.BlogId <= 0)
		{
			result = Result<BlogModel>.Fail(MessageResource.InvalidId);
			goto result;
		}

		result = await _blogRepository.DeleteBlogAsync(request.BlogId, cancellationToken);

		result:
		return result;
	}
}
