using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefUnidade
{
    public int? UnidadeId { get; set; }

    public string? Descr { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<Embalagem> EmbalagemUnidQuantTots { get; set; } = new List<Embalagem>();

    public virtual ICollection<Embalagem> EmbalagemUnidQuants { get; set; } = new List<Embalagem>();
}
