using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class Alertum
{
    public int? AlertaId { get; set; }

    public DateTime? DataInicio { get; set; }

    public DateTime? DataFim { get; set; }

    public int? TipoApresentacaoId { get; set; }

    public int? SexoId { get; set; }

    public int? TipoAlertaId { get; set; }

    public int? FaixaEtariaInicio { get; set; }

    public int? FaixaEtariaFim { get; set; }

    public virtual ICollection<MensagemAlertum> MensagemAlerta { get; set; } = new List<MensagemAlertum>();

    public virtual RefSexo? Sexo { get; set; }

    public virtual RefTipoAlertum? TipoAlerta { get; set; }

    public virtual RefTipoApresentacao? TipoApresentacao { get; set; }
}
