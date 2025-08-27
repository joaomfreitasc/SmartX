using RM.Lib.SmartX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Cst.SmartX.Piloto.Service
{
    [SXObjectAttr("MarcaObject", "ZMARCA", typeof(Properties.Resources), nameof(Properties.Resources.MarcaObject))]
    [SXFinderAttr(new[] { nameof(CodColigada), nameof(CodMarca) })]
    public class MarcaObject : SXObject
    {
        [SXPropertyAttr("CODCOLIGADA",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoDaColigada),
            nameof(Properties.Resources.CodigoDaColigada),
            Required = true,
            //Hidden = true,
            IsPrimaryKey = true)]
        public int CodColigada { get; set; }

        [SXPropertyAttr("COD_MARCA",
            typeof(Properties.Resources),
            nameof(Properties.Resources.CodigoDaMarca),
            nameof(Properties.Resources.CodigoDaMarca),
            Required = true,
            IsPrimaryKey = true)]
        public int CodMarca { get; set; }

        [SXPropertyAttr("DESCRICAO",
            typeof(Properties.Resources),
            nameof(Properties.Resources.Descricao),
            nameof(Properties.Resources.Descricao),
            Required = true,
            IsPrimaryKey = false)]
        public string Descricao { get; set; }
    }
}
