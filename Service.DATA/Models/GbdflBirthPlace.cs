using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class GbdflBirthPlace
{
    public long Id { get; set; }

    public string? Countrycode { get; set; }

    public string? Countrynameru { get; set; }

    public string? Countrynamekz { get; set; }

    public DateTime? Countrychangedate { get; set; }

    public string? Districtcode { get; set; }

    public string? Districtnameru { get; set; }

    public string? Districtnamekz { get; set; }

    public DateTime? Districtchangedate { get; set; }

    public string? Regioncode { get; set; }

    public string? Regionnameru { get; set; }

    public string? Regionnamekz { get; set; }

    public DateTime? Regionchangedate { get; set; }

    public string? City { get; set; }

    public virtual ICollection<GbdflPersonInfo> GbdflPersonInfos { get; set; } = new List<GbdflPersonInfo>();
}
