namespace PTPMQL._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_QuanLyThuVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuanLyThuViens",
                c => new
                    {
                        MaSach = c.String(nullable: false, maxLength: 128),
                        TenSach = c.String(),
                        MaLoaiSach = c.String(),
                        SoLuong = c.String(),
                    })
                .PrimaryKey(t => t.MaSach);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QuanLyThuViens");
        }
    }
}
