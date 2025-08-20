using RM.Lib.SmartX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Cst.SmartX.Piloto.Service
{
    [SXObjectAttr("ParametrosObject", "ZPARAMETROS", typeof(Properties.Resources), nameof(Properties.Resources.ParametrosObject))]
    [SXFinderAttr(new[] { nameof(CodColigada), nameof(CodColigadaReport) })]
    internal class ParametrosObject : SXObject
    {
        [SXPropertyAttr("CODCOLIGADA",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoDaColigada),
            nameof(Properties.Resources.CodigoDaColigada),
            Required = true,
            //Hidden = true,
            IsPrimaryKey = true)]
        public int CodColigada { get; set; }

        [SXPropertyAttr("COD_COLIGADA_REPORT",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoColigadaReport),
            nameof(Properties.Resources.CodigoColigadaReport),
            Required = true,
            IsPrimaryKey = true)]
        public int CodColigadaReport { get; set; }

        [SXPropertyAttr("COD_REPORT",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoReport),
            nameof(Properties.Resources.CodigoReport),
            Required = true,
            IsPrimaryKey = false)]
        public int CodReport { get; set; }
    }
}
