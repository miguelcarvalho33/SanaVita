using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class ProdutoOperacao
{
    public int? ProdId { get; set; }

    public string? Operacao { get; set; }

    public DateTime? Data { get; set; }
}
