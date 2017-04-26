namespace RedditCloneAndAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingVotes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PostValues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        VoteValue = c.Int(nullable: false),
                        User_Id = c.String(maxLength: 128),
                        Post_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Post_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostValues", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.PostValues", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.PostValues", new[] { "Post_Id" });
            DropIndex("dbo.PostValues", new[] { "User_Id" });
            DropTable("dbo.PostValues");
        }
    }
}
