using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace E_Learning_System_2._0.Models;

public partial class ELearnDbContext : DbContext
{
    public ELearnDbContext()
    {
    }

    public ELearnDbContext(DbContextOptions<ELearnDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chapter> Chapters { get; set; }

    public virtual DbSet<GradeChapterUser> GradeChapterUsers { get; set; }

    public virtual DbSet<Speciality> Specialities { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=E-Learn_DB; Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chapter>(entity =>
        {
            entity.HasKey(e => e.IdChapter);

            entity.ToTable("chapters");

            entity.Property(e => e.IdChapter)
                .ValueGeneratedNever()
                .HasColumnName("idChapter");
            entity.Property(e => e.Speciality).HasColumnName("speciality");
            entity.Property(e => e.Title)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("title");

            entity.HasOne(d => d.SpecialityNavigation).WithMany(p => p.Chapters)
                .HasForeignKey(d => d.Speciality)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_chapters_specialities");
        });

        modelBuilder.Entity<GradeChapterUser>(entity =>
        {
            entity.HasKey(e => new { e.UsernameUsers, e.IdChapters });

            entity.ToTable("grade_chapter_users");

            entity.Property(e => e.UsernameUsers)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("username_users");
            entity.Property(e => e.IdChapters).HasColumnName("id_chapters");
            entity.Property(e => e.Grade).HasColumnName("grade");

            entity.HasOne(d => d.IdChaptersNavigation).WithMany(p => p.GradeChapterUsers)
                .HasForeignKey(d => d.IdChapters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_grade_chapter_users_chapters");

            entity.HasOne(d => d.UsernameUsersNavigation).WithMany(p => p.GradeChapterUsers)
                .HasForeignKey(d => d.UsernameUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_grade_chapter_users_users");
        });

        modelBuilder.Entity<Speciality>(entity =>
        {
            entity.HasKey(e => e.IdSpeciality);

            entity.ToTable("specialities");

            entity.Property(e => e.IdSpeciality)
                .ValueGeneratedNever()
                .HasColumnName("idSpeciality");
            entity.Property(e => e.Title)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.RegistrationNumber);

            entity.ToTable("students");

            entity.Property(e => e.RegistrationNumber).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.Username)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_students_users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Username);

            /*entity.ToTable("users");*/

            entity.Property(e => e.Username)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("username");
            entity.Property(e => e.Password)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
