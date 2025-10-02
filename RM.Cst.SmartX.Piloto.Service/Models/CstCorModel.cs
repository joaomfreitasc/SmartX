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
    protected override void DoConfigure(IConfigurationModelBuilder builder)
    {
      builder.SetProperty(y => y
        .WithProperty(nameof(CstCorObject.CodCor))
          .WithReadOnly(true)
          .WithAutoinc(true));
    }
    protected override void DoBeforeCreate(BeforeCreateParams parms)
    {
      this.CodColigada = 1;
      this.Context.CodColigada = 1;
    }
  }
}
