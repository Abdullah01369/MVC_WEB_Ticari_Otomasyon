namespace Data_Access_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Admin_Id = c.Int(nullable: false, identity: true),
                        Admin_Ad = c.String(nullable: false),
                        Admin_Soyad = c.String(nullable: false),
                        Admin_Mail = c.String(nullable: false),
                        Admin_Sifre = c.String(nullable: false),
                        Admin_Kayit_Tarih = c.DateTime(nullable: false),
                        Admin_Yetki = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Admin_Id);
            
            CreateTable(
                "dbo.Caris",
                c => new
                    {
                        Cari_Id = c.Int(nullable: false, identity: true),
                        Cari_Ad = c.String(nullable: false),
                        Cari_Soyad = c.String(nullable: false),
                        Cari_Mail = c.String(nullable: false),
                        Sehir_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Cari_Id)
                .ForeignKey("dbo.Sehirs", t => t.Sehir_Id, cascadeDelete: true)
                .Index(t => t.Sehir_Id);
            
            CreateTable(
                "dbo.Satis_Hareket",
                c => new
                    {
                        Satis_Id = c.Int(nullable: false, identity: true),
                        Tarih = c.DateTime(nullable: false),
                        Adet = c.Int(nullable: false),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Toplam_Tutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Personel_Id = c.Int(nullable: false),
                        Urun_Id = c.Int(nullable: false),
                        Cari_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Satis_Id)
                .ForeignKey("dbo.Caris", t => t.Cari_Id, cascadeDelete: true)
                .ForeignKey("dbo.Personels", t => t.Personel_Id, cascadeDelete: true)
                .ForeignKey("dbo.Uruns", t => t.Urun_Id, cascadeDelete: true)
                .Index(t => t.Personel_Id)
                .Index(t => t.Urun_Id)
                .Index(t => t.Cari_Id);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        Personel_Id = c.Int(nullable: false, identity: true),
                        Personel_Ad = c.String(nullable: false),
                        Personel_Soyad = c.String(nullable: false),
                        Personel_Gorsel = c.String(nullable: false),
                        Personel_Mail = c.String(nullable: false),
                        Personel_Sifre = c.String(nullable: false),
                        Personel_Kayit_Tarih = c.String(nullable: false),
                        Departman_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Personel_Id)
                .ForeignKey("dbo.Departmen", t => t.Departman_Id, cascadeDelete: true)
                .Index(t => t.Departman_Id);
            
            CreateTable(
                "dbo.Departmen",
                c => new
                    {
                        Departman_Id = c.Int(nullable: false, identity: true),
                        Departman_Ad = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Departman_Id);
            
            CreateTable(
                "dbo.Sehirs",
                c => new
                    {
                        Sehir_Id = c.Int(nullable: false, identity: true),
                        Sehir_No = c.String(nullable: false),
                        Sehir_Ad = c.String(nullable: false),
                        Satis_Hareket_Satis_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Sehir_Id)
                .ForeignKey("dbo.Satis_Hareket", t => t.Satis_Hareket_Satis_Id)
                .Index(t => t.Satis_Hareket_Satis_Id);
            
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        Urun_Id = c.Int(nullable: false, identity: true),
                        Urun_Ad = c.String(nullable: false),
                        Alis_Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Satis_Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Durum = c.Boolean(nullable: false),
                        Stok = c.Short(nullable: false),
                        Urun_Gorsel = c.String(),
                        Urun_Eklenme_Tarih = c.DateTime(nullable: false),
                        Kategori_Id = c.Int(nullable: false),
                        Marka_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Urun_Id)
                .ForeignKey("dbo.Kategoris", t => t.Kategori_Id, cascadeDelete: true)
                .ForeignKey("dbo.Markas", t => t.Marka_Id, cascadeDelete: true)
                .Index(t => t.Kategori_Id)
                .Index(t => t.Marka_Id);
            
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        Kategori_Id = c.Int(nullable: false, identity: true),
                        Kategori_Ad = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Kategori_Id);
            
            CreateTable(
                "dbo.Markas",
                c => new
                    {
                        Marka_Id = c.Int(nullable: false, identity: true),
                        Marka_Ad = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Marka_Id);
            
            CreateTable(
                "dbo.Fatura_Kalem",
                c => new
                    {
                        Fatura_Kalem_Id = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(nullable: false),
                        Miktar = c.Int(nullable: false),
                        Birim_Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fatura_Fatura_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Fatura_Kalem_Id)
                .ForeignKey("dbo.Faturas", t => t.fatura_Fatura_Id)
                .Index(t => t.fatura_Fatura_Id);
            
            CreateTable(
                "dbo.Faturas",
                c => new
                    {
                        Fatura_Id = c.Int(nullable: false, identity: true),
                        Fatura_Seri_No = c.String(nullable: false),
                        Fatura_Sira_No = c.String(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                        Vergi_Dairesi = c.String(nullable: false),
                        Saat = c.DateTime(nullable: false),
                        Teslim_Alan = c.String(nullable: false),
                        Teslim_Eden = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Fatura_Id);
            
            CreateTable(
                "dbo.Giders",
                c => new
                    {
                        Gider_Id = c.Int(nullable: false, identity: true),
                        Gider_Aciklama = c.String(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                        Tutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Gider_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fatura_Kalem", "fatura_Fatura_Id", "dbo.Faturas");
            DropForeignKey("dbo.Satis_Hareket", "Urun_Id", "dbo.Uruns");
            DropForeignKey("dbo.Uruns", "Marka_Id", "dbo.Markas");
            DropForeignKey("dbo.Uruns", "Kategori_Id", "dbo.Kategoris");
            DropForeignKey("dbo.Sehirs", "Satis_Hareket_Satis_Id", "dbo.Satis_Hareket");
            DropForeignKey("dbo.Caris", "Sehir_Id", "dbo.Sehirs");
            DropForeignKey("dbo.Satis_Hareket", "Personel_Id", "dbo.Personels");
            DropForeignKey("dbo.Personels", "Departman_Id", "dbo.Departmen");
            DropForeignKey("dbo.Satis_Hareket", "Cari_Id", "dbo.Caris");
            DropIndex("dbo.Fatura_Kalem", new[] { "fatura_Fatura_Id" });
            DropIndex("dbo.Uruns", new[] { "Marka_Id" });
            DropIndex("dbo.Uruns", new[] { "Kategori_Id" });
            DropIndex("dbo.Sehirs", new[] { "Satis_Hareket_Satis_Id" });
            DropIndex("dbo.Personels", new[] { "Departman_Id" });
            DropIndex("dbo.Satis_Hareket", new[] { "Cari_Id" });
            DropIndex("dbo.Satis_Hareket", new[] { "Urun_Id" });
            DropIndex("dbo.Satis_Hareket", new[] { "Personel_Id" });
            DropIndex("dbo.Caris", new[] { "Sehir_Id" });
            DropTable("dbo.Giders");
            DropTable("dbo.Faturas");
            DropTable("dbo.Fatura_Kalem");
            DropTable("dbo.Markas");
            DropTable("dbo.Kategoris");
            DropTable("dbo.Uruns");
            DropTable("dbo.Sehirs");
            DropTable("dbo.Departmen");
            DropTable("dbo.Personels");
            DropTable("dbo.Satis_Hareket");
            DropTable("dbo.Caris");
            DropTable("dbo.Admins");
        }
    }
}
