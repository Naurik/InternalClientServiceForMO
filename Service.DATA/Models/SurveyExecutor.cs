using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class SurveyExecutor
{
    public long Id { get; set; }

    public long SurveyId { get; set; }

    public long ExecutorId { get; set; }

    public long DirectorId { get; set; }

    public virtual User Director { get; set; } = null!;

    public virtual User Executor { get; set; } = null!;

    public virtual Survey Survey { get; set; } = null!;
}
