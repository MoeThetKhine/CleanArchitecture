namespace DotNet8.Clean.Domain.Features.Blog;

public interface IBlogRepository
{
	Task<Result<BlogModel>> CreateBlogAsync(BlogRequestModel blogRequest, CancellationToken cancellationToken);
}
