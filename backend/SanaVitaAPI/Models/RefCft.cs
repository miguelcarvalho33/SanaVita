using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefCft
{
    public string CftCod { get; set; } = null!;

    public string? Descr { get; set; }

    public string? IndAtivo { get; set; }
}
