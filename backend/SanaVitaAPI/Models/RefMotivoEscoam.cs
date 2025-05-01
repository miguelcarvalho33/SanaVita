using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefMotivoEscoam
{
    public int? MotivoEscoamId { get; set; }

    public string? Descr { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<Escoamento> Escoamentos { get; set; } = new List<Escoamento>();
}
