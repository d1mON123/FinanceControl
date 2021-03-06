namespace FinanceControlDAL.EF
{
    using Models;
    using System.Data.Entity;

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
        public virtual DbSet<Type> Types { get; set; }

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

            modelBuilder.Entity<Type>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Type>()
                .HasMany(e => e.Incomes)
                .WithRequired(e => e.Type)
                .HasForeignKey(e => e.Type_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Type>()
                .HasMany(e => e.Outlays)
                .WithRequired(e => e.Type)
                .HasForeignKey(e => e.Type_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
