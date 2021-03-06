﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using db_task.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace db_task.Data
{
    public partial class PersonContext : DbContext
    {
        public PersonContext()
        {
        }

        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<person> person { get; set; }
        public virtual DbSet<phone> phone { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=CHEESE\\SQLEXPRESS;Initial Catalog=Person;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<person>(entity =>
            {
                entity.Property(e => e.name).IsUnicode(false);

                entity.Property(e => e.timeStamp).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<phone>(entity =>
            {
                entity.HasIndex(e => e.number)
                    .HasName("UK_phone")
                    .IsUnique();

                entity.Property(e => e.number).IsUnicode(false);

                entity.Property(e => e.type).IsUnicode(false);

                entity.HasOne(d => d.person)
                    .WithMany(p => p.phone)
                    .HasForeignKey(d => d.personId)
                    .HasConstraintName("FK_phone_person");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}