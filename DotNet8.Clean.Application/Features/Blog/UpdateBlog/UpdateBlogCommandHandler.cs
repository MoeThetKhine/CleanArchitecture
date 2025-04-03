namespace DotNet8.Clean.Application.Features.Blog.UpdateBlog;

public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, Result<BlogModel>>
{
	private readonly IBlogRepository _blogRepository;

	public UpdateBlogCommandHandler(IBlogRepository blogRepository)
	{
		_blogRepository = blogRepository;
	}

	public async Task<Result<BlogModel>> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
	{
		Result<BlogModel> result;

		if (request.RequestModel.BlogTitle.IsNullOrEmpty())
		{
			result = Result<BlogModel>.Fail("Blog Title Cannot be empty.");
			goto result;
		}

		if (request.RequestModel.BlogAuthor.IsNullOrEmpty())
		{
			result = Result<BlogModel>.Fail("Blog Author Cannot be empty.");
			goto result;
		}

		if (request.RequestModel.BlogContent.IsNullOrEmpty())
		{
			result = Result<BlogModel>.Fail("Blog Content Cannot be empty.");
			goto result;
		}

		result = await _blogRepository.UpdateBlogAsync(request.BlogId, request.RequestModel, cancellationToken);

	result:
		return result;
	}

}
