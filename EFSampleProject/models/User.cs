using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFSampleProject.models;

public partial class User
{
    [Key]
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<Board> Boards { get; set; } = new List<Board>();
}
