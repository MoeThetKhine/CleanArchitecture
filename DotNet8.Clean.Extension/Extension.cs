namespace DotNet8.Clean.Extension
{
	public static class Extension
	{
		#region ToModel

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

		#endregion

		#region ToEntity

		public static TblBlog ToEntity(this BlogRequestModel model)
		{
			return new TblBlog
			{
				BlogTitle = model.BlogTitle,
				BlogAuthor = model.BlogAuthor,
				BlogContent = model.BlogContent
			};
		}

		#endregion
	}
}
