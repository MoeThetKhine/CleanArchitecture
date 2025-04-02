using System;
using System.Collections.Generic;

namespace DotNet8.Clean.DbService.AppDbContextModels;

public partial class Hash
{
    public string Key { get; set; } = null!;

    public string Field { get; set; } = null!;

    public string? Value { get; set; }

    public DateTime? ExpireAt { get; set; }
}
