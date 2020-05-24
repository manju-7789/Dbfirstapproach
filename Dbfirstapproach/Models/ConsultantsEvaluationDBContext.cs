using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dbfirstapproach.Models
{
    public partial class ConsultantsEvaluationDBContext : DbContext
    {
        public ConsultantsEvaluationDBContext()
        {
        }

        public ConsultantsEvaluationDBContext(DbContextOptions<ConsultantsEvaluationDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EvaluationProcesses> EvaluationProcesses { get; set; }
        public virtual DbSet<EvaluationTechnologies> EvaluationTechnologies { get; set; }
        public virtual DbSet<Evaluators> Evaluators { get; set; }
        public virtual DbSet<SubAreaFeedbacks> SubAreaFeedbacks { get; set; }
        public virtual DbSet<TechAreaRecommendations> TechAreaRecommendations { get; set; }
        public virtual DbSet<TechSubAreas> TechSubAreas { get; set; }
        public virtual DbSet<TechnologyAreas> TechnologyAreas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ConsultantsEvaluationDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EvaluationProcesses>(entity =>
            {
                entity.HasKey(e => e.EvaluationId)
                    .HasName("PK__Evaluati__36AE68F3643FD248");
            });

            modelBuilder.Entity<EvaluationTechnologies>(entity =>
            {
                entity.HasIndex(e => e.EvaluationId);

                entity.HasIndex(e => e.TechId);

                entity.HasOne(d => d.Evaluation)
                    .WithMany(p => p.EvaluationTechnologies)
                    .HasForeignKey(d => d.EvaluationId);

                entity.HasOne(d => d.Tech)
                    .WithMany(p => p.EvaluationTechnologies)
                    .HasForeignKey(d => d.TechId);
            });

            modelBuilder.Entity<Evaluators>(entity =>
            {
                entity.HasKey(e => e.EvaluatorId);

                entity.HasIndex(e => e.EvaluationId);

                entity.HasOne(d => d.Evaluation)
                    .WithMany(p => p.Evaluators)
                    .HasForeignKey(d => d.EvaluationId);
            });

            modelBuilder.Entity<SubAreaFeedbacks>(entity =>
            {
                entity.HasIndex(e => e.EvaluatorId);

                entity.HasIndex(e => e.SubTechId);

                entity.HasOne(d => d.Evaluator)
                    .WithMany(p => p.SubAreaFeedbacks)
                    .HasForeignKey(d => d.EvaluatorId);

                entity.HasOne(d => d.SubTech)
                    .WithMany(p => p.SubAreaFeedbacks)
                    .HasForeignKey(d => d.SubTechId);
            });

            modelBuilder.Entity<TechAreaRecommendations>(entity =>
            {
                entity.HasIndex(e => e.EvaluatorId);

                entity.HasIndex(e => e.TechId);

                entity.HasOne(d => d.Evaluator)
                    .WithMany(p => p.TechAreaRecommendations)
                    .HasForeignKey(d => d.EvaluatorId);

                entity.HasOne(d => d.Tech)
                    .WithMany(p => p.TechAreaRecommendations)
                    .HasForeignKey(d => d.TechId);
            });

            modelBuilder.Entity<TechSubAreas>(entity =>
            {
                entity.HasKey(e => e.SubTechId);

                entity.HasIndex(e => e.TechId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Tech)
                    .WithMany(p => p.TechSubAreas)
                    .HasForeignKey(d => d.TechId);
            });

            modelBuilder.Entity<TechnologyAreas>(entity =>
            {
                entity.HasKey(e => e.TechId)
                    .HasName("PK__Technolo__8AFFB87FBCD0D892");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
