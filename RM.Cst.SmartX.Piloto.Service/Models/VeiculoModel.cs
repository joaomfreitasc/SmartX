using RM.Lib;
using RM.Lib.SmartX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Cst.SmartX.Piloto.Service.Models
{
    [SXModelAttr("VeiculoModel", CodSistema.Fop, typeof(Properties.Resources), nameof(Properties.Resources.VeiculoModel))]
    [SXModelSecurityAttr(0)]
    public class VeiculoModel : VeiculoObject, ISXModel
    {
        [SXRelationAttr("fk_veiculo_opcional",
              new string[] { "CODCOLIGADA", "COD_VEICULO" },
              new string[] { "CODCOLIGADA", "COD_VEICULO" },
            typeof(Properties.Resources),
            nameof(Properties.Resources.OpcionaisVeiculo))]
        public List<OpcionalVeiculoObject> Opcionais { get; set; } = new List<OpcionalVeiculoObject>();
    }
}
