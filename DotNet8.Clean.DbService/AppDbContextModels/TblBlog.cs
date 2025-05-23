﻿namespace DotNet8.Clean.DbService.AppDbContextModels;

#region TblBlog

public partial class TblBlog
{
    public long BlogId { get; set; }

    public string BlogTitle { get; set; } = null!;

    public string BlogAuthor { get; set; } = null!;

    public string BlogContent { get; set; } = null!;

    public bool? DeleteFlag { get; set; }
}

#endregion
