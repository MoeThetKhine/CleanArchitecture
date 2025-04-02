namespace DotNet8.Clean.DTO.Features.Blog;

#region BlogListModel

public class BlogListModel
{
	public IEnumerable<BlogModel> DataLst { get; set; }
	public PageSettingModel PageSetting { get; set; }
}

#endregion

public class BlogListModelV1
{
	public IQueryable<BlogModel> DataLst { get; set; }
	public PageSettingModel PageSetting { get; set; }
}
