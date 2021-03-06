namespace PTPMQL._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Nhanvien : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "NhanvienID", c => c.String());
            AddColumn("dbo.Persons", "Vitri", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "Vitri");
            DropColumn("dbo.Persons", "NhanvienID");
        }
    }
}
