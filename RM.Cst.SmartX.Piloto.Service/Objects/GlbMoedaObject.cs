using RM.Lib.SmartX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Cst.SmartX.Piloto.Service
{
  [SXObjectAttr("GlbMoedaObject", "GMOEDA", typeof(Properties.Resources), nameof(Properties.Resources.MoedaObject))]
  [SXFinderAttr(new[] { nameof(Simbolo) })]
  public class GlbMoedaObject : SXObject
  {
    [SXPropertyAttr("SIMBOLO",
        typeof(Properties.Resources),
        nameof(Properties.Resources.CodigoDaColigada),
        nameof(Properties.Resources.CodigoDaColigada),
        Required = true,
        IsPrimaryKey = true)]
    public int Simbolo { get; set; }

    [SXPropertyAttr("DESCRICAO",
        typeof(Properties.Resources),
        nameof(Properties.Resources.CodigoDaCor),
        nameof(Properties.Resources.CodigoDaCor),
        Required = false,
        IsPrimaryKey = false)]
    public int? Descricao { get; set; }
  }
}

