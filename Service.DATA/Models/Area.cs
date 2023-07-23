using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class Area
{
    public long Id { get; set; }

    public string TitleRu { get; set; } = null!;

    public string TitleEn { get; set; } = null!;

    public string TitleKz { get; set; } = null!;

    public int? RegionNumber { get; set; }

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual ICollection<Survey> SurveyAreas { get; set; } = new List<Survey>();

    public virtual ICollection<Survey> SurveyBirthAreas { get; set; } = new List<Survey>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<Vacancy> Vacancies { get; set; } = new List<Vacancy>();
}
