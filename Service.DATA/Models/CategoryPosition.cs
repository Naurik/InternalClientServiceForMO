using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class CategoryPosition
{
    public long Id { get; set; }

    public string TitleRu { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string TitleKz { get; set; } = null!;

    public virtual ICollection<Position> Positions { get; set; } = new List<Position>();
}
