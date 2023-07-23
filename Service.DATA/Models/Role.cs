using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class Role
{
    public long Id { get; set; }

    public string TitleRu { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string TitleKz { get; set; } = null!;

    public virtual ICollection<Step> StepConfirmedRoles { get; set; } = new List<Step>();

    public virtual ICollection<Step> StepRequestedRoles { get; set; } = new List<Step>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
