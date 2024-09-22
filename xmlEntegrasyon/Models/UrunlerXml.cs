using System;
using System.Collections.Generic;

namespace xmlEntegrasyon.Models;

public partial class UrunlerXml
{
    public int Id { get; set; }

    public string XmlName { get; set; } = null!;

    public string XmlElement { get; set; } = null!;

    public string XmlKodu { get; set; } = null!;

    public string UrunKodu { get; set; } = null!;

    public string UrunMaskeBaslik { get; set; } = null!;

    public string UrunBarkodu { get; set; } = null!;

    public string? VaryantKodu { get; set; }

    public bool ParentChild { get; set; }

    public string? UrunAdi { get; set; }

    public string? UrunMarka { get; set; }

    public string? UrunRengi { get; set; }

    public string? UrunModeli { get; set; }

    public int? UrunAdeti { get; set; }

    public decimal? UrunFiyati { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public string UrunAciklamaHtml { get; set; } = null!;

    public string UrunAciklama { get; set; } = null!;

    public string? UrunVaryantTuru { get; set; }

    public string UrunAnaKategori { get; set; } = null!;

    public string UrunAltKategori1 { get; set; } = null!;

    public string UrunAltKategori2 { get; set; } = null!;

    public string UrunAltKategori3 { get; set; } = null!;

    public string UrunAltKategori4 { get; set; } = null!;

    public string UrunAltKategori5 { get; set; } = null!;

    public decimal? SatisFiyati { get; set; }

    public string DovizTuru { get; set; } = null!;

    public string UrunKdvOrani { get; set; } = null!;

    public string UrunDesi { get; set; } = null!;

    public string UrunParentBarkodu { get; set; } = null!;

    public string UrunChildBarkodu { get; set; } = null!;

    public string Image1 { get; set; } = null!;

    public string Image2 { get; set; } = null!;

    public string Image3 { get; set; } = null!;

    public string Image4 { get; set; } = null!;

    public string Image5 { get; set; } = null!;

    public string Image6 { get; set; } = null!;

    public string Image7 { get; set; } = null!;

    public string Image8 { get; set; } = null!;

    public string Image9 { get; set; } = null!;

    public string Image10 { get; set; } = null!;

    public string Image11 { get; set; } = null!;

    public string Image12 { get; set; } = null!;

    public string B2c { get; set; } = null!;

    public string N11 { get; set; } = null!;

    public string Hb { get; set; } = null!;

    public string Ty { get; set; } = null!;

    public string Cs { get; set; } = null!;

    public string Psj { get; set; } = null!;

    public string Amz { get; set; } = null!;

    public string Epa { get; set; } = null!;

    public string Pzrm { get; set; } = null!;

    public string Mdns { get; set; } = null!;

    public string Bymn { get; set; } = null!;

    public string Lcw { get; set; } = null!;

    public string Tkns { get; set; } = null!;

    public string Etsy { get; set; } = null!;

    public string Hg { get; set; } = null!;

    public string Joom { get; set; } = null!;

    public string Zlnd { get; set; } = null!;

    public string Ozon { get; set; } = null!;

    public string Woo { get; set; } = null!;

    public string Idea { get; set; } = null!;

    public string Oc { get; set; } = null!;

    public string Hipo { get; set; } = null!;

    public string Ikas { get; set; } = null!;

    public string Eth { get; set; } = null!;

    public string Tici { get; set; } = null!;

    public string Tsft { get; set; } = null!;

    public string Spfy { get; set; } = null!;

    public string Xml { get; set; } = null!;
}
