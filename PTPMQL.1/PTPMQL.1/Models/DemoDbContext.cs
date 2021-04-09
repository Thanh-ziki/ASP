using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTPMQL._1.Models
{
    public partial class DemoDbContext : DbContext
    {
        public DemoDbContext()
            : base("name=DemoDbContext")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
       
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<QuanLyThuVien> QuanLyThuViens { get; set; }
        public virtual DbSet<Person> Persons{ get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<PTPMQL._1.Models.student> students { get; set; }

        public System.Data.Entity.DbSet<PTPMQL._1.Models.Nhanvien> Nhanviens { get; set; }
    }
}
