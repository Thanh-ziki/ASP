namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_database : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Accounts");
            CreateTable(
                "dbo.students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        StudentName = c.String(),
                        address = c.String(),
                        QueQuan = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
            AlterColumn("dbo.Accounts", "UserName", c => c.String(nullable: false, unicode: false));
            AddPrimaryKey("dbo.Accounts", "UserName");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Accounts");
            AlterColumn("dbo.Accounts", "UserName", c => c.String(nullable: false, maxLength: 128));
            DropTable("dbo.students");
            AddPrimaryKey("dbo.Accounts", "UserName");
        }
    }
}
