using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Service.DATA.Models;

public partial class KontraktnikDbContext : DbContext
{
    public KontraktnikDbContext()
    {
    }

    public KontraktnikDbContext(DbContextOptions<KontraktnikDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<ArmyDepartment> ArmyDepartments { get; set; }

    public virtual DbSet<ArmyRank> ArmyRanks { get; set; }

    public virtual DbSet<ArmyRegion> ArmyRegions { get; set; }

    public virtual DbSet<ArmyType> ArmyTypes { get; set; }

    public virtual DbSet<CategoryPosition> CategoryPositions { get; set; }

    public virtual DbSet<DigitalSign> DigitalSigns { get; set; }

    public virtual DbSet<DigitalSignAttribute> DigitalSignAttributes { get; set; }

    public virtual DbSet<DigitalSignBinary> DigitalSignBinaries { get; set; }

    public virtual DbSet<DigitalSignInfo> DigitalSignInfos { get; set; }

    public virtual DbSet<DriverLicense> DriverLicenses { get; set; }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<JobCategory> JobCategories { get; set; }

    public virtual DbSet<JobYear> JobYears { get; set; }

    public virtual DbSet<MedicalStatus> MedicalStatuses { get; set; }

    public virtual DbSet<PhoneNotification> PhoneNotifications { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<ProfileFile> ProfileFiles { get; set; }

    public virtual DbSet<Qualification> Qualifications { get; set; }

    public virtual DbSet<RankSalary> RankSalaries { get; set; }

    public virtual DbSet<Relative> Relatives { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SecretLevel> SecretLevels { get; set; }

    public virtual DbSet<ServiceYear> ServiceYears { get; set; }

    public virtual DbSet<Step> Steps { get; set; }

    public virtual DbSet<StepGroup> StepGroups { get; set; }

    public virtual DbSet<StepOrder> StepOrders { get; set; }

    public virtual DbSet<Survey> Surveys { get; set; }

    public virtual DbSet<SurveyDriver> SurveyDrivers { get; set; }

    public virtual DbSet<SurveyExecutor> SurveyExecutors { get; set; }

    public virtual DbSet<SurveyRelative> SurveyRelatives { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vacancy> Vacancies { get; set; }

    public virtual DbSet<VtSh> VtShes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=KontraktnikDB;Username=postgres;Password=22111964;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DigitalSign>(entity =>
        {
            entity.HasIndex(e => e.BinaryDataId, "IX_DigitalSigns_BinaryDataId");

            entity.HasIndex(e => e.InfoId, "IX_DigitalSigns_InfoId");

            entity.HasIndex(e => e.SignedUserId, "IX_DigitalSigns_SignedUserId");

            entity.HasIndex(e => e.StepId, "IX_DigitalSigns_StepId");

            entity.HasIndex(e => e.SurveyId, "IX_DigitalSigns_SurveyId");

            entity.HasOne(d => d.BinaryData).WithMany(p => p.DigitalSigns).HasForeignKey(d => d.BinaryDataId);

            entity.HasOne(d => d.Info).WithMany(p => p.DigitalSigns).HasForeignKey(d => d.InfoId);

            entity.HasOne(d => d.SignedUser).WithMany(p => p.DigitalSigns).HasForeignKey(d => d.SignedUserId);

            entity.HasOne(d => d.Step).WithMany(p => p.DigitalSigns).HasForeignKey(d => d.StepId);

            entity.HasOne(d => d.Survey).WithMany(p => p.DigitalSigns).HasForeignKey(d => d.SurveyId);
        });

        modelBuilder.Entity<JobYear>(entity =>
        {
            entity.HasIndex(e => e.JobCategoryId, "IX_JobYears_JobCategoryId");

            entity.HasIndex(e => e.ServiceYearId, "IX_JobYears_ServiceYearId");

            entity.HasOne(d => d.JobCategory).WithMany(p => p.JobYears).HasForeignKey(d => d.JobCategoryId);

            entity.HasOne(d => d.ServiceYear).WithMany(p => p.JobYears).HasForeignKey(d => d.ServiceYearId);
        });

        modelBuilder.Entity<PhoneNotification>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_PhoneNotifications_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.PhoneNotifications).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasIndex(e => e.ArmyTypeId, "IX_Positions_ArmyTypeId");

            entity.HasIndex(e => e.CategoryPositionId, "IX_Positions_CategoryPositionId");

            entity.HasIndex(e => e.JobCategoryId, "IX_Positions_JobCategoryId");

            entity.HasIndex(e => e.SecretLevelId, "IX_Positions_SecretLevelId");

            entity.HasOne(d => d.ArmyType).WithMany(p => p.Positions).HasForeignKey(d => d.ArmyTypeId);

            entity.HasOne(d => d.CategoryPosition).WithMany(p => p.Positions).HasForeignKey(d => d.CategoryPositionId);

            entity.HasOne(d => d.JobCategory).WithMany(p => p.Positions).HasForeignKey(d => d.JobCategoryId);

            entity.HasOne(d => d.SecretLevel).WithMany(p => p.Positions).HasForeignKey(d => d.SecretLevelId);
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasIndex(e => e.AreaId, "IX_Profiles_AreaId");

            entity.HasIndex(e => e.ConfirmedUserId, "IX_Profiles_ConfirmedUserId");

            entity.HasIndex(e => e.RequestedUserId, "IX_Profiles_RequestedUserId");

            entity.HasIndex(e => e.StepGroupId, "IX_Profiles_StepGroupId");

            entity.HasIndex(e => e.StepId, "IX_Profiles_StepId");

            entity.HasIndex(e => e.SurveyId, "IX_Profiles_SurveyId");

            entity.Property(e => e.ConfirmedSign).HasColumnName("ConfirmedSIGN");
            entity.Property(e => e.ConfirmedUserIin).HasColumnName("ConfirmedUserIIN");
            entity.Property(e => e.RequestedSign).HasColumnName("RequestedSIGN");
            entity.Property(e => e.RequestedUserIin).HasColumnName("RequestedUserIIN");

            entity.HasOne(d => d.Area).WithMany(p => p.Profiles).HasForeignKey(d => d.AreaId);

            entity.HasOne(d => d.ConfirmedUser).WithMany(p => p.ProfileConfirmedUsers).HasForeignKey(d => d.ConfirmedUserId);

            entity.HasOne(d => d.RequestedUser).WithMany(p => p.ProfileRequestedUsers).HasForeignKey(d => d.RequestedUserId);

            entity.HasOne(d => d.StepGroup).WithMany(p => p.Profiles).HasForeignKey(d => d.StepGroupId);

            entity.HasOne(d => d.Step).WithMany(p => p.Profiles).HasForeignKey(d => d.StepId);

            entity.HasOne(d => d.Survey).WithMany(p => p.Profiles).HasForeignKey(d => d.SurveyId);
        });

        modelBuilder.Entity<ProfileFile>(entity =>
        {
            entity.HasIndex(e => e.ProfileId, "IX_ProfileFiles_ProfileId");

            entity.HasIndex(e => e.UserId, "IX_ProfileFiles_UserId");

            entity.Property(e => e.IsConfirmated).HasColumnName("isConfirmated");
            entity.Property(e => e.IsRequested).HasColumnName("isRequested");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileFiles).HasForeignKey(d => d.ProfileId);

            entity.HasOne(d => d.User).WithMany(p => p.ProfileFiles).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<RankSalary>(entity =>
        {
            entity.HasIndex(e => e.ArmyRankId, "IX_RankSalaries_ArmyRankId");

            entity.HasOne(d => d.ArmyRank).WithMany(p => p.RankSalaries).HasForeignKey(d => d.ArmyRankId);
        });

        modelBuilder.Entity<Step>(entity =>
        {
            entity.HasIndex(e => e.ConfirmedRoleId, "IX_Steps_ConfirmedRoleId");

            entity.HasIndex(e => e.RequestedRoleId, "IX_Steps_RequestedRoleId");

            entity.HasIndex(e => e.StepGroupId, "IX_Steps_StepGroupId");

            entity.HasOne(d => d.ConfirmedRole).WithMany(p => p.StepConfirmedRoles).HasForeignKey(d => d.ConfirmedRoleId);

            entity.HasOne(d => d.RequestedRole).WithMany(p => p.StepRequestedRoles).HasForeignKey(d => d.RequestedRoleId);

            entity.HasOne(d => d.StepGroup).WithMany(p => p.Steps).HasForeignKey(d => d.StepGroupId);
        });

        modelBuilder.Entity<StepOrder>(entity =>
        {
            entity.HasIndex(e => e.NextStepId, "IX_StepOrders_NextStepId");

            entity.HasIndex(e => e.PreviousStepId, "IX_StepOrders_PreviousStepId");

            entity.HasIndex(e => e.StepId, "IX_StepOrders_StepId");

            entity.HasOne(d => d.NextStep).WithMany(p => p.StepOrderNextSteps).HasForeignKey(d => d.NextStepId);

            entity.HasOne(d => d.PreviousStep).WithMany(p => p.StepOrderPreviousSteps).HasForeignKey(d => d.PreviousStepId);

            entity.HasOne(d => d.Step).WithMany(p => p.StepOrderSteps).HasForeignKey(d => d.StepId);
        });

        modelBuilder.Entity<Survey>(entity =>
        {
            entity.HasIndex(e => e.AreaId, "IX_Surveys_AreaId");

            entity.HasIndex(e => e.ArmyRankId, "IX_Surveys_ArmyRankId");

            entity.HasIndex(e => e.BirthAreaId, "IX_Surveys_BirthAreaId");

            entity.HasIndex(e => e.CurrentStepId, "IX_Surveys_CurrentStepId");

            entity.HasIndex(e => e.EducationId, "IX_Surveys_EducationId");

            entity.HasIndex(e => e.MedicalStatusId, "IX_Surveys_MedicalStatusId");

            entity.HasIndex(e => e.PositionId, "IX_Surveys_PositionId");

            entity.HasIndex(e => e.StepGroupId, "IX_Surveys_StepGroupId");

            entity.HasIndex(e => e.UserId, "IX_Surveys_UserId");

            entity.HasIndex(e => e.VtshId, "IX_Surveys_VTShId");

            entity.HasIndex(e => e.VacancyId, "IX_Surveys_VacancyId");

            entity.Property(e => e.Iin).HasColumnName("IIN");
            entity.Property(e => e.VtshId).HasColumnName("VTShId");
            entity.Property(e => e.VtshServed).HasColumnName("VTShServed");
            entity.Property(e => e.VtshYear).HasColumnName("VTShYear");

            entity.HasOne(d => d.Area).WithMany(p => p.SurveyAreas).HasForeignKey(d => d.AreaId);

            entity.HasOne(d => d.ArmyRank).WithMany(p => p.Surveys).HasForeignKey(d => d.ArmyRankId);

            entity.HasOne(d => d.BirthArea).WithMany(p => p.SurveyBirthAreas).HasForeignKey(d => d.BirthAreaId);

            entity.HasOne(d => d.CurrentStep).WithMany(p => p.Surveys).HasForeignKey(d => d.CurrentStepId);

            entity.HasOne(d => d.Education).WithMany(p => p.Surveys).HasForeignKey(d => d.EducationId);

            entity.HasOne(d => d.MedicalStatus).WithMany(p => p.Surveys).HasForeignKey(d => d.MedicalStatusId);

            entity.HasOne(d => d.Position).WithMany(p => p.Surveys).HasForeignKey(d => d.PositionId);

            entity.HasOne(d => d.StepGroup).WithMany(p => p.Surveys).HasForeignKey(d => d.StepGroupId);

            entity.HasOne(d => d.User).WithMany(p => p.Surveys).HasForeignKey(d => d.UserId);

            entity.HasOne(d => d.Vacancy).WithMany(p => p.Surveys).HasForeignKey(d => d.VacancyId);

            entity.HasOne(d => d.Vtsh).WithMany(p => p.Surveys).HasForeignKey(d => d.VtshId);
        });

        modelBuilder.Entity<SurveyDriver>(entity =>
        {
            entity.HasIndex(e => e.DriverLicenseId, "IX_SurveyDrivers_DriverLicenseId");

            entity.HasIndex(e => e.SurveyId, "IX_SurveyDrivers_SurveyId");

            entity.HasOne(d => d.DriverLicense).WithMany(p => p.SurveyDrivers).HasForeignKey(d => d.DriverLicenseId);

            entity.HasOne(d => d.Survey).WithMany(p => p.SurveyDrivers).HasForeignKey(d => d.SurveyId);
        });

        modelBuilder.Entity<SurveyExecutor>(entity =>
        {
            entity.HasIndex(e => e.DirectorId, "IX_SurveyExecutors_DirectorId");

            entity.HasIndex(e => e.ExecutorId, "IX_SurveyExecutors_ExecutorId");

            entity.HasIndex(e => e.SurveyId, "IX_SurveyExecutors_SurveyId").IsUnique();

            entity.HasOne(d => d.Director).WithMany(p => p.SurveyExecutorDirectors).HasForeignKey(d => d.DirectorId);

            entity.HasOne(d => d.Executor).WithMany(p => p.SurveyExecutorExecutors).HasForeignKey(d => d.ExecutorId);

            entity.HasOne(d => d.Survey).WithOne(p => p.SurveyExecutor).HasForeignKey<SurveyExecutor>(d => d.SurveyId);
        });

        modelBuilder.Entity<SurveyRelative>(entity =>
        {
            entity.HasIndex(e => e.RelativeId, "IX_SurveyRelatives_RelativeId");

            entity.HasIndex(e => e.SurveyId, "IX_SurveyRelatives_SurveyId");

            entity.Property(e => e.Iin).HasColumnName("IIN");

            entity.HasOne(d => d.Relative).WithMany(p => p.SurveyRelatives).HasForeignKey(d => d.RelativeId);

            entity.HasOne(d => d.Survey).WithMany(p => p.SurveyRelatives).HasForeignKey(d => d.SurveyId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.AreaId, "IX_Users_AreaId");

            entity.HasIndex(e => e.RoleId, "IX_Users_RoleId");

            entity.Property(e => e.Iin).HasColumnName("IIN");

            entity.HasOne(d => d.Area).WithMany(p => p.Users).HasForeignKey(d => d.AreaId);

            entity.HasOne(d => d.Role).WithMany(p => p.Users).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<Vacancy>(entity =>
        {
            entity.HasIndex(e => e.AreaId, "IX_Vacancies_AreaId");

            entity.HasIndex(e => e.ArmyRegionId, "IX_Vacancies_ArmyRegionId");

            entity.HasIndex(e => e.ArmyTypeId, "IX_Vacancies_ArmyTypeId");

            entity.HasIndex(e => e.AuthorId, "IX_Vacancies_AuthorId");

            entity.HasIndex(e => e.JobCategoryId, "IX_Vacancies_JobCategoryId");

            entity.HasIndex(e => e.PositionId, "IX_Vacancies_PositionId");

            entity.HasIndex(e => e.QualificationId, "IX_Vacancies_QualificationId");

            entity.HasIndex(e => e.SecretLevelId, "IX_Vacancies_SecretLevelId");

            entity.HasOne(d => d.Area).WithMany(p => p.Vacancies).HasForeignKey(d => d.AreaId);

            entity.HasOne(d => d.ArmyRegion).WithMany(p => p.Vacancies).HasForeignKey(d => d.ArmyRegionId);

            entity.HasOne(d => d.ArmyType).WithMany(p => p.Vacancies).HasForeignKey(d => d.ArmyTypeId);

            entity.HasOne(d => d.Author).WithMany(p => p.Vacancies).HasForeignKey(d => d.AuthorId);

            entity.HasOne(d => d.JobCategory).WithMany(p => p.Vacancies).HasForeignKey(d => d.JobCategoryId);

            entity.HasOne(d => d.Position).WithMany(p => p.Vacancies).HasForeignKey(d => d.PositionId);

            entity.HasOne(d => d.Qualification).WithMany(p => p.Vacancies).HasForeignKey(d => d.QualificationId);

            entity.HasOne(d => d.SecretLevel).WithMany(p => p.Vacancies).HasForeignKey(d => d.SecretLevelId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
