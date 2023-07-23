using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class ArmyRank
{
    public long Id { get; set; }

    public string TitleRu { get; set; } = null!;

    public string TitleKz { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public virtual ICollection<RankSalary> RankSalaries { get; set; } = new List<RankSalary>();

    public virtual ICollection<Survey> Surveys { get; set; } = new List<Survey>();
}
