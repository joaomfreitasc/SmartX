using RM.Lib.SmartX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Cst.SmartX.Piloto.Service
{
    [SXObjectAttr("CorObject", "ZCOR", typeof(Properties.Resources), nameof(Properties.Resources.CorObject))]
    [SXFinderAttr(new[] { nameof(CodColigada), nameof(CodCor) })]
    public class CorObject : SXObject
    {
        [SXPropertyAttr("CODCOLIGADA",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoDaColigada),
            nameof(Properties.Resources.CodigoDaColigada),
            Required = true,
            //Hidden = true,
            IsPrimaryKey = true)]
            public int CodColigada { get; set; }

        [SXPropertyAttr("COD_COR",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoDaCor),
            nameof(Properties.Resources.CodigoDaCor),
            Required = true,
            IsPrimaryKey = true)]
        public int CodCor { get; set; }

        [SXPropertyAttr("DESCRICAO",
            typeof(Properties.Resources),
            nameof(Properties.Resources.Descricao),
            nameof(Properties.Resources.Descricao),
            Required = true,
            IsPrimaryKey = false)]
        public int Descricao { get; set; }

    }
}
