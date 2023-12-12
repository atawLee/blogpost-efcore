using System;
using System.Collections.Generic;

namespace EFSampleProject;

public partial class Board
{
    public int BoardId { get; set; }

    public string Title { get; set; } = null!;

    public string Contents { get; set; } = null!;

    public DateTime? PostDate { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
