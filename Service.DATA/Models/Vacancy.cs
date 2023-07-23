using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class Vacancy
{
    public long Id { get; set; }

    public long PositionId { get; set; }

    public long JobCategoryId { get; set; }

    public long AreaId { get; set; }

    public string City { get; set; } = null!;

    public long ArmyTypeId { get; set; }

    public long ArmyRegionId { get; set; }

    public long SecretLevelId { get; set; }

    public long QualificationId { get; set; }

    public long? AuthorId { get; set; }

    public int Quantity { get; set; }

    public bool Status { get; set; }

    public string DescriptionRu { get; set; } = null!;

    public string? DescriptionEn { get; set; }

    public string? DescriptionKz { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual ArmyRegion ArmyRegion { get; set; } = null!;

    public virtual ArmyType ArmyType { get; set; } = null!;

    public virtual User? Author { get; set; }

    public virtual JobCategory JobCategory { get; set; } = null!;

    public virtual Position Position { get; set; } = null!;

    public virtual Qualification Qualification { get; set; } = null!;

    public virtual SecretLevel SecretLevel { get; set; } = null!;

    public virtual ICollection<Survey> Surveys { get; set; } = new List<Survey>();
}
