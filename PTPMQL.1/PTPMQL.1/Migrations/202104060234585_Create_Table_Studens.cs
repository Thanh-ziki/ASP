namespace PTPMQL._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Studens : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        CCCD = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(),
                        Address = c.String(),
                        University = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CCCD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
