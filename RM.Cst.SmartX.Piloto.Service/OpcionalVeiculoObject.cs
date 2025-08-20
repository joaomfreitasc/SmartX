using RM.Lib.SmartX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Cst.SmartX.Piloto.Service
{
    [SXObjectAttr("OpcionalVeiculoObject", "ZOPCIONALVEICULO", typeof(Properties.Resources), nameof(Properties.Resources.OpcionalVeiculoObject))]
    [SXFinderAttr(new[] { nameof(CodColigada), nameof(Codigo) })]
    internal class OpcionalVeiculoObject : SXObject
    {
        [SXPropertyAttr("CODCOLIGADA",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoDaColigada),
            nameof(Properties.Resources.CodigoDaColigada),
            Required = true,
            //Hidden = true,
            IsPrimaryKey = true)]
        public int CodColigada { get; set; }

        [SXPropertyAttr("CODIGO",
            typeof(Properties.Resources),
            nameof(Properties.Resources.Codigo),
            nameof(Properties.Resources.Codigo),
            Required = true,
            //Hidden = true,
            IsPrimaryKey = true)]
        public int Codigo { get; set; }

        [SXPropertyAttr("COD_OPCIONAL",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoOpcionalVeiculo),
            nameof(Properties.Resources.CodigoOpcionalVeiculo),
            Required = true,
            IsPrimaryKey = true)]
        public int Cod_OpcionalVeiculo { get; set; }

        [SXPropertyAttr("COD_VEICULO",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoVeiculo),
            nameof(Properties.Resources.CodigoVeiculo),
            Required = true,
            IsPrimaryKey = false)]
        public int CodVeiculo { get; set; }
    }
}
