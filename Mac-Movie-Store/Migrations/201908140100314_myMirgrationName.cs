namespace Mac_Movie_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myMirgrationName : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ReleasedTime = c.DateTime(nullable: false),
                        Genre = c.String(),
                        NumberOfCopy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
