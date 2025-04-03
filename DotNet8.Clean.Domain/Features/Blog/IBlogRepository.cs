namespace DotNet8.Clean.Domain.Features.Blog;

#region IBlogRepository

public interface IBlogRepository
{
	Task<Result<BlogListModelV1>> GetBlogsAsync(int pageNo, int pageSize, CancellationToken cancellationToken);
	Task<Result<BlogModel>> GetBlogByIdAsync(int id, CancellationToken cancellationToken);
	Task<Result<BlogModel>> CreateBlogAsync(BlogRequestModel blogRequest, CancellationToken cancellationToken);
	Task<Result<BlogModel>> UpdateBlogAsync(int id, BlogRequestModel blogRequest, CancellationToken cancellationToken);
	Task<Result<BlogModel>> PatchBlogAsync(BlogRequestModel requestModel, int id, CancellationToken cancellationToken);
	Task<Result<BlogModel>> DeleteBlogAsync(int id, CancellationToken cancellationToken);
}

#endregion