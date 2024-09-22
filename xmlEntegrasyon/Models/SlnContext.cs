using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace xmlEntegrasyon.Models;

public partial class SlnContext : DbContext
{
    public SlnContext()
    {
    }

    public SlnContext(DbContextOptions<SlnContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SentosGuncelStokView> SentosGuncelStokViews { get; set; }

    public virtual DbSet<SentosSatisFiyati> SentosSatisFiyatis { get; set; }

    public virtual DbSet<SentosUrunlerView> SentosUrunlerViews { get; set; }

    public virtual DbSet<SentosVaryantUrunlerView> SentosVaryantUrunlerViews { get; set; }

    public virtual DbSet<UrunlerXml> UrunlerXmls { get; set; }

    public virtual DbSet<UrunlerXmlsbefore> UrunlerXmlsbefores { get; set; }

    public virtual DbSet<UrunlerXmlshistory> UrunlerXmlshistories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sln;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SentosGuncelStokView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SentosGuncelStokView");

            entity.Property(e => e.AnaKodlariModelleEsitle).HasMaxLength(406);
            entity.Property(e => e.MerkezDepo).HasColumnName("Merkez Depo");
            entity.Property(e => e.MerkezKritikStokAdedi).HasColumnName("MERKEZ Kritik Stok Adedi");
            entity.Property(e => e.VaryantBarkod)
                .HasMaxLength(50)
                .HasColumnName("Varyant Barkod");
            entity.Property(e => e.VaryantKodu)
                .HasMaxLength(50)
                .HasColumnName("Varyant Kodu");
            entity.Property(e => e.ÜrünKodu)
                .HasMaxLength(50)
                .HasColumnName("Ürün Kodu");
            entity.Property(e => e.ÜrünMarka)
                .HasMaxLength(50)
                .HasColumnName("Ürün Marka");
            entity.Property(e => e.ÜrünModelleri)
                .HasMaxLength(355)
                .HasColumnName("Ürün Modelleri");
            entity.Property(e => e.ÜrünRenkleri)
                .HasMaxLength(25)
                .HasColumnName("Ürün Renkleri");
            entity.Property(e => e.Ürünİsmi)
                .HasMaxLength(355)
                .HasColumnName("Ürün İsmi");
        });

        modelBuilder.Entity<SentosSatisFiyati>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SentosSatisFiyati");

            entity.Property(e => e.Amzfiyati)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMZFiyati");
            entity.Property(e => e.Csfiyati)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CSFiyati");
            entity.Property(e => e.CsindirimliFiyati)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CSIndirimliFiyati");
            entity.Property(e => e.Epafiyati)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EPAFiyati");
            entity.Property(e => e.EpaindirimliFiyati)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EPAIndirimliFiyati");
            entity.Property(e => e.Hbfiyati)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HBFiyati");
            entity.Property(e => e.N11fiyati)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N11Fiyati");
            entity.Property(e => e.N11indirimliFiyati)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N11IndirimliFiyati");
            entity.Property(e => e.Pzrmfiyati)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PZRMFiyati");
            entity.Property(e => e.PzrmindirimliFiyati)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PZRMIndirimliFiyati");
            entity.Property(e => e.TrendyolFiyati).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrendyolIndirimliFiyati).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UrunAdi).HasMaxLength(355);
            entity.Property(e => e.UrunAliMaliyeti).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UrunKodu).HasMaxLength(50);
            entity.Property(e => e.UrunMarka).HasMaxLength(50);
            entity.Property(e => e.UrunModeli).HasMaxLength(355);
            entity.Property(e => e.UrunRengi).HasMaxLength(25);
            entity.Property(e => e.Woofiyati)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WOOFiyati");
            entity.Property(e => e.WooindirimliFiyati)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WOOIndirimliFiyati");
        });

        modelBuilder.Entity<SentosUrunlerView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SentosUrunlerView");

            entity.Property(e => e.AltKategori1)
                .HasMaxLength(355)
                .HasColumnName("Alt Kategori-1");
            entity.Property(e => e.AltKategori2)
                .HasMaxLength(355)
                .HasColumnName("Alt Kategori-2");
            entity.Property(e => e.AltKategori3)
                .HasMaxLength(355)
                .HasColumnName("Alt Kategori-3");
            entity.Property(e => e.AlışFiyatı)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Alış Fiyatı");
            entity.Property(e => e.AmzEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("AMZ Entegrasyon");
            entity.Property(e => e.AnaKategori)
                .HasMaxLength(355)
                .HasColumnName("Ana Kategori");
            entity.Property(e => e.B2cEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("B2C Entegrasyon");
            entity.Property(e => e.BymnEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("BYMN Entegrasyon");
            entity.Property(e => e.CsEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("CS Entegrasyon");
            entity.Property(e => e.Desi)
                .HasMaxLength(10)
                .HasColumnName("DESI");
            entity.Property(e => e.DövizKuru)
                .HasMaxLength(10)
                .HasColumnName("Döviz Kuru");
            entity.Property(e => e.EpaEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("EPA Entegrasyon");
            entity.Property(e => e.EthEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("ETH Entegrasyon");
            entity.Property(e => e.EtsyEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("ETSY Entegrasyon");
            entity.Property(e => e.HbEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("HB Entegrasyon");
            entity.Property(e => e.HgEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("HG Entegrasyon");
            entity.Property(e => e.HipoEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("HIPO Entegrasyon");
            entity.Property(e => e.HtmlAçıklama).HasColumnName("HTML Açıklama");
            entity.Property(e => e.IdeaEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("IDEA Entegrasyon");
            entity.Property(e => e.IkasEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("IKAS Entegrasyon");
            entity.Property(e => e.JoomEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("JOOM Entegrasyon");
            entity.Property(e => e.KdvOranı)
                .HasMaxLength(10)
                .HasColumnName("KDV Oranı");
            entity.Property(e => e.LcvEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("LCV Entegrasyon");
            entity.Property(e => e.Marka).HasMaxLength(50);
            entity.Property(e => e.MdnsEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("MDNS Entegrasyon");
            entity.Property(e => e.N11Entegrasyon)
                .HasMaxLength(1)
                .HasColumnName("N11 Entegrasyon");
            entity.Property(e => e.OcEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("OC Entegrasyon");
            entity.Property(e => e.OzonEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("OZON Entegrasyon");
            entity.Property(e => e.PsjEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("PSJ Entegrasyon");
            entity.Property(e => e.PzrmEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("PZRM Entegrasyon");
            entity.Property(e => e.Resim1)
                .HasMaxLength(355)
                .HasColumnName("Resim 1");
            entity.Property(e => e.Resim10)
                .HasMaxLength(355)
                .HasColumnName("Resim 10");
            entity.Property(e => e.Resim11)
                .HasMaxLength(355)
                .HasColumnName("Resim 11");
            entity.Property(e => e.Resim12)
                .HasMaxLength(355)
                .HasColumnName("Resim 12");
            entity.Property(e => e.Resim2)
                .HasMaxLength(355)
                .HasColumnName("Resim 2");
            entity.Property(e => e.Resim3)
                .HasMaxLength(355)
                .HasColumnName("Resim 3");
            entity.Property(e => e.Resim4)
                .HasMaxLength(355)
                .HasColumnName("Resim 4");
            entity.Property(e => e.Resim5)
                .HasMaxLength(355)
                .HasColumnName("Resim 5");
            entity.Property(e => e.Resim6)
                .HasMaxLength(355)
                .HasColumnName("Resim 6");
            entity.Property(e => e.Resim7)
                .HasMaxLength(355)
                .HasColumnName("Resim 7");
            entity.Property(e => e.Resim8)
                .HasMaxLength(355)
                .HasColumnName("Resim 8");
            entity.Property(e => e.Resim9)
                .HasMaxLength(355)
                .HasColumnName("Resim 9");
            entity.Property(e => e.SatışFiyatı)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Satış Fiyatı");
            entity.Property(e => e.SpfyEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("SPFY Entegrasyon");
            entity.Property(e => e.TiciEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("TICI Entegrasyon");
            entity.Property(e => e.TknsEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("TKNS Entegrasyon");
            entity.Property(e => e.TsftEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("TSFT Entegrasyon");
            entity.Property(e => e.TyEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("TY Entegrasyon");
            entity.Property(e => e.WooEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("WOO Entegrasyon");
            entity.Property(e => e.XmlEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("XML Entegrasyon");
            entity.Property(e => e.ZlndEntegrasyon)
                .HasMaxLength(1)
                .HasColumnName("ZLND Entegrasyon");
            entity.Property(e => e.ÜrünAltBaşlık)
                .HasMaxLength(55)
                .HasColumnName("Ürün Alt Başlık");
            entity.Property(e => e.ÜrünBarkodu)
                .HasMaxLength(50)
                .HasColumnName("ÜRÜN BARKODU");
            entity.Property(e => e.ÜrünKodu)
                .HasMaxLength(50)
                .HasColumnName("Ürün Kodu");
            entity.Property(e => e.ÜrünModelleri)
                .HasMaxLength(355)
                .HasColumnName("Ürün Modelleri");
            entity.Property(e => e.ÜrünRenkleri)
                .HasMaxLength(25)
                .HasColumnName("Ürün Renkleri");
            entity.Property(e => e.ÜrünVaryantTürü)
                .HasMaxLength(50)
                .HasColumnName("Ürün Varyant Türü");
            entity.Property(e => e.Ürünİsmi)
                .HasMaxLength(355)
                .HasColumnName("Ürün İsmi");
        });

        modelBuilder.Entity<SentosVaryantUrunlerView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SentosVaryantUrunlerView");

            entity.Property(e => e.KodlariModelleEsitle).HasMaxLength(406);
            entity.Property(e => e.VaryantBarkod)
                .HasMaxLength(50)
                .HasColumnName("Varyant Barkod");
            entity.Property(e => e.VaryantKodu)
                .HasMaxLength(50)
                .HasColumnName("Varyant Kodu");
            entity.Property(e => e.ÜrünKodu)
                .HasMaxLength(50)
                .HasColumnName("Ürün Kodu");
            entity.Property(e => e.ÜrünModelleri)
                .HasMaxLength(355)
                .HasColumnName("Ürün Modelleri");
            entity.Property(e => e.ÜrünRenkleri)
                .HasMaxLength(25)
                .HasColumnName("Ürün Renkleri");
            entity.Property(e => e.ÜrünVaryantTürü)
                .HasMaxLength(50)
                .HasColumnName("Ürün Varyant Türü");
            entity.Property(e => e.Ürünİsmi)
                .HasMaxLength(355)
                .HasColumnName("Ürün İsmi");
        });

        modelBuilder.Entity<UrunlerXml>(entity =>
        {
            entity.ToTable("UrunlerXMLS");

            entity.Property(e => e.Amz)
                .HasMaxLength(1)
                .HasColumnName("AMZ");
            entity.Property(e => e.B2c)
                .HasMaxLength(1)
                .HasColumnName("B2C");
            entity.Property(e => e.Bymn)
                .HasMaxLength(1)
                .HasColumnName("BYMN");
            entity.Property(e => e.Cs)
                .HasMaxLength(1)
                .HasColumnName("CS");
            entity.Property(e => e.DovizTuru).HasMaxLength(10);
            entity.Property(e => e.Epa)
                .HasMaxLength(1)
                .HasColumnName("EPA");
            entity.Property(e => e.Eth)
                .HasMaxLength(1)
                .HasColumnName("ETH");
            entity.Property(e => e.Etsy)
                .HasMaxLength(1)
                .HasColumnName("ETSY");
            entity.Property(e => e.Hb)
                .HasMaxLength(1)
                .HasColumnName("HB");
            entity.Property(e => e.Hg)
                .HasMaxLength(1)
                .HasColumnName("HG");
            entity.Property(e => e.Hipo)
                .HasMaxLength(1)
                .HasColumnName("HIPO");
            entity.Property(e => e.Idea)
                .HasMaxLength(1)
                .HasColumnName("IDEA");
            entity.Property(e => e.Ikas)
                .HasMaxLength(1)
                .HasColumnName("IKAS");
            entity.Property(e => e.Image1).HasMaxLength(355);
            entity.Property(e => e.Image10).HasMaxLength(355);
            entity.Property(e => e.Image11).HasMaxLength(355);
            entity.Property(e => e.Image12).HasMaxLength(355);
            entity.Property(e => e.Image2).HasMaxLength(355);
            entity.Property(e => e.Image3).HasMaxLength(355);
            entity.Property(e => e.Image4).HasMaxLength(355);
            entity.Property(e => e.Image5).HasMaxLength(355);
            entity.Property(e => e.Image6).HasMaxLength(355);
            entity.Property(e => e.Image7).HasMaxLength(355);
            entity.Property(e => e.Image8).HasMaxLength(355);
            entity.Property(e => e.Image9).HasMaxLength(355);
            entity.Property(e => e.Joom)
                .HasMaxLength(1)
                .HasColumnName("JOOM");
            entity.Property(e => e.Lcw)
                .HasMaxLength(1)
                .HasColumnName("LCW");
            entity.Property(e => e.Mdns)
                .HasMaxLength(1)
                .HasColumnName("MDNS");
            entity.Property(e => e.N11).HasMaxLength(1);
            entity.Property(e => e.Oc)
                .HasMaxLength(1)
                .HasColumnName("OC");
            entity.Property(e => e.Ozon)
                .HasMaxLength(1)
                .HasColumnName("OZON");
            entity.Property(e => e.Psj)
                .HasMaxLength(1)
                .HasColumnName("PSJ");
            entity.Property(e => e.Pzrm)
                .HasMaxLength(1)
                .HasColumnName("PZRM");
            entity.Property(e => e.SatisFiyati).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Spfy)
                .HasMaxLength(1)
                .HasColumnName("SPFY");
            entity.Property(e => e.Tici)
                .HasMaxLength(1)
                .HasColumnName("TICI");
            entity.Property(e => e.Tkns)
                .HasMaxLength(1)
                .HasColumnName("TKNS");
            entity.Property(e => e.Tsft)
                .HasMaxLength(1)
                .HasColumnName("TSFT");
            entity.Property(e => e.Ty)
                .HasMaxLength(1)
                .HasColumnName("TY");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UrunAdi).HasMaxLength(355);
            entity.Property(e => e.UrunAltKategori1)
                .HasMaxLength(355)
                .HasColumnName("UrunAltKategori_1");
            entity.Property(e => e.UrunAltKategori2)
                .HasMaxLength(355)
                .HasColumnName("UrunAltKategori_2");
            entity.Property(e => e.UrunAltKategori3)
                .HasMaxLength(355)
                .HasColumnName("UrunAltKategori_3");
            entity.Property(e => e.UrunAltKategori4)
                .HasMaxLength(355)
                .HasColumnName("UrunAltKategori_4");
            entity.Property(e => e.UrunAltKategori5)
                .HasMaxLength(355)
                .HasColumnName("UrunAltKategori_5");
            entity.Property(e => e.UrunAnaKategori).HasMaxLength(355);
            entity.Property(e => e.UrunBarkodu).HasMaxLength(50);
            entity.Property(e => e.UrunChildBarkodu).HasMaxLength(50);
            entity.Property(e => e.UrunDesi).HasMaxLength(10);
            entity.Property(e => e.UrunFiyati).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UrunKdvOrani).HasMaxLength(10);
            entity.Property(e => e.UrunKodu).HasMaxLength(50);
            entity.Property(e => e.UrunMarka).HasMaxLength(50);
            entity.Property(e => e.UrunMaskeBaslik).HasMaxLength(55);
            entity.Property(e => e.UrunModeli).HasMaxLength(355);
            entity.Property(e => e.UrunParentBarkodu).HasMaxLength(50);
            entity.Property(e => e.UrunRengi).HasMaxLength(25);
            entity.Property(e => e.UrunVaryantTuru).HasMaxLength(50);
            entity.Property(e => e.VaryantKodu).HasMaxLength(50);
            entity.Property(e => e.Woo)
                .HasMaxLength(1)
                .HasColumnName("WOO");
            entity.Property(e => e.Xml)
                .HasMaxLength(1)
                .HasColumnName("XML");
            entity.Property(e => e.XmlElement).HasMaxLength(20);
            entity.Property(e => e.XmlKodu).HasMaxLength(50);
            entity.Property(e => e.XmlName).HasMaxLength(5);
            entity.Property(e => e.Zlnd)
                .HasMaxLength(1)
                .HasColumnName("ZLND");
        });

        modelBuilder.Entity<UrunlerXmlsbefore>(entity =>
        {
            entity.ToTable("UrunlerXMLSBefore");

            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UrunAdi).HasMaxLength(355);
            entity.Property(e => e.UrunBarkodu).HasMaxLength(50);
            entity.Property(e => e.UrunFiyati).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UrunKodu).HasMaxLength(50);
            entity.Property(e => e.UrunMarka).HasMaxLength(50);
            entity.Property(e => e.UrunModeli).HasMaxLength(355);
            entity.Property(e => e.UrunRengi).HasMaxLength(25);
            entity.Property(e => e.VaryantKodu).HasMaxLength(50);
            entity.Property(e => e.XmlElement).HasMaxLength(20);
            entity.Property(e => e.XmlKodu).HasMaxLength(50);
            entity.Property(e => e.XmlName).HasMaxLength(5);
        });

        modelBuilder.Entity<UrunlerXmlshistory>(entity =>
        {
            entity.ToTable("UrunlerXMLSHistory");

            entity.Property(e => e.ChangeDate).HasColumnType("datetime");
            entity.Property(e => e.KayitTipi).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UrunAdi).HasMaxLength(355);
            entity.Property(e => e.UrunBarkodu).HasMaxLength(50);
            entity.Property(e => e.UrunFiyati).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UrunKodu).HasMaxLength(50);
            entity.Property(e => e.UrunMarka).HasMaxLength(50);
            entity.Property(e => e.UrunModeli).HasMaxLength(355);
            entity.Property(e => e.UrunRengi).HasMaxLength(25);
            entity.Property(e => e.VaryantKodu).HasMaxLength(50);
            entity.Property(e => e.XmlElement).HasMaxLength(20);
            entity.Property(e => e.XmlKodu).HasMaxLength(50);
            entity.Property(e => e.XmlName).HasMaxLength(5);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
