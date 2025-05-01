using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class CondArmazenamento
{
    public int? CondArmazId { get; set; }

    public int? EmbId { get; set; }

    public int? EstadoArmazId { get; set; }

    public int? TemperaturaArmazId { get; set; }

    public string? NrPrazoVal { get; set; }

    public int? UnidTempPrazoValId { get; set; }

    public virtual Embalagem? Emb { get; set; }

    public virtual RefEstadoArmaz? EstadoArmaz { get; set; }

    public virtual RefTemperaturaArmaz? TemperaturaArmaz { get; set; }

    public virtual RefUnidadeTemporal? UnidTempPrazoVal { get; set; }
}
