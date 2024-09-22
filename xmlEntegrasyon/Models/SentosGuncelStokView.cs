using System;
using System.Collections.Generic;

namespace xmlEntegrasyon.Models;

public partial class SentosGuncelStokView
{
    public string AnaKodlariModelleEsitle { get; set; } = null!;

    public string ÜrünKodu { get; set; } = null!;

    public string VaryantBarkod { get; set; } = null!;

    public string? VaryantKodu { get; set; }

    public string? Ürünİsmi { get; set; }

    public string? ÜrünMarka { get; set; }

    public string? ÜrünRenkleri { get; set; }

    public string? ÜrünModelleri { get; set; }

    public int? RafNo { get; set; }

    public int? MerkezDepo { get; set; }

    public int MerkezKritikStokAdedi { get; set; }
}
