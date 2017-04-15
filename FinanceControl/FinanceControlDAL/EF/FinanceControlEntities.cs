namespace FinanceControlDAL.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using FinanceControlDAL.Models;

    public partial class FinanceControlEntities : DbContext
    {
        public FinanceControlEntities()
            : base("name=FinanceControlConnection")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        public virtual DbSet<Outlay> Outlays { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Models.Type> Types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Incomes)
                .WithRequired(e => e.Account)
                .HasForeignKey(e => e.Account_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Outlays)
                .WithRequired(e => e.Account)
                .HasForeignKey(e => e.Account_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Income>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Outlay>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Incomes)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.Person_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Outlays)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.Person_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Models.Type>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Models.Type>()
                .HasMany(e => e.Incomes)
                .WithRequired(e => e.Type)
                .HasForeignKey(e => e.Type_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Models.Type>()
                .HasMany(e => e.Outlays)
                .WithRequired(e => e.Type)
                .HasForeignKey(e => e.Type_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
