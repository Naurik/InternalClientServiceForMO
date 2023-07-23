using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class Survey
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Iin { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public long BirthAreaId { get; set; }

    public string Region { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string? Home { get; set; }

    public string? Appartment { get; set; }

    public long EducationId { get; set; }

    public bool Experienced { get; set; }

    public bool Served { get; set; }

    public string? ServedArmyNumber { get; set; }

    public string? PositionName { get; set; }

    public long? ArmyRankId { get; set; }

    public bool VtshServed { get; set; }

    public long? VtshId { get; set; }

    public string? VtshYear { get; set; }

    public long PositionId { get; set; }

    public string? ArmyNumber { get; set; }

    public int ContractYear { get; set; }

    public long AreaId { get; set; }

    public long? VacancyId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string AutoBiography { get; set; } = null!;

    public string EducationUrl { get; set; } = null!;

    public string IncomePropertyUrl { get; set; } = null!;

    public string EmploymentUrl { get; set; } = null!;

    public string MillitaryUrl { get; set; } = null!;

    public string SpecialCheckUrl { get; set; } = null!;

    public string IdentityCardUrl { get; set; } = null!;

    public string? TuberUrl { get; set; }

    public string? DermatologUrl { get; set; }

    public string? PsychoNeurologicalUrl { get; set; }

    public string? NarcologicalUrl { get; set; }

    public bool Agreed { get; set; }

    public string SignKey { get; set; } = null!;

    public long? StepGroupId { get; set; }

    public long? CurrentStepId { get; set; }

    public int Status { get; set; }

    public long? MedicalStatusId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual ArmyRank? ArmyRank { get; set; }

    public virtual Area BirthArea { get; set; } = null!;

    public virtual Step? CurrentStep { get; set; }

    public virtual ICollection<DigitalSign> DigitalSigns { get; set; } = new List<DigitalSign>();

    public virtual Education Education { get; set; } = null!;

    public virtual MedicalStatus? MedicalStatus { get; set; }

    public virtual Position Position { get; set; } = null!;

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual StepGroup? StepGroup { get; set; }

    public virtual ICollection<SurveyDriver> SurveyDrivers { get; set; } = new List<SurveyDriver>();

    public virtual SurveyExecutor? SurveyExecutor { get; set; }

    public virtual ICollection<SurveyRelative> SurveyRelatives { get; set; } = new List<SurveyRelative>();

    public virtual User User { get; set; } = null!;

    public virtual Vacancy? Vacancy { get; set; }

    public virtual VtSh? Vtsh { get; set; }
}
