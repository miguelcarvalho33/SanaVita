using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class Comercializacao
{
    public int? ComercId { get; set; }

    public int? EmbId { get; set; }

    public int? EstadoComercId { get; set; }

    public DateTime? DataInicio { get; set; }

    public DateTime? DataFim { get; set; }

    public virtual Embalagem? Emb { get; set; }

    public virtual RefEstadoComerc? EstadoComerc { get; set; }
}
