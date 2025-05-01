using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefChnm
{
    public int? ChnmCod { get; set; }

    public string? Descr { get; set; }

    public DateTime? Data { get; set; }

    public virtual ICollection<Embalagem> Embalagems { get; set; } = new List<Embalagem>();
}
