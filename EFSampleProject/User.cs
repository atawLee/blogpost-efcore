using System;
using System.Collections.Generic;

namespace EFSampleProject;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<Board> Boards { get; set; } = new List<Board>();
}
