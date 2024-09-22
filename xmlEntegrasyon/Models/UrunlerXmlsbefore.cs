using System;
using System.Collections.Generic;

namespace xmlEntegrasyon.Models;

public partial class UrunlerXmlsbefore
{
    public int Id { get; set; }

    public string XmlName { get; set; } = null!;

    public string XmlElement { get; set; } = null!;

    public string XmlKodu { get; set; } = null!;

    public string UrunKodu { get; set; } = null!;

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
}
