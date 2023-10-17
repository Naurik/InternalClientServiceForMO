using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class GbdflRegAddress
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

    public string? Street { get; set; }

    public string? Building { get; set; }

    public DateTime? Begindate { get; set; }

    public string? Statuscode { get; set; }

    public string? Statusnameru { get; set; }

    public string? Statusnamekz { get; set; }

    public DateTime? Statuschangedate { get; set; }

    public string? Invaliditycode { get; set; }

    public string? Invaliditynameru { get; set; }

    public string? Invaliditynamekz { get; set; }

    public DateTime? Invaliditychangedate { get; set; }

    public string? Arcode { get; set; }

    public virtual ICollection<GbdflPersonInfo> GbdflPersonInfos { get; set; } = new List<GbdflPersonInfo>();
}
