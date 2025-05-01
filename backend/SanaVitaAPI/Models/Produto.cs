using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class Produto
{
    public int? ProdId { get; set; }

    public string? Nome { get; set; }

    public string? DosagemCedencia { get; set; }

    public string? Dosagem { get; set; }

    public int? FormaFarmId { get; set; }

    public int? AgrupFormaFarmId { get; set; }

    public int? DciptId { get; set; }

    public int? TipoProdutoId { get; set; }

    public int? TipoAutorizId { get; set; }

    public int? ClassEstpPsictrId { get; set; }

    public int? TitularAimId { get; set; }

    public DateTime? DataAim { get; set; }

    public int? EstadoAimId { get; set; }

    public DateTime? DataEstAim { get; set; }

    public string? NrProcesso { get; set; }

    public int? TipoProcedimentoId { get; set; }

    public string? IndGenerico { get; set; }

    public string? IndMargemTerap { get; set; }

    public string? IndMonitAdicionalFv { get; set; }

    public string? IndFnm { get; set; }

    public DateTime? DataAlteracao { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? ProdGuid { get; set; }

    public virtual RefAgrupFormaFarm? AgrupFormaFarm { get; set; }

    public virtual RefClassEstpPsictr? ClassEstpPsictr { get; set; }

    public virtual RefDcipt? Dcipt { get; set; }

    public virtual ICollection<Embalagem> Embalagems { get; set; } = new List<Embalagem>();

    public virtual RefEstadoAim? EstadoAim { get; set; }

    public virtual RefFormaFarm? FormaFarm { get; set; }

    public virtual RefTipoAutoriz? TipoAutoriz { get; set; }

    public virtual RefTipoProcedimento? TipoProcedimento { get; set; }

    public virtual RefTipoProduto? TipoProduto { get; set; }

    public virtual RefTitularAim? TitularAim { get; set; }
}
