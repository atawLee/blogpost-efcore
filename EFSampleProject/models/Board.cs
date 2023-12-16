using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFSampleProject.models;

public partial class Board
{
    [Key]
    public int BoardId { get; set; }

    public string Title { get; set; } = null!;

    public string Contents { get; set; } = null!;

    public DateTime? PostDate { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
