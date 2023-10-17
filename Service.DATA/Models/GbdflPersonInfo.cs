using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class GbdflPersonInfo
{
    public long Id { get; set; }

    public long? Birthplaceid { get; set; }

    public long? Regaddressid { get; set; }

    public long? Documentsid { get; set; }

    public string? Iin { get; set; }

    public string? Surname { get; set; }

    public string? Patronymic { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? Gendercode { get; set; }

    public string? Gendernameru { get; set; }

    public string? Gendernamekz { get; set; }

    public DateTime? Genderchangedate { get; set; }

    public string? Nationalitycode { get; set; }

    public string? Nationalitynameru { get; set; }

    public string? Nationalitynamekz { get; set; }

    public DateTime? Nationalitychangedate { get; set; }

    public string? Citizenshipcode { get; set; }

    public string? Citizenshipnameru { get; set; }

    public string? Citizenshipnamekz { get; set; }

    public DateTime? Citizenshipchangedate { get; set; }

    public string? Lifestatuscode { get; set; }

    public string? Lifestatusnameru { get; set; }

    public string? Lifestatusnamekz { get; set; }

    public DateTime? Lifestatuschangedate { get; set; }

    public long? Surveyid { get; set; }

    public string? Name { get; set; }

    public virtual GbdflBirthPlace? Birthplace { get; set; }

    public virtual GbdflDocument? Documents { get; set; }

    public virtual GbdflRegAddress? Regaddress { get; set; }

    public virtual Survey? Survey { get; set; }
}
