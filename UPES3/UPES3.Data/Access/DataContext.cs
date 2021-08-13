using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UPES3.Data.Access
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<classityType> classityTypes { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<detailStatement> detailStatements { get; set; }
        public virtual DbSet<fileClassity> fileClassities { get; set; }
        public virtual DbSet<HistoryApproval> HistoryApprovals { get; set; }
        public virtual DbSet<lecturer> lecturers { get; set; }
        public virtual DbSet<notification> notifications { get; set; }
        public virtual DbSet<progressProject> progressProjects { get; set; }
        public virtual DbSet<projectOfLecturer> projectOfLecturers { get; set; }
        public virtual DbSet<projectOfStudent> projectOfStudents { get; set; }
        public virtual DbSet<request> requests { get; set; }
        public virtual DbSet<statement> statements { get; set; }
        public virtual DbSet<type> types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<account>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<account>()
                .Property(e => e.passWord)
                .IsUnicode(false);

            modelBuilder.Entity<classityType>()
                .Property(e => e.idClassity)
                .IsUnicode(false);

            modelBuilder.Entity<classityType>()
                .Property(e => e.idType)
                .IsUnicode(false);

            modelBuilder.Entity<department>()
                .Property(e => e.idDepartment)
                .IsUnicode(false);

            modelBuilder.Entity<department>()
                .Property(e => e.nameDepartment)
                .IsUnicode(false);

            modelBuilder.Entity<detailStatement>()
                .Property(e => e.idProject)
                .IsUnicode(false);

            modelBuilder.Entity<HistoryApproval>()
                .Property(e => e.idProject)
                .IsUnicode(false);

            modelBuilder.Entity<lecturer>()
                .Property(e => e.idLecturer)
                .IsUnicode(false);

            modelBuilder.Entity<lecturer>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<lecturer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<lecturer>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<lecturer>()
                .Property(e => e.idDepartment)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.metaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<progressProject>()
                .Property(e => e.idProject)
                .IsUnicode(false);

            modelBuilder.Entity<projectOfLecturer>()
                .Property(e => e.idProject)
                .IsUnicode(false);

            modelBuilder.Entity<projectOfLecturer>()
                .Property(e => e.idLecturer)
                .IsUnicode(false);

            modelBuilder.Entity<projectOfLecturer>()
                .Property(e => e.idClassity)
                .IsUnicode(false);

            modelBuilder.Entity<projectOfLecturer>()
                .HasMany(e => e.requests)
                .WithRequired(e => e.projectOfLecturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<projectOfStudent>()
                .Property(e => e.idProject)
                .IsUnicode(false);

            modelBuilder.Entity<projectOfStudent>()
                .Property(e => e.idStudent)
                .IsUnicode(false);

            modelBuilder.Entity<projectOfStudent>()
                .Property(e => e.idDepartment)
                .IsUnicode(false);

            modelBuilder.Entity<projectOfStudent>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<projectOfStudent>()
                .Property(e => e.idClassity)
                .IsUnicode(false);

            modelBuilder.Entity<request>()
                .Property(e => e.idProject)
                .IsUnicode(false);

            modelBuilder.Entity<type>()
                .Property(e => e.idType)
                .IsUnicode(false);
        }
    }
}
