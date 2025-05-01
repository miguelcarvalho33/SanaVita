using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefEstadoComerc
{
    public int? EstComercId { get; set; }

    public string? Descr { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<Comercializacao> Comercializacaos { get; set; } = new List<Comercializacao>();
}
