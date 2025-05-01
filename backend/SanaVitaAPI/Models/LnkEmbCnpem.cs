using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class LnkEmbCnpem
{
    public int? EmbCnpemId { get; set; }

    public int? EmbId { get; set; }

    public int? Cnpem { get; set; }

    public DateTime? DataInicio { get; set; }

    public DateTime? DataFim { get; set; }

    public virtual Embalagem? Emb { get; set; }
}
