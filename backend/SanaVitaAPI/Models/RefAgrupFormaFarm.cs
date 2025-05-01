using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefAgrupFormaFarm
{
    public int? AgrupFormaFarmId { get; set; }

    public string? Descr { get; set; }

    public string? Abrev { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
