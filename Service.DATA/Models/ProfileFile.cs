using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class ProfileFile
{
    public long Id { get; set; }

    public long ProfileId { get; set; }

    public string File { get; set; } = null!;

    public string? Comment { get; set; }

    public bool? IsConfirmated { get; set; }

    public bool? IsRequested { get; set; }

    public long? UserId { get; set; }

    public virtual Profile Profile { get; set; } = null!;

    public virtual User? User { get; set; }
}
