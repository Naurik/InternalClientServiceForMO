using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class Profile
{
    public long Id { get; set; }

    public long StepGroupId { get; set; }

    public long StepId { get; set; }

    public long SurveyId { get; set; }

    public long AreaId { get; set; }

    public long RequestedUserId { get; set; }

    public string RequestedUserIin { get; set; } = null!;

    public int RequestedStatus { get; set; }

    public string RequestedSign { get; set; } = null!;

    public long? ConfirmedUserId { get; set; }

    public string? ConfirmedUserIin { get; set; }

    public int? ConfirmedStatus { get; set; }

    public string? ConfirmedSign { get; set; }

    public int Status { get; set; }

    public string? Comment { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime ExpiredAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual User? ConfirmedUser { get; set; }

    public virtual ICollection<ProfileFile> ProfileFiles { get; set; } = new List<ProfileFile>();

    public virtual User RequestedUser { get; set; } = null!;

    public virtual Step Step { get; set; } = null!;

    public virtual StepGroup StepGroup { get; set; } = null!;

    public virtual Survey Survey { get; set; } = null!;
}
