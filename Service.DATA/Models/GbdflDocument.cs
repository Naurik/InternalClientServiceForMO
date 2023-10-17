using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class GbdflDocument
{
    public long Id { get; set; }

    public string? Typecode { get; set; }

    public string? Typenameru { get; set; }

    public string? Typenamekz { get; set; }

    public DateTime? Typechangedate { get; set; }

    public string? Number { get; set; }

    public DateTime? Begindate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Issueorganizationcode { get; set; }

    public string? Issueorganizationcodenameru { get; set; }

    public string? Issueorganizationcodenamekz { get; set; }

    public DateTime? Issueorganizationcodechangedate { get; set; }

    public string? Statuscode { get; set; }

    public string? Statusnameru { get; set; }

    public string? Statusnamekz { get; set; }

    public DateTime? Statuschangedate { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Patronymic { get; set; }

    public DateTime? Birthdate { get; set; }

    public virtual ICollection<GbdflPersonInfo> GbdflPersonInfos { get; set; } = new List<GbdflPersonInfo>();
}
