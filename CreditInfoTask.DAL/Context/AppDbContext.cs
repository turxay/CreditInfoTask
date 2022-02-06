
using CreditInfoTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreditInfoTask.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected AppDbContext()
        {


        }
        public DbSet<Contract> Contracts { get ;set;}
        public DbSet<ContractData> ContractDatas { get ;set;}
        public DbSet<CurrentBalance> CurrentBalances { get ;set;}
        public DbSet<GuaranteeAmount> GuaranteeAmounts { get ;set;}
        public DbSet<IdentificationNumbers> IdentificationNumbers { get ;set;}
        public DbSet<InstallmentAmount> InstallmentAmounts { get ;set;}
        public DbSet<OriginalAmount> OriginalAmount { get ;set;}
        public DbSet<OverdueBalance> OverdueBalances { get ;set;}
        public DbSet<SubjectRole> SubjectRoles { get ;set;}
        public DbSet<Individual> Individual { get ;set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrentBalance>()
                .HasNoKey();
            modelBuilder.Entity<GuaranteeAmount>()
                .HasNoKey();
            modelBuilder.Entity<IdentificationNumbers>()
                .HasNoKey();
            modelBuilder.Entity<InstallmentAmount>()
                .HasNoKey();
            modelBuilder.Entity<OverdueBalance>()
                .HasNoKey();
            modelBuilder.Entity<OriginalAmount>()
                .HasNoKey();
            modelBuilder.Entity<SubjectRole>()
                .HasNoKey();


        }
    }
}
