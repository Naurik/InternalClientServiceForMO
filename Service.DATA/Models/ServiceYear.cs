using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class ServiceYear
{
    public long Id { get; set; }

    public string TitleRu { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string TitleKz { get; set; } = null!;

    public int Max { get; set; }

    public int Min { get; set; }

    public virtual ICollection<JobYear> JobYears { get; set; } = new List<JobYear>();
}
