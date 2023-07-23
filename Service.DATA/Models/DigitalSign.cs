using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class DigitalSign
{
    public long Id { get; set; }

    public string? FileName { get; set; }

    public DateTime Signed { get; set; }

    public DateTime? Verified { get; set; }

    public bool IsValid { get; set; }

    public string? ErrorMessage { get; set; }

    public bool IsRevoked { get; set; }

    public long? InfoId { get; set; }

    public long BinaryDataId { get; set; }

    public long? SurveyId { get; set; }

    public long? StepId { get; set; }

    public long? WhoSignedId { get; set; }

    public long? SignedUserId { get; set; }

    public virtual DigitalSignBinary BinaryData { get; set; } = null!;

    public virtual DigitalSignInfo? Info { get; set; }

    public virtual User? SignedUser { get; set; }

    public virtual Step? Step { get; set; }

    public virtual Survey? Survey { get; set; }
}
