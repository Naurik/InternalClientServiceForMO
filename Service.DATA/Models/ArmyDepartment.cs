using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class ArmyDepartment
{
    public long Id { get; set; }

    public string TitleRu { get; set; } = null!;

    public string TitleKz { get; set; } = null!;

    public string TitleEn { get; set; } = null!;
}
