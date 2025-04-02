using DotNet8.Clean.DbService.AppDbContextModels;
using DotNet8.Clean.DTO.Features.Blog;

namespace DotNet8.Clean.Extension
{
	public static class Extension
	{
		public static BlogModel ToModel(this TblBlog dataModel)
		{
			return new BlogModel
			{
				BlogId = dataModel.BlogId,
				BlogTitle = dataModel.BlogTitle,
				BlogAuthor = dataModel.BlogAuthor,
				BlogContent = dataModel.BlogContent,
				DeleteFlag = dataModel.DeleteFlag
			};
		}
	}
}
