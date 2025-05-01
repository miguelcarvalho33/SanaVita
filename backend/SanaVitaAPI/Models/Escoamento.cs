using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class Escoamento
{
    public int? EscoamId { get; set; }

    public int? EmbId { get; set; }

    public int? MotivoEscoamId { get; set; }

    public DateTime? DataInicio { get; set; }

    public DateTime? DataFim { get; set; }

    public virtual Embalagem? Emb { get; set; }

    public virtual RefMotivoEscoam? MotivoEscoam { get; set; }
}
