using RM.Lib;
using RM.Lib.SmartX;

namespace RM.Cst.SmartX.Piloto.Service.Models
{
  [SXModelAttr("GlbMoedaModel", CodSistema.Fop, typeof(Properties.Resources), nameof(Properties.Resources.MoedaModel))]
  [SXModelSecurityAttr(0)]
  public class GlbMoedaModel : GlbMoedaObject, ISXModel
  {
  }
}
