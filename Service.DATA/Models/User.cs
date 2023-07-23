using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class User
{
    public long Id { get; set; }

    public long RoleId { get; set; }

    public long? AreaId { get; set; }

    public string? ImageUrl { get; set; }

    public string Iin { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string? Patronymic { get; set; }

    public string FullName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool Verified { get; set; }

    public bool Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Area? Area { get; set; }

    public virtual ICollection<DigitalSign> DigitalSigns { get; set; } = new List<DigitalSign>();

    public virtual ICollection<PhoneNotification> PhoneNotifications { get; set; } = new List<PhoneNotification>();

    public virtual ICollection<Profile> ProfileConfirmedUsers { get; set; } = new List<Profile>();

    public virtual ICollection<ProfileFile> ProfileFiles { get; set; } = new List<ProfileFile>();

    public virtual ICollection<Profile> ProfileRequestedUsers { get; set; } = new List<Profile>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<SurveyExecutor> SurveyExecutorDirectors { get; set; } = new List<SurveyExecutor>();

    public virtual ICollection<SurveyExecutor> SurveyExecutorExecutors { get; set; } = new List<SurveyExecutor>();

    public virtual ICollection<Survey> Surveys { get; set; } = new List<Survey>();

    public virtual ICollection<Vacancy> Vacancies { get; set; } = new List<Vacancy>();
}
