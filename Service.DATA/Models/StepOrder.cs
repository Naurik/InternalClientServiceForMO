using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class StepOrder
{
    public long Id { get; set; }

    public long StepId { get; set; }

    public long? PreviousStepId { get; set; }

    public long? NextStepId { get; set; }

    public virtual Step? NextStep { get; set; }

    public virtual Step? PreviousStep { get; set; }

    public virtual Step Step { get; set; } = null!;
}
