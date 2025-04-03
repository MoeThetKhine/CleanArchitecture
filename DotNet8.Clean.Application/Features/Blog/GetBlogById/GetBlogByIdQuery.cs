namespace DotNet8.Clean.Application.Features.Blog.GetBlogById;

#region GetBlogByIdQuery

public class GetBlogByIdQuery : IRequest<Result<BlogModel>>
{
	public int BlogId { get; set; }

	public GetBlogByIdQuery(int blogId)
	{
		BlogId = blogId;
	}
}

#endregion
