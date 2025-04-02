using System;
using System.Collections.Generic;

namespace DotNet8.Clean.DbService.AppDbContextModels;

public partial class JobParameter
{
    public long JobId { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public virtual Job Job { get; set; } = null!;
}
