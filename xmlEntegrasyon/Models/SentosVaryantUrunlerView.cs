using System;
using System.Collections.Generic;

namespace xmlEntegrasyon.Models;

public partial class SentosVaryantUrunlerView
{
    public string KodlariModelleEsitle { get; set; } = null!;

    public string ÜrünKodu { get; set; } = null!;

    public string VaryantBarkod { get; set; } = null!;

    public string? VaryantKodu { get; set; }

    public string? ÜrünRenkleri { get; set; }

    public string? ÜrünVaryantTürü { get; set; }

    public string? ÜrünModelleri { get; set; }

    public string? Ürünİsmi { get; set; }
}
