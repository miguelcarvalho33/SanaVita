using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefNivelCompart
{
    public int? NivelCompartId { get; set; }

    public string? Descr { get; set; }

    public int? PercentCompart { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<Comparticipacao> Comparticipacaos { get; set; } = new List<Comparticipacao>();
}
