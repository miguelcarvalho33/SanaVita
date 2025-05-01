using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class DocumentoAlertum
{
    public string? Titulo { get; set; }

    public DateTime? DataAprovacao { get; set; }

    public string? Url { get; set; }

    public string? DestinatarioMedico { get; set; }

    public string? DestinatarioFarmaceutico { get; set; }

    public string? DestinatarioCidadao { get; set; }

    public string? EntregaMedico { get; set; }

    public string? EntregaFarmaceutico { get; set; }

    public int? AlertaId { get; set; }

    public virtual Alertum? Alerta { get; set; }
}
