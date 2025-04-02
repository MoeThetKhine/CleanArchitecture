using System;
using System.Collections.Generic;

namespace DotNet8.Clean.DbService.AppDbContextModels;

public partial class AggregatedCounter
{
    public string Key { get; set; } = null!;

    public long Value { get; set; }

    public DateTime? ExpireAt { get; set; }
}
