using RM.Lib.SmartX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Cst.SmartX.Piloto.Service
{
  [SXObjectAttr("CstOpcionalVeiculoObject", "ZOPCIONALVEICULO", typeof(Properties.Resources), nameof(Properties.Resources.OpcionalVeiculoObject))]
  [SXFinderAttr(new[] { nameof(CodColigada), nameof(CodOpcionalVeiculo), nameof(CodVeiculo) })]
  public class CstOpcionalVeiculoObject : SXObject
  {
    [SXPropertyAttr("CODCOLIGADA",
        typeof(Properties.Resources),
        nameof(Properties.Resources.CodigoDaColigada),
        nameof(Properties.Resources.CodigoDaColigada),
        Required = true,
        DefaultValue = -1,
        Hidden = true,
        IsPrimaryKey = true)]
    public int CodColigada { get; set; }

    [SXPropertyAttr("COD_OPCIONAL",
        typeof(Properties.Resources),
        nameof(Properties.Resources.CodigoOpcionalVeiculo),
        nameof(Properties.Resources.CodigoOpcionalVeiculo),
        Required = true,
        IsPrimaryKey = true)]
    public int CodOpcionalVeiculo { get; set; }

    [SXPropertyAttr("COD_VEICULO",
        typeof(Properties.Resources),
        nameof(Properties.Resources.CodigoVeiculo),
        nameof(Properties.Resources.CodigoVeiculo),
        Required = true,
        IsPrimaryKey = true)]
    public int CodVeiculo { get; set; }
  }
}
