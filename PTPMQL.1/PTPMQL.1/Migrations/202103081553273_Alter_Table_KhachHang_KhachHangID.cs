namespace PTPMQL._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Table_KhachHang_KhachHangID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.KhachHangs");
            AlterColumn("dbo.KhachHangs", "KhachHangID", c => c.String(nullable: false, maxLength: 15));
            AddPrimaryKey("dbo.KhachHangs", "KhachHangID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.KhachHangs");
            AlterColumn("dbo.KhachHangs", "KhachHangID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.KhachHangs", "KhachHangID");
        }
    }
}
