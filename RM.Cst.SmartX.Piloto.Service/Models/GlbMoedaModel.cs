using RM.Lib;
using RM.Lib.SmartX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Cst.SmartX.Piloto.Service.Models
{
  [SXModelAttr("GlbMoedaModel", CodSistema.Fop, typeof(Properties.Resources), nameof(Properties.Resources.MoedaModel))]
  [SXModelSecurityAttr(0)]
  public class GlbMoedaModel : GlbMoedaObject, ISXModel
  {
  }
}
