using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class SurveyRelative
{
    public long Id { get; set; }

    public long RelativeId { get; set; }

    public long SurveyId { get; set; }

    public string Name { get; set; } = null!;

    public string SurName { get; set; } = null!;

    public string? Patronomic { get; set; }

    public string Iin { get; set; } = null!;

    public string BirthDate { get; set; } = null!;

    public virtual Relative Relative { get; set; } = null!;

    public virtual Survey Survey { get; set; } = null!;
}
