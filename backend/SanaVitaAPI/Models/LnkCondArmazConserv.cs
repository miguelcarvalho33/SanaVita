using System;
using System.Collections.Generic;

namespace SanaVitaAPI.Models;

public partial class LnkCondArmazConserv
{
    public int? CondArmazId { get; set; }

    public int? CondConservId { get; set; }

    public virtual CondArmazenamento? CondArmaz { get; set; }

    public virtual RefCondConservacao? CondConserv { get; set; }
}
