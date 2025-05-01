using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class Embalagem
{
    public int? EmbId { get; set; }

    public int? ProdId { get; set; }

    public string? NrRegisto { get; set; }

    public string? Descr { get; set; }

    public string? GrupoHomCod { get; set; }

    public double? QuantTot { get; set; }

    public int? UnidQuantTotId { get; set; }

    public double? Quantidade { get; set; }

    public int? UnidQuantId { get; set; }

    public int? TipoEmbId { get; set; }

    public int? AcondPrimarioId { get; set; }

    public int? TipoTratamentoId { get; set; }

    public int? EstadoEmbId { get; set; }

    public string? IndEmbUnitaria { get; set; }

    public string? IndEmbHospitalar { get; set; }

    public string? IndDispSeguranca { get; set; }

    public string? PemAmb { get; set; }

    public string? PemAmbMs { get; set; }

    public string? PemAmbBio { get; set; }

    public string? PemAmbBioMs { get; set; }

    public int? Cnpem { get; set; }

    public int? ChnmCod { get; set; }

    public int? Cdm { get; set; }

    public string? Referencia { get; set; }

    public string? CaractEspecificas { get; set; }

    public virtual RefAcondPrimario? AcondPrimario { get; set; }

    public virtual RefChnm? ChnmCodNavigation { get; set; }

    public virtual ICollection<Comercializacao> Comercializacaos { get; set; } = new List<Comercializacao>();

    public virtual ICollection<Comparticipacao> Comparticipacaos { get; set; } = new List<Comparticipacao>();

    public virtual ICollection<CondArmazenamento> CondArmazenamentos { get; set; } = new List<CondArmazenamento>();

    public virtual ICollection<Escoamento> Escoamentos { get; set; } = new List<Escoamento>();

    public virtual RefEstadoEmb? EstadoEmb { get; set; }

    public virtual RefGrupoHom? GrupoHomCodNavigation { get; set; }

    public virtual ICollection<LnkEmbCnpem> LnkEmbCnpems { get; set; } = new List<LnkEmbCnpem>();

    public virtual ICollection<MensagemAlertum> MensagemAlerta { get; set; } = new List<MensagemAlertum>();

    public virtual ICollection<Preco> Precos { get; set; } = new List<Preco>();

    public virtual Produto? Prod { get; set; }

    public virtual RefTipoEmb? TipoEmb { get; set; }

    public virtual RefTipoTratamento? TipoTratamento { get; set; }

    public virtual RefUnidade? UnidQuant { get; set; }

    public virtual RefUnidade? UnidQuantTot { get; set; }
}
