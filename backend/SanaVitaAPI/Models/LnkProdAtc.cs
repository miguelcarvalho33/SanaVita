using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class LnkProdAtc
{
    public int? ProdId { get; set; }

    public string? AtcCod { get; set; }

    public virtual RefAtc? AtcCodNavigation { get; set; }

    public virtual Produto? Prod { get; set; }
}
