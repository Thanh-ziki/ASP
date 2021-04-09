namespace BTL_SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NotDay : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NotDay",
                c => new
                    {
                        NhatKySo = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(),
                        MaDangKy = c.String(),
                        IDnguoiDung = c.String(),
                        NoiDung = c.String(),
                    })
                .PrimaryKey(t => t.NhatKySo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NotDay");
        }
    }
}
