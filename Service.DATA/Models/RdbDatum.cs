using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class RdbDatum
{
    public int Id { get; set; }

    public long? Surveyid { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Secondname { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? Iin { get; set; }

    public string? Messagenarcologyru { get; set; }

    public string? Messagepsychoru { get; set; }

    public string? Messagetuberculosisru { get; set; }

    public string? Messagevenereologicalru { get; set; }

    public string? Messagenarcologykz { get; set; }

    public string? Messagepsychokz { get; set; }

    public string? Messagetuberculosiskz { get; set; }

    public string? Messagevenereologicalkz { get; set; }

    public string? Address { get; set; }

    public virtual Survey? Survey { get; set; }
}
