using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class MensagemAlertum
{
    public int? MensagemAlertaId { get; set; }

    public int? EmbId { get; set; }

    public string? Mensagem { get; set; }

    public string? Link { get; set; }

    public int? TipoDestinatarioId { get; set; }

    public int? AlertaId { get; set; }

    public string? Idioma { get; set; }

    public virtual Alertum? Alerta { get; set; }

    public virtual Embalagem? Emb { get; set; }

    public virtual RefTipoDestinatario? TipoDestinatario { get; set; }
}
