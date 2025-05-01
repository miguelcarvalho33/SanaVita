using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefFormaFarm
{
    public int? FormaFarmId { get; set; }

    public string? Descr { get; set; }

    public string? Abrev { get; set; }

    public string? AbrevChnm { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
