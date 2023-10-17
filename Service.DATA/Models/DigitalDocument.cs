using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class DigitalDocument
{
    public int Id { get; set; }

    public string? FileCompressed { get; set; }

    public long? SurveyId { get; set; }

    public virtual Survey? Survey { get; set; }
}
