using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class Kdptoken
{
    public int Id { get; set; }

    public string? TokenVal { get; set; }

    public long? SurveyId { get; set; }

    public string? PublicKey { get; set; }

    public virtual Survey? Survey { get; set; }
}
