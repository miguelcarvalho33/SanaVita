using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefSexo
{
    public int? SexoId { get; set; }

    public string? Descr { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<Alertum> Alerta { get; set; } = new List<Alertum>();
}
