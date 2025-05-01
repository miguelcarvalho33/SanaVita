using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class LnkProdSubst
{
    public int? ProdId { get; set; }

    public int? SubstId { get; set; }

    public string? Quantidade { get; set; }

    public int? UnidQuantId { get; set; }

    public virtual Produto? Prod { get; set; }

    public virtual RefSubstancium? Subst { get; set; }

    public virtual RefUnidade? UnidQuant { get; set; }
}
