using RM.Lib.SmartX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Cst.SmartX.Piloto.Service
{
  [SXObjectAttr("CstOpcionalObject", "ZOPCIONAL", typeof(Properties.Resources), nameof(Properties.Resources.OpcionalObject))]
  [SXFinderAttr(new[] { nameof(CodColigada), nameof(CodOpcional) })]
  public class CstOpcionalObject : SXObject
  {
    [SXPropertyAttr("CODCOLIGADA",
        typeof(Properties.Resources),
        nameof(Properties.Resources.CodigoDaColigada),
        nameof(Properties.Resources.CodigoDaColigada),
        Required = true,
        Hidden = true,
        DefaultValue = -1,
        IsPrimaryKey = true)]
    public int CodColigada { get; set; }

    [SXPropertyAttr("COD_OPCIONAL",
        typeof(Properties.Resources),
        nameof(Properties.Resources.CodigoOpcional),
        nameof(Properties.Resources.CodigoOpcional),
        Required = true,
        IsPrimaryKey = true)]
    public int CodOpcional { get; set; }

    [SXPropertyAttr("DESCRICAO",
        typeof(Properties.Resources),
        nameof(Properties.Resources.Descricao),
        nameof(Properties.Resources.Descricao),
        Required = true,
        IsPrimaryKey = false)]
    public string Descricao { get; set; }
  }
}
