namespace ArtGallery.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedArtTitleInArts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Arts", "Link", c => c.String());
            AddColumn("dbo.Arts", "Title", c => c.String());
            DropColumn("dbo.Arts", "ArtLink");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Arts", "ArtLink", c => c.String());
            DropColumn("dbo.Arts", "Title");
            DropColumn("dbo.Arts", "Link");
        }
    }
}
