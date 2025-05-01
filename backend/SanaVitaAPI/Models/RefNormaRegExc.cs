using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefNormaRegExc
{
    public int? NormaRegExcId { get; set; }

    public string? Descr { get; set; }

    public int? LocalDispensaId { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<Comparticipacao> Comparticipacaos { get; set; } = new List<Comparticipacao>();

    public virtual RefLocalDispensa? LocalDispensa { get; set; }
}
