using RM.Lib;
using RM.Lib.SmartX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Cst.SmartX.Piloto.Service.Models
{
    [SXModelAttr("CstCorModel", CodSistema.Fop, typeof(Properties.Resources), nameof(Properties.Resources.CorModel))]
    [SXModelSecurityAttr(0)]
    public class CstCorModel : CstCorObject, ISXModel
    {

    }
}
