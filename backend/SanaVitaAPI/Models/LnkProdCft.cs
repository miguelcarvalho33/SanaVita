using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class LnkProdCft
{
    public int? ProdId { get; set; }

    public string? CftCod { get; set; }

    public string? CftChnm { get; set; }

    public virtual RefCft? CftCodNavigation { get; set; }

    public virtual Produto? Prod { get; set; }
}
