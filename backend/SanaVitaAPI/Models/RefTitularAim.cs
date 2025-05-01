using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefTitularAim
{
    public int? TitularAimId { get; set; }

    public string? Descr { get; set; }

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
