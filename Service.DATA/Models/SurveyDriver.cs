using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class SurveyDriver
{
    public long Id { get; set; }

    public long SurveyId { get; set; }

    public long DriverLicenseId { get; set; }

    public virtual DriverLicense DriverLicense { get; set; } = null!;

    public virtual Survey Survey { get; set; } = null!;
}
