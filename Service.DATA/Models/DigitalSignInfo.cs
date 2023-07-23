using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class DigitalSignInfo
{
    public long Id { get; set; }

    public DateTime NotBefore { get; set; }

    public DateTime NotAfter { get; set; }

    public string? Iin { get; set; }

    public string? Organization { get; set; }

    public string? Bin { get; set; }

    public string? FullName { get; set; }

    public string? UserType { get; set; }

    public string? Issuer { get; set; }

    public string? SerialNumber { get; set; }

    public virtual ICollection<DigitalSign> DigitalSigns { get; set; } = new List<DigitalSign>();
}
