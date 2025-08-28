using RM.Lib.SmartX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Cst.SmartX.Piloto.Service
{
    [SXObjectAttr("VeiculoObject", "ZVEICULO", typeof(Properties.Resources), nameof(Properties.Resources.VeiculoObject))]
    [SXFinderAttr(new[] { nameof(CodColigada), nameof(CodVeiculo) })]
    public class VeiculoObject : SXObject
    {
        [SXPropertyAttr("CODCOLIGADA",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoDaColigada),
            nameof(Properties.Resources.CodigoDaColigada),
            Required = false,
            Hidden = true,
            IsPrimaryKey = true)]
        public int? CodColigada { get; set; }

        [SXPropertyAttr("COD_VEICULO",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoDoVeiculo),
            nameof(Properties.Resources.CodigoDoVeiculo),
            Required = true,
            IsPrimaryKey = true)]
        public int CodVeiculo { get; set; }

        [SXPropertyAttr("COD_MARCA",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoDaMarca),
            nameof(Properties.Resources.CodigoDaMarca),
            Required = true,
            IsPrimaryKey = false)]
        public int CodMarca { get; set; }

        [SXPropertyAttr("COD_COR",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoDaCor),
            nameof(Properties.Resources.CodigoDaCor),
            Required = true,
            IsPrimaryKey = false)]
        public int CodCor { get; set; }

        [SXPropertyAttr("ANOFABRICACAO",
            typeof(Properties.Resources),
            nameof(Properties.Resources.AnoDaFabricacao),
            nameof(Properties.Resources.AnoDaFabricacao),
            Required = true,
            Mask = "9999",
            MaxLength = 4,
            MinLength =4,
            IsPrimaryKey = false)]
        public string AnoFabricacao { get; set; }

        [SXPropertyAttr("ANOMODELO",
            typeof(Properties.Resources),
            nameof(Properties.Resources.AnoDoModelo),
            nameof(Properties.Resources.AnoDoModelo),
            Required = true,
            Mask = "9999",
            MaxLength = 4,
            MinLength = 4,
            IsPrimaryKey = false)]
        public string AnoModelo { get; set; }

        [SXPropertyAttr("COMBUSTIVEL",
            typeof(Properties.Resources),
            nameof(Properties.Resources.Combustivel),
            nameof(Properties.Resources.Combustivel),
            Required = true,
            IsPrimaryKey = false)]
        [SXOptionValues(new object[] { 0, 1, 2, 3 }, typeof(Properties.Resources),
        new string[] { nameof(Properties.Resources.CstGasolina),
                     nameof(Properties.Resources.CstAlcool),
                     nameof(Properties.Resources.CstFlex),
                     nameof(Properties.Resources.CstDiesel)})]
        public int Combustivel { get; set; }

        [SXPropertyAttr("SIMBOLO",
            typeof(Properties.Resources),
            nameof(Properties.Resources.Simbolo),
            nameof(Properties.Resources.Simbolo),
            Required = true,
            IsPrimaryKey = false)]
        public string Simbolo { get; set; }

        [SXPropertyAttr("VENDIDO",
            typeof(Properties.Resources),
            nameof(Properties.Resources.Vendido),
            nameof(Properties.Resources.Vendido),
            Required = true,
            IsPrimaryKey = false)]
        public int Vendido { get; set; }
    }
}
