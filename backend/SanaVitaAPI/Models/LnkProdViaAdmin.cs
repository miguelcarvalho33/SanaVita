using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class LnkProdViaAdmin
{
    public int? ProdId { get; set; }

    public int? ViaAdminId { get; set; }

    public virtual Produto? Prod { get; set; }

    public virtual RefViaAdmin? ViaAdmin { get; set; }
}
