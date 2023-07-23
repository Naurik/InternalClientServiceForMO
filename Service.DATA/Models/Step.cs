using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class Step
{
    public long Id { get; set; }

    public long StepGroupId { get; set; }

    public string TitleRu { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string TitleKz { get; set; } = null!;

    public long RequestedRoleId { get; set; }

    public long ConfirmedRoleId { get; set; }

    public bool IsFirst { get; set; }

    public bool IsLast { get; set; }

    public int DayLimit { get; set; }

    public virtual Role ConfirmedRole { get; set; } = null!;

    public virtual ICollection<DigitalSign> DigitalSigns { get; set; } = new List<DigitalSign>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual Role RequestedRole { get; set; } = null!;

    public virtual StepGroup StepGroup { get; set; } = null!;

    public virtual ICollection<StepOrder> StepOrderNextSteps { get; set; } = new List<StepOrder>();

    public virtual ICollection<StepOrder> StepOrderPreviousSteps { get; set; } = new List<StepOrder>();

    public virtual ICollection<StepOrder> StepOrderSteps { get; set; } = new List<StepOrder>();

    public virtual ICollection<Survey> Surveys { get; set; } = new List<Survey>();
}
