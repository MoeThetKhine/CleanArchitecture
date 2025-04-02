﻿namespace DotNet8.Clean.DTO.Features.Blog;

#region BlogRequestModel

public class BlogRequestModel
{
	public string BlogTitle { get; set; } = null!;
	public string BlogAuthor { get; set; } = null!;
	public string BlogContent { get; set; } = null!;
}

#endregion
