using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class PhoneNotification
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public long UserId { get; set; }

    public string Phone { get; set; } = null!;

    public bool Status { get; set; }

    public string Purpose { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime ExpiredAt { get; set; }

    public virtual User User { get; set; } = null!;
}
