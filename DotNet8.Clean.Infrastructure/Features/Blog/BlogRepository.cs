using DotNet8.Clean.DTO.Features.Blog;
using DotNet8.Clean.Utlis;

namespace DotNet8.Clean.Infrastructure.Features.Blog;

public class BlogRepository : IBlogRepository
{
	private readonly BlogDbContext _context;

	public BlogRepository(BlogDbContext context)
	{
		_context = context;
	}

	#region CreateBlogAsync

	public async Task<Result<BlogModel>> CreateBlogAsync(BlogRequestModel blogRequest, CancellationToken cancellationToken)
	{
		Result<BlogModel> result;

		try
		{
			var blog = new Tbl_Blog()
			{
				BlogTitle = blogRequest.BlogTitle,
				BlogAuthor = blogRequest.BlogAuthor,
				BlogContent = blogRequest.BlogContent,
			};
			await _context.Tbl_Blogs.AddAsync(blog, cancellationToken);
			await _context.SaveChangesAsync();

			result = Result<BlogModel>.SaveSuccess();
		}
		catch (Exception ex)
		{
			result = Result<BlogModel>.Failure(ex);
		}
	result:
		return result;
	}

	#endregion
}
