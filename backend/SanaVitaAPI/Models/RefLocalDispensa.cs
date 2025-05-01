using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefLocalDispensa
{
    public int? LocalDispensaId { get; set; }

    public string? Descr { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<RefNormaRegExc> RefNormaRegExcs { get; set; } = new List<RefNormaRegExc>();
}
