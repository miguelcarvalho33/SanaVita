using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class RefGrupoHom
{
    public string GrupoHomCod { get; set; } = null!;

    public string? Descr { get; set; }

    public string? IndAtivo { get; set; }

    public virtual ICollection<Embalagem> Embalagems { get; set; } = new List<Embalagem>();
}
