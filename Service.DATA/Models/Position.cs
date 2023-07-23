using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class Position
{
    public long Id { get; set; }

    public string TitleRu { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string TitleKz { get; set; } = null!;

    public long JobCategoryId { get; set; }

    public long SecretLevelId { get; set; }

    public long? ArmyTypeId { get; set; }

    public long? CategoryPositionId { get; set; }

    public virtual ArmyType? ArmyType { get; set; }

    public virtual CategoryPosition? CategoryPosition { get; set; }

    public virtual JobCategory JobCategory { get; set; } = null!;

    public virtual SecretLevel SecretLevel { get; set; } = null!;

    public virtual ICollection<Survey> Surveys { get; set; } = new List<Survey>();

    public virtual ICollection<Vacancy> Vacancies { get; set; } = new List<Vacancy>();
}
