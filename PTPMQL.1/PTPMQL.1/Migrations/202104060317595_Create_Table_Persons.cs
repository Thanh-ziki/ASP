namespace PTPMQL._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Persons : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.People", newName: "Persons");
            DropColumn("dbo.Persons", "Address");
            DropColumn("dbo.Persons", "University");
            DropColumn("dbo.Persons", "Discriminator");
            DropTable("dbo.Students");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        StudentName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
            AddColumn("dbo.Persons", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Persons", "University", c => c.String());
            AddColumn("dbo.Persons", "Address", c => c.String());
            RenameTable(name: "dbo.Persons", newName: "People");
        }
    }
}
