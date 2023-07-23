using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class Qualification
{
    public long Id { get; set; }

    public string TitleRu { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string TitleKz { get; set; } = null!;

    public int Percentage { get; set; }

    public virtual ICollection<Vacancy> Vacancies { get; set; } = new List<Vacancy>();
}
