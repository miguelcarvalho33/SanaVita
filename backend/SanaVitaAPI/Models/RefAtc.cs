using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefAtc
{
    public string AtcCod { get; set; } = null!;

    public string? Descr { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<LnkProdAtc> LnkProdAtcs { get; set; } = new List<LnkProdAtc>();

}
