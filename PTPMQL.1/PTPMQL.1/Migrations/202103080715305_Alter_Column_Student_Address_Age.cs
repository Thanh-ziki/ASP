namespace PTPMQL._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Column_Student_Address_Age : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Age", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Address", c => c.String());
            DropColumn("dbo.Students", "Age");
        }
    }
}
