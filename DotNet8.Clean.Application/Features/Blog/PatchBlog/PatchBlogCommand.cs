namespace DotNet8.Clean.Application.Features.Blog.PatchBlog;

public class PatchBlogCommand : IRequest<Result<BlogModel>>
{
	public BlogRequestModel BlogRequestModel { get; set; }

	public int BlogId { get; set; }


	public PatchBlogCommand(BlogRequestModel blogRequestModel, int blogId)
	{
		BlogRequestModel = blogRequestModel;
		BlogId = blogId;
	}


}