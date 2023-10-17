using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class MoIshasmrEnbekDatum
{
    public int Id { get; set; }

    public string? Requestnumber { get; set; }

    public DateTime? Requestdate { get; set; }

    public DateTime? Responsedate { get; set; }

    public string? Iin { get; set; }

    public string? Lastname { get; set; }

    public string? Firstname { get; set; }

    public string? Patronymic { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? Statuscode { get; set; }

    public string? Statusnameru { get; set; }

    public string? Statusnamekz { get; set; }

    public string? Commentru { get; set; }

    public string? Commentkz { get; set; }

    public long? Surveyid { get; set; }

    public virtual Survey? Survey { get; set; }
}
