using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class StepGroup
{
    public long Id { get; set; }

    public string TitleRu { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string TitleKz { get; set; } = null!;

    public int Order { get; set; }

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual ICollection<Step> Steps { get; set; } = new List<Step>();

    public virtual ICollection<Survey> Surveys { get; set; } = new List<Survey>();
}
