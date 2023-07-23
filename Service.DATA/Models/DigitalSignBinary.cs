using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class DigitalSignBinary
{
    public long Id { get; set; }

    public byte[] Data { get; set; } = null!;

    public virtual ICollection<DigitalSign> DigitalSigns { get; set; } = new List<DigitalSign>();
}
