using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class JobYear
{
    public long Id { get; set; }

    public long JobCategoryId { get; set; }

    public long ServiceYearId { get; set; }

    public int Salary { get; set; }

    public virtual JobCategory JobCategory { get; set; } = null!;

    public virtual ServiceYear ServiceYear { get; set; } = null!;
}
