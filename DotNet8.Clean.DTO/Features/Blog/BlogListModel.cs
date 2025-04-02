using DotNet8.Clean.DTO.Features.PageSetting;

namespace DotNet8.Clean.DTO.Features.Blog;

public class BlogListModel
{
	public IEnumerable<BlogModel> DataLst { get; set; }
	public PageSettingModel PageSetting { get; set; }
}
