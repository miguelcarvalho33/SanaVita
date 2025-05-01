using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class LnkProdSubgrupoProd
{
    public int? ProdId { get; set; }

    public int? SubgrupoProdutoId { get; set; }

    public virtual Produto? Prod { get; set; }

    public virtual RefSubgrupoProduto? SubgrupoProduto { get; set; }
}
