using DotNet8.Clean.Application.Features.Blog.GetBlogList;

namespace DotNet8.Clean.Application.Features.Blog.GetBlogById;


public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, Result<BlogModel>>
{
	private readonly IBlogRepository _blogRepository;

	public GetBlogByIdQueryHandler(IBlogRepository blogRepository)
	{
		_blogRepository = blogRepository;
	}

	#region Handle

	public async Task<Result<BlogModel>> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
	{
		Result<BlogModel> result;

		if (request.BlogId <= 0)
		{
			result = Result<BlogModel>.Fail(MessageResource.InvalidId);
			goto result;
		}

		result = await _blogRepository.GetBlogByIdAsync(request.BlogId, cancellationToken);

	result:
		return result;
	}

	#endregion

}