using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class LnkProdClassDisp
{
    public int? ProdId { get; set; }

    public int? ClassDispProdId { get; set; }

    public virtual RefClassDispensaProd? ClassDispProd { get; set; }

    public virtual Produto? Prod { get; set; }
}
