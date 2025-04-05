namespace DotNet8.Clean.Application.Features.Blog.DeleteBlog;

public class DeleteBlogCommand  : IRequest<Result<BlogModel>>
{

	public int BlogId {  get; set; }

	public DeleteBlogCommand(int blogId)
	{
		BlogId = blogId;
	}

}
