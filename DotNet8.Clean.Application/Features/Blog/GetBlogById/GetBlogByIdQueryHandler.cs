using DotNet8.Clean.Application.Features.Blog.GetBlogList;

namespace DotNet8.Clean.Application.Features.Blog.GetBlogById;


public class GetBlogListQueryHandler : IRequestHandler<GetBlogListQuery, Result<BlogListModelV1>>
{
	public int BlogId { get; set; }


}
