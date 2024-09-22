using System;
using System.Collections.Generic;

namespace xmlEntegrasyon.Models;

public partial class SentosSatisFiyati
{
    public string UrunKodu { get; set; } = null!;

    public string? UrunAdi { get; set; }

    public string? UrunMarka { get; set; }

    public string? UrunRengi { get; set; }

    public string? UrunModeli { get; set; }

    public decimal? UrunAliMaliyeti { get; set; }

    public decimal? N11fiyati { get; set; }

    public decimal? N11indirimliFiyati { get; set; }

    public decimal? Hbfiyati { get; set; }

    public decimal? TrendyolFiyati { get; set; }

    public decimal? TrendyolIndirimliFiyati { get; set; }

    public decimal? Csfiyati { get; set; }

    public decimal? CsindirimliFiyati { get; set; }

    public decimal? Epafiyati { get; set; }

    public decimal? EpaindirimliFiyati { get; set; }

    public decimal? Amzfiyati { get; set; }

    public decimal? Pzrmfiyati { get; set; }

    public decimal? PzrmindirimliFiyati { get; set; }

    public decimal? Woofiyati { get; set; }

    public decimal? WooindirimliFiyati { get; set; }
}
