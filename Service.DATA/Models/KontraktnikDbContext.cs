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

    public virtual DbSet<Aggregatedcounter> Aggregatedcounters { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<ArmyDepartment> ArmyDepartments { get; set; }

    public virtual DbSet<ArmyRank> ArmyRanks { get; set; }

    public virtual DbSet<ArmyRegion> ArmyRegions { get; set; }

    public virtual DbSet<ArmyType> ArmyTypes { get; set; }

    public virtual DbSet<CategoryPosition> CategoryPositions { get; set; }

    public virtual DbSet<Counter> Counters { get; set; }

    public virtual DbSet<DigitalDocument> DigitalDocuments { get; set; }

    public virtual DbSet<DigitalSign> DigitalSigns { get; set; }

    public virtual DbSet<DigitalSignAttribute> DigitalSignAttributes { get; set; }

    public virtual DbSet<DigitalSignBinary> DigitalSignBinaries { get; set; }

    public virtual DbSet<DigitalSignInfo> DigitalSignInfos { get; set; }

    public virtual DbSet<DriverLicense> DriverLicenses { get; set; }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<GbdflBirthPlace> GbdflBirthPlaces { get; set; }

    public virtual DbSet<GbdflDocument> GbdflDocuments { get; set; }

    public virtual DbSet<GbdflPersonInfo> GbdflPersonInfos { get; set; }

    public virtual DbSet<GbdflRegAddress> GbdflRegAddresses { get; set; }

    public virtual DbSet<Hash> Hashes { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobCategory> JobCategories { get; set; }

    public virtual DbSet<JobYear> JobYears { get; set; }

    public virtual DbSet<Jobparameter> Jobparameters { get; set; }

    public virtual DbSet<Jobqueue> Jobqueues { get; set; }

    public virtual DbSet<Kdptoken> Kdptokens { get; set; }

    public virtual DbSet<List> Lists { get; set; }

    public virtual DbSet<Lock> Locks { get; set; }

    public virtual DbSet<MedicalStatus> MedicalStatuses { get; set; }

    public virtual DbSet<MoIshasmrEnbekDatum> MoIshasmrEnbekData { get; set; }

    public virtual DbSet<PhoneNotification> PhoneNotifications { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<ProfileFile> ProfileFiles { get; set; }

    public virtual DbSet<Qualification> Qualifications { get; set; }

    public virtual DbSet<RankSalary> RankSalaries { get; set; }

    public virtual DbSet<RdbDatum> RdbData { get; set; }

    public virtual DbSet<Relative> Relatives { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Schema> Schemas { get; set; }

    public virtual DbSet<SecretLevel> SecretLevels { get; set; }

    public virtual DbSet<Server> Servers { get; set; }

    public virtual DbSet<ServiceYear> ServiceYears { get; set; }

    public virtual DbSet<Set> Sets { get; set; }

    public virtual DbSet<State> States { get; set; }

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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=KontraktnikDB;Username=postgres;Password=22111964;");
        //=> optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=jauynger_db;Username=postgres;Password=passw0rd13!;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aggregatedcounter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("aggregatedcounter_pkey");

            entity.ToTable("aggregatedcounter", "hangfire");

            entity.HasIndex(e => e.Key, "aggregatedcounter_key_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Expireat).HasColumnName("expireat");
            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("counter_pkey");

            entity.ToTable("counter", "hangfire");

            entity.HasIndex(e => e.Expireat, "ix_hangfire_counter_expireat");

            entity.HasIndex(e => e.Key, "ix_hangfire_counter_key");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Expireat).HasColumnName("expireat");
            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<DigitalDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("digitaldocuments_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("nextval('digitaldocuments_id_seq'::regclass)");

            entity.HasOne(d => d.Survey).WithMany(p => p.DigitalDocuments)
                .HasForeignKey(d => d.SurveyId)
                .HasConstraintName("digitaldocuments_surveyid_fkey");
        });

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

        modelBuilder.Entity<GbdflBirthPlace>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("GBDFL_BirthPlace_pkey");

            entity.ToTable("GBDFL_BirthPlace");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Countrychangedate).HasColumnName("countrychangedate");
            entity.Property(e => e.Countrycode).HasColumnName("countrycode");
            entity.Property(e => e.Countrynamekz).HasColumnName("countrynamekz");
            entity.Property(e => e.Countrynameru).HasColumnName("countrynameru");
            entity.Property(e => e.Districtchangedate).HasColumnName("districtchangedate");
            entity.Property(e => e.Districtcode).HasColumnName("districtcode");
            entity.Property(e => e.Districtnamekz).HasColumnName("districtnamekz");
            entity.Property(e => e.Districtnameru).HasColumnName("districtnameru");
            entity.Property(e => e.Regionchangedate).HasColumnName("regionchangedate");
            entity.Property(e => e.Regioncode).HasColumnName("regioncode");
            entity.Property(e => e.Regionnamekz).HasColumnName("regionnamekz");
            entity.Property(e => e.Regionnameru).HasColumnName("regionnameru");
        });

        modelBuilder.Entity<GbdflDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("GBDFL_Documents_pkey");

            entity.ToTable("GBDFL_Documents");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Begindate).HasColumnName("begindate");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.Issueorganizationcode).HasColumnName("issueorganizationcode");
            entity.Property(e => e.Issueorganizationcodechangedate).HasColumnName("issueorganizationcodechangedate");
            entity.Property(e => e.Issueorganizationcodenamekz).HasColumnName("issueorganizationcodenamekz");
            entity.Property(e => e.Issueorganizationcodenameru).HasColumnName("issueorganizationcodenameru");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.Patronymic).HasColumnName("patronymic");
            entity.Property(e => e.Statuschangedate).HasColumnName("statuschangedate");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.Statusnamekz).HasColumnName("statusnamekz");
            entity.Property(e => e.Statusnameru).HasColumnName("statusnameru");
            entity.Property(e => e.Surname).HasColumnName("surname");
            entity.Property(e => e.Typechangedate).HasColumnName("typechangedate");
            entity.Property(e => e.Typecode).HasColumnName("typecode");
            entity.Property(e => e.Typenamekz).HasColumnName("typenamekz");
            entity.Property(e => e.Typenameru).HasColumnName("typenameru");
        });

        modelBuilder.Entity<GbdflPersonInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("GBDFL_PersonInfo_pkey");

            entity.ToTable("GBDFL_PersonInfo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.Birthplaceid).HasColumnName("birthplaceid");
            entity.Property(e => e.Citizenshipchangedate).HasColumnName("citizenshipchangedate");
            entity.Property(e => e.Citizenshipcode).HasColumnName("citizenshipcode");
            entity.Property(e => e.Citizenshipnamekz).HasColumnName("citizenshipnamekz");
            entity.Property(e => e.Citizenshipnameru).HasColumnName("citizenshipnameru");
            entity.Property(e => e.Documentsid).HasColumnName("documentsid");
            entity.Property(e => e.Genderchangedate).HasColumnName("genderchangedate");
            entity.Property(e => e.Gendercode).HasColumnName("gendercode");
            entity.Property(e => e.Gendernamekz).HasColumnName("gendernamekz");
            entity.Property(e => e.Gendernameru).HasColumnName("gendernameru");
            entity.Property(e => e.Iin).HasColumnName("iin");
            entity.Property(e => e.Lifestatuschangedate).HasColumnName("lifestatuschangedate");
            entity.Property(e => e.Lifestatuscode).HasColumnName("lifestatuscode");
            entity.Property(e => e.Lifestatusnamekz).HasColumnName("lifestatusnamekz");
            entity.Property(e => e.Lifestatusnameru).HasColumnName("lifestatusnameru");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Nationalitychangedate).HasColumnName("nationalitychangedate");
            entity.Property(e => e.Nationalitycode).HasColumnName("nationalitycode");
            entity.Property(e => e.Nationalitynamekz).HasColumnName("nationalitynamekz");
            entity.Property(e => e.Nationalitynameru).HasColumnName("nationalitynameru");
            entity.Property(e => e.Patronymic).HasColumnName("patronymic");
            entity.Property(e => e.Regaddressid).HasColumnName("regaddressid");
            entity.Property(e => e.Surname).HasColumnName("surname");
            entity.Property(e => e.Surveyid).HasColumnName("surveyid");

            entity.HasOne(d => d.Birthplace).WithMany(p => p.GbdflPersonInfos)
                .HasForeignKey(d => d.Birthplaceid)
                .HasConstraintName("GBDFL_PersonInfo_birthplaceid_fkey");

            entity.HasOne(d => d.Documents).WithMany(p => p.GbdflPersonInfos)
                .HasForeignKey(d => d.Documentsid)
                .HasConstraintName("GBDFL_PersonInfo_documentsid_fkey");

            entity.HasOne(d => d.Regaddress).WithMany(p => p.GbdflPersonInfos)
                .HasForeignKey(d => d.Regaddressid)
                .HasConstraintName("GBDFL_PersonInfo_regaddressid_fkey");

            entity.HasOne(d => d.Survey).WithMany(p => p.GbdflPersonInfos)
                .HasForeignKey(d => d.Surveyid)
                .HasConstraintName("GBDFL_PersonInfo_surveyid_fkey");
        });

        modelBuilder.Entity<GbdflRegAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("GBDFL_RegAddress_pkey");

            entity.ToTable("GBDFL_RegAddress");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Arcode).HasColumnName("arcode");
            entity.Property(e => e.Begindate).HasColumnName("begindate");
            entity.Property(e => e.Building).HasColumnName("building");
            entity.Property(e => e.Countrychangedate).HasColumnName("countrychangedate");
            entity.Property(e => e.Countrycode).HasColumnName("countrycode");
            entity.Property(e => e.Countrynamekz).HasColumnName("countrynamekz");
            entity.Property(e => e.Countrynameru).HasColumnName("countrynameru");
            entity.Property(e => e.Districtchangedate).HasColumnName("districtchangedate");
            entity.Property(e => e.Districtcode).HasColumnName("districtcode");
            entity.Property(e => e.Districtnamekz).HasColumnName("districtnamekz");
            entity.Property(e => e.Districtnameru).HasColumnName("districtnameru");
            entity.Property(e => e.Invaliditychangedate).HasColumnName("invaliditychangedate");
            entity.Property(e => e.Invaliditycode).HasColumnName("invaliditycode");
            entity.Property(e => e.Invaliditynamekz).HasColumnName("invaliditynamekz");
            entity.Property(e => e.Invaliditynameru).HasColumnName("invaliditynameru");
            entity.Property(e => e.Regionchangedate).HasColumnName("regionchangedate");
            entity.Property(e => e.Regioncode).HasColumnName("regioncode");
            entity.Property(e => e.Regionnamekz).HasColumnName("regionnamekz");
            entity.Property(e => e.Regionnameru).HasColumnName("regionnameru");
            entity.Property(e => e.Statuschangedate).HasColumnName("statuschangedate");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.Statusnamekz).HasColumnName("statusnamekz");
            entity.Property(e => e.Statusnameru).HasColumnName("statusnameru");
            entity.Property(e => e.Street).HasColumnName("street");
        });

        modelBuilder.Entity<Hash>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hash_pkey");

            entity.ToTable("hash", "hangfire");

            entity.HasIndex(e => new { e.Key, e.Field }, "hash_key_field_key").IsUnique();

            entity.HasIndex(e => e.Expireat, "ix_hangfire_hash_expireat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Expireat).HasColumnName("expireat");
            entity.Property(e => e.Field).HasColumnName("field");
            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.Updatecount).HasColumnName("updatecount");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("job_pkey");

            entity.ToTable("job", "hangfire");

            entity.HasIndex(e => e.Expireat, "ix_hangfire_job_expireat");

            entity.HasIndex(e => e.Statename, "ix_hangfire_job_statename");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Arguments)
                .HasColumnType("jsonb")
                .HasColumnName("arguments");
            entity.Property(e => e.Createdat).HasColumnName("createdat");
            entity.Property(e => e.Expireat).HasColumnName("expireat");
            entity.Property(e => e.Invocationdata)
                .HasColumnType("jsonb")
                .HasColumnName("invocationdata");
            entity.Property(e => e.Stateid).HasColumnName("stateid");
            entity.Property(e => e.Statename).HasColumnName("statename");
            entity.Property(e => e.Updatecount).HasColumnName("updatecount");
        });

        modelBuilder.Entity<JobYear>(entity =>
        {
            entity.HasIndex(e => e.JobCategoryId, "IX_JobYears_JobCategoryId");

            entity.HasIndex(e => e.ServiceYearId, "IX_JobYears_ServiceYearId");

            entity.HasOne(d => d.JobCategory).WithMany(p => p.JobYears).HasForeignKey(d => d.JobCategoryId);

            entity.HasOne(d => d.ServiceYear).WithMany(p => p.JobYears).HasForeignKey(d => d.ServiceYearId);
        });

        modelBuilder.Entity<Jobparameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("jobparameter_pkey");

            entity.ToTable("jobparameter", "hangfire");

            entity.HasIndex(e => new { e.Jobid, e.Name }, "ix_hangfire_jobparameter_jobidandname");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Jobid).HasColumnName("jobid");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Updatecount).HasColumnName("updatecount");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.Job).WithMany(p => p.Jobparameters)
                .HasForeignKey(d => d.Jobid)
                .HasConstraintName("jobparameter_jobid_fkey");
        });

        modelBuilder.Entity<Jobqueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("jobqueue_pkey");

            entity.ToTable("jobqueue", "hangfire");

            entity.HasIndex(e => new { e.Jobid, e.Queue }, "ix_hangfire_jobqueue_jobidandqueue");

            entity.HasIndex(e => new { e.Queue, e.Fetchedat }, "ix_hangfire_jobqueue_queueandfetchedat");

            entity.HasIndex(e => new { e.Queue, e.Fetchedat, e.Jobid }, "jobqueue_queue_fetchat_jobid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fetchedat).HasColumnName("fetchedat");
            entity.Property(e => e.Jobid).HasColumnName("jobid");
            entity.Property(e => e.Queue).HasColumnName("queue");
            entity.Property(e => e.Updatecount).HasColumnName("updatecount");
        });

        modelBuilder.Entity<Kdptoken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("kdptokens_pkey");

            entity.ToTable("KDPTokens");

            entity.Property(e => e.Id).HasDefaultValueSql("nextval('kdptokens_id_seq'::regclass)");

            entity.HasOne(d => d.Survey).WithMany(p => p.Kdptokens)
                .HasForeignKey(d => d.SurveyId)
                .HasConstraintName("kdptokens_surveyid_fkey");
        });

        modelBuilder.Entity<List>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("list_pkey");

            entity.ToTable("list", "hangfire");

            entity.HasIndex(e => e.Expireat, "ix_hangfire_list_expireat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Expireat).HasColumnName("expireat");
            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.Updatecount).HasColumnName("updatecount");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Lock>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lock", "hangfire");

            entity.HasIndex(e => e.Resource, "lock_resource_key").IsUnique();

            entity.Property(e => e.Acquired).HasColumnName("acquired");
            entity.Property(e => e.Resource).HasColumnName("resource");
            entity.Property(e => e.Updatecount).HasColumnName("updatecount");
        });

        modelBuilder.Entity<MoIshasmrEnbekDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("MO_ISHASMR_ENBEK_Data_pkey");

            entity.ToTable("MO_ISHASMR_ENBEK_Data");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.Commentkz).HasColumnName("commentkz");
            entity.Property(e => e.Commentru).HasColumnName("commentru");
            entity.Property(e => e.Firstname).HasColumnName("firstname");
            entity.Property(e => e.Iin).HasColumnName("iin");
            entity.Property(e => e.Lastname).HasColumnName("lastname");
            entity.Property(e => e.Patronymic).HasColumnName("patronymic");
            entity.Property(e => e.Requestdate).HasColumnName("requestdate");
            entity.Property(e => e.Requestnumber).HasColumnName("requestnumber");
            entity.Property(e => e.Responsedate).HasColumnName("responsedate");
            entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            entity.Property(e => e.Statusnamekz).HasColumnName("statusnamekz");
            entity.Property(e => e.Statusnameru).HasColumnName("statusnameru");
            entity.Property(e => e.Surveyid).HasColumnName("surveyid");

            entity.HasOne(d => d.Survey).WithMany(p => p.MoIshasmrEnbekData)
                .HasForeignKey(d => d.Surveyid)
                .HasConstraintName("MO_ISHASMR_ENBEK_Data_surveyid_fkey");
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

        modelBuilder.Entity<RdbDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("RDB_Data_pkey");

            entity.ToTable("RDB_Data");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.Firstname).HasColumnName("firstname");
            entity.Property(e => e.Iin).HasColumnName("iin");
            entity.Property(e => e.Lastname).HasColumnName("lastname");
            entity.Property(e => e.Messagenarcologykz).HasColumnName("messagenarcologykz");
            entity.Property(e => e.Messagenarcologyru).HasColumnName("messagenarcologyru");
            entity.Property(e => e.Messagepsychokz).HasColumnName("messagepsychokz");
            entity.Property(e => e.Messagepsychoru).HasColumnName("messagepsychoru");
            entity.Property(e => e.Messagetuberculosiskz).HasColumnName("messagetuberculosiskz");
            entity.Property(e => e.Messagetuberculosisru).HasColumnName("messagetuberculosisru");
            entity.Property(e => e.Messagevenereologicalkz).HasColumnName("messagevenereologicalkz");
            entity.Property(e => e.Messagevenereologicalru).HasColumnName("messagevenereologicalru");
            entity.Property(e => e.Secondname).HasColumnName("secondname");
            entity.Property(e => e.Surveyid).HasColumnName("surveyid");

            entity.HasOne(d => d.Survey).WithMany(p => p.RdbData)
                .HasForeignKey(d => d.Surveyid)
                .HasConstraintName("RDB_Data_surveyid_fkey");
        });

        modelBuilder.Entity<Schema>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("schema_pkey");

            entity.ToTable("schema", "hangfire");

            entity.Property(e => e.Version)
                .ValueGeneratedNever()
                .HasColumnName("version");
        });

        modelBuilder.Entity<Server>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("server_pkey");

            entity.ToTable("server", "hangfire");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasColumnType("jsonb")
                .HasColumnName("data");
            entity.Property(e => e.Lastheartbeat).HasColumnName("lastheartbeat");
            entity.Property(e => e.Updatecount).HasColumnName("updatecount");
        });

        modelBuilder.Entity<Set>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("set_pkey");

            entity.ToTable("set", "hangfire");

            entity.HasIndex(e => e.Expireat, "ix_hangfire_set_expireat");

            entity.HasIndex(e => new { e.Key, e.Score }, "ix_hangfire_set_key_score");

            entity.HasIndex(e => new { e.Key, e.Value }, "set_key_value_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Expireat).HasColumnName("expireat");
            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Updatecount).HasColumnName("updatecount");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("state_pkey");

            entity.ToTable("state", "hangfire");

            entity.HasIndex(e => e.Jobid, "ix_hangfire_state_jobid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdat).HasColumnName("createdat");
            entity.Property(e => e.Data)
                .HasColumnType("jsonb")
                .HasColumnName("data");
            entity.Property(e => e.Jobid).HasColumnName("jobid");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Reason).HasColumnName("reason");
            entity.Property(e => e.Updatecount).HasColumnName("updatecount");

            entity.HasOne(d => d.Job).WithMany(p => p.States)
                .HasForeignKey(d => d.Jobid)
                .HasConstraintName("state_jobid_fkey");
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
