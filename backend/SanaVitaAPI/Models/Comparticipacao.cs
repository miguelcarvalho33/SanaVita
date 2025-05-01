using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class Comparticipacao
{
    public int? CompartId { get; set; }

    public int? EmbId { get; set; }

    public int? TipoRegimeId { get; set; }

    public int? NormaRegExcId { get; set; }

    public int? RegimeExcecionalId { get; set; }

    public int? NivelCompartId { get; set; }

    public DateTime? DataInicio { get; set; }

    public DateTime? DataFim { get; set; }

    public virtual Embalagem? Emb { get; set; }

    public virtual RefNivelCompart? NivelCompart { get; set; }

    public virtual RefNormaRegExc? NormaRegExc { get; set; }

    public virtual RefRegimeExcecional? RegimeExcecional { get; set; }

    public virtual RefTipoRegime? TipoRegime { get; set; }
}
