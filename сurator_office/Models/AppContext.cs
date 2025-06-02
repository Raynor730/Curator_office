using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace сurator_office.Models;

public partial class AppContext : DbContext
{
    public AppContext()
    {
    }

    public AppContext(DbContextOptions<AppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CurrentStatement> CurrentStatements { get; set; }

    public virtual DbSet<CurrentStatementsStudent> CurrentStatementsStudents { get; set; }

    public virtual DbSet<Discipline> Disciplines { get; set; }

    public virtual DbSet<DisciplinesTeacher> DisciplinesTeachers { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<InterimStatement> InterimStatements { get; set; }

    public virtual DbSet<IntermediateAttestationStudent> IntermediateAttestationStudetns { get; set; }

    public virtual DbSet<RolesInGroup> RolesInGroups { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TypesIntermediateAttestation> TypesIntermediateAttestations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DataBase;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CurrentStatement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("current_statement_pkey");

            entity.ToTable("current_statements");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.IdDisciplinesTeachers).HasColumnName("id_disciplines_teachers");

            entity.HasOne(d => d.IdDisciplinesTeachersNavigation).WithMany(p => p.CurrentStatements)
                .HasForeignKey(d => d.IdDisciplinesTeachers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("current_statements_id_disciplines_teachers_fkey");
        });

        modelBuilder.Entity<CurrentStatementsStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("current_students_pkey");

            entity.ToTable("current_statements_students");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Estimation)
                .HasDefaultValueSql("nextval('current_students_estimation_seq'::regclass)")
                .HasColumnName("estimation");
            entity.Property(e => e.IdCurrentStatements).HasColumnName("id_current_statements");
            entity.Property(e => e.IdStudent).HasColumnName("id_student");

            entity.HasOne(d => d.IdCurrentStatementsNavigation).WithMany(p => p.CurrentStatementsStudents)
                .HasForeignKey(d => d.IdCurrentStatements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("current_statements_students_id_current_statements_fkey");

            entity.HasOne(d => d.IdStudentNavigation).WithMany(p => p.CurrentStatementsStudents)
                .HasForeignKey(d => d.IdStudent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("current_statements_students_id_student_fkey");
        });

        modelBuilder.Entity<Discipline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("disciplines_pkey");

            entity.ToTable("disciplines");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisciplineName).HasColumnName("discipline_name");
            entity.Property(e => e.Kode).HasColumnName("kode");
        });

        modelBuilder.Entity<DisciplinesTeacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("disciplines_teachers_pkey");

            entity.ToTable("disciplines_teachers");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdDiscipline).HasColumnName("id_discipline");
            entity.Property(e => e.IdTeacher).HasColumnName("id_teacher");
            entity.Property(e => e.Subgroup)
                .ValueGeneratedOnAdd()
                .HasColumnName("subgroup");

            entity.HasOne(d => d.IdDisciplineNavigation).WithMany(p => p.DisciplinesTeachers)
                .HasForeignKey(d => d.IdDiscipline)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("disciplines_teachers_id_discipline_fkey");

            entity.HasOne(d => d.IdTeacherNavigation).WithMany(p => p.DisciplinesTeachers)
                .HasForeignKey(d => d.IdTeacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("disciplines_teachers_id_teacher_fkey");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("groups_pkey");

            entity.ToTable("groups");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.SpecializationKode).HasColumnName("specialization_kode");
            entity.Property(e => e.SpecializationName).HasColumnName("specialization_name");
            entity.Property(e => e.YearOfAdmission)
                .ValueGeneratedOnAdd()
                .HasColumnName("year_of_admission");
            entity.Property(e => e.YearOfGraduation)
                .ValueGeneratedOnAdd()
                .HasColumnName("year_of_graduation");
        });

        modelBuilder.Entity<InterimStatement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("interim_statement_pkey");

            entity.ToTable("interim_statements");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.IdDisciplinesTeachers).HasColumnName("id_disciplines_teachers");
            entity.Property(e => e.IdTypeIntermediateAttestation).HasColumnName("id_type_intermediate_attestation");

            entity.HasOne(d => d.IdDisciplinesTeachersNavigation).WithMany(p => p.InterimStatements)
                .HasForeignKey(d => d.IdDisciplinesTeachers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("interim_statement_id_disciplines_teachers_fkey");

            entity.HasOne(d => d.IdTypeIntermediateAttestationNavigation).WithMany(p => p.InterimStatements)
                .HasForeignKey(d => d.IdTypeIntermediateAttestation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("interim_statement_id_type_intermediate_attestation_fkey");
        });

        modelBuilder.Entity<IntermediateAttestationStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("intermediate_attestation_studetns_pkey");

            entity.ToTable("intermediate_attestation_studetns");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DateOfRetake).HasColumnName("date_of_retake");
            entity.Property(e => e.Estimation)
                .ValueGeneratedOnAdd()
                .HasColumnName("estimation");
            entity.Property(e => e.IdInterimStatements).HasColumnName("id_interim_statements");
            entity.Property(e => e.IdStudent).HasColumnName("id_student");

            entity.HasOne(d => d.IdStudentNavigation).WithMany(p => p.IntermediateAttestationStudetns)
                .HasForeignKey(d => d.IdStudent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("intermediate_attestation_studetns_id_student_fkey");
        });

        modelBuilder.Entity<RolesInGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("role_in_group_pkey");

            entity.ToTable("roles_in_group");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('role_in_group_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Role).HasColumnName("role");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("students_pkey");

            entity.ToTable("students");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ActualAddress).HasColumnName("actual_address");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Excluded).HasColumnName("excluded");
            entity.Property(e => e.FullAge).HasColumnName("full_age");
            entity.Property(e => e.IdGroup)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_group");
            entity.Property(e => e.IdRole)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_role");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Patronymic).HasColumnName("patronymic");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.Subgroup)
                .ValueGeneratedOnAdd()
                .HasColumnName("subgroup");
            entity.Property(e => e.Surname).HasColumnName("surname");

            entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.IdGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("students_id_group_fkey");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("students_id_role_fkey");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teachers_pkey");

            entity.ToTable("teachers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name ");
            entity.Property(e => e.Patronymic).HasColumnName("patronymic");
            entity.Property(e => e.Surname).HasColumnName("surname");
        });

        modelBuilder.Entity<TypesIntermediateAttestation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("type_intermediate_attestation_pkey");

            entity.ToTable("types_intermediate_attestation");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('type_intermediate_attestation_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
