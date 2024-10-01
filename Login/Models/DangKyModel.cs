using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
namespace Login.Models
{
    public partial class DangKyModel : DbContext
    {
        public DangKyModel()
            : base("name=DangKyModel")
        {
        }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.ho)
                .IsFixedLength();
            modelBuilder.Entity<User>()
                .Property(e => e.ten)
                .IsFixedLength();
            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsFixedLength();
            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsFixedLength();
            modelBuilder.Entity<User>()
                .Property(e => e.phone)
                .IsFixedLength();
            modelBuilder.Entity<User>()
                .Property(e => e.avatar)
                .IsFixedLength();
        }
    }
}