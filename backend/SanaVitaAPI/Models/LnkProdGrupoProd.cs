using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class LnkProdGrupoProd
{
    public int? ProdId { get; set; }

    public int? GrupoProdutoId { get; set; }

    public virtual RefGrupoProduto? GrupoProduto { get; set; }

    public virtual Produto? Prod { get; set; }
}
