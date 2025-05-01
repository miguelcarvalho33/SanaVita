using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefTipoPreco
{
    public int? TipoPrecoId { get; set; }

    public string? Descr { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<Preco> Precos { get; set; } = new List<Preco>();
}
