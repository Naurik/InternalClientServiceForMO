using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class RankSalary
{
    public long Id { get; set; }

    public long ArmyRankId { get; set; }

    public int Salary { get; set; }

    public virtual ArmyRank ArmyRank { get; set; } = null!;
}
