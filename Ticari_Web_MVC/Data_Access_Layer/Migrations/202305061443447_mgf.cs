namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mesajs",
                c => new
                    {
                        Mesaj_Id = c.Int(nullable: false, identity: true),
                        Alici = c.String(maxLength: 100),
                        Gonderici = c.String(maxLength: 100),
                        Icerik = c.String(maxLength: 500),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Mesaj_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mesajs");
        }
    }
}
