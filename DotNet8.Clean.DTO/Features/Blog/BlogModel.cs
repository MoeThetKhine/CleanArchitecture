﻿namespace DotNet8.Clean.DTO.Features.Blog;

#region BlogModel

public class BlogModel
{
	public long BlogId { get; set; }

	public string BlogTitle { get; set; } = null!;

	public string BlogAuthor { get; set; } = null!;

	public string BlogContent { get; set; } = null!;

	public bool? DeleteFlag { get; set; }
}

#endregion
