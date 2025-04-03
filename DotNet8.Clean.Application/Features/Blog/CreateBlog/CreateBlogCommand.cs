using DotNet8.Clean.DTO.Features.Blog;
using DotNet8.Clean.Utlis;
using MediatR;

namespace DotNet8.Clean.Application.Features.Blog.CreateBlog;

public class CreateBlogCommand : IRequest<Result<BlogModel>>
{
	public BlogRequestModel requestModel;

	public CreateBlogCommand(BlogRequestModel requestModel)
	{
		this.requestModel = requestModel;
	}
}
