using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class DriverLicense
{
    public long Id { get; set; }

    public string TitleRu { get; set; } = null!;

    public string TitleKz { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public virtual ICollection<SurveyDriver> SurveyDrivers { get; set; } = new List<SurveyDriver>();
}
