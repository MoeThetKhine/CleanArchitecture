using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotNet8.Clean.Domain.Features.Blog;

#region Tbl_Blog

[Table("Tbl_Blog")]
public class Tbl_Blog
{
	[Key]
	public long BlogId { get; set; }

	public string BlogTitle { get; set; } = null!;

	public string BlogAuthor { get; set; } = null!;

	public string BlogContent { get; set; } = null!;

	public bool DeleteFlag { get; set; }
}

#endregion
