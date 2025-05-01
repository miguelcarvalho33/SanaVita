using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefTipoEmb
{
    public int? TipoEmbId { get; set; }

    public string? Descr { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<Embalagem> Embalagems { get; set; } = new List<Embalagem>();
}
