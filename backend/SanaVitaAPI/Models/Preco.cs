using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class Preco
{
    public int? PrecoId { get; set; }

    public int? EmbId { get; set; }

    public int? TipoPrecoId { get; set; }

    public double? Preco1 { get; set; }

    public DateTime? DataInicio { get; set; }

    public DateTime? DataFim { get; set; }

    public string? Ativo { get; set; }

    public string? AtivoMs { get; set; }

    public virtual Embalagem? Emb { get; set; }

    public virtual RefTipoPreco? TipoPreco { get; set; }
}
