using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefUnidadeTemporal
{
    public int? UnidadeTemporalId { get; set; }

    public string? Descr { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<CondArmazenamento> CondArmazenamentos { get; set; } = new List<CondArmazenamento>();
}
