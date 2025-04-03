using DotNet8.Clean.DTO.Features.Blog;
using DotNet8.Clean.Utlis;

namespace DotNet8.Clean.Domain.Features.Blog;

public interface IBlogRepository
{
	Task<Result<BlogModel>> CreateBlogAsync(BlogRequestModel blogRequest, CancellationToken cancellationToken);
}
