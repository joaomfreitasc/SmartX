using RM.Lib;
using RM.Lib.SmartX;

namespace RM.Cst.SmartX.Piloto.Service.Models
{
  [SXModelAttr("CstMarcaModel", CodSistema.Fop, typeof(Properties.Resources), nameof(Properties.Resources.MarcaModel))]
  [SXModelSecurityAttr(0)]
  public class CstMarcaModel : CstMarcaObject, ISXModel
  {
    protected override void DoConfigure(IConfigurationModelBuilder builder)
    {
      builder.SetProperty(y => y
        .WithProperty(nameof(CstMarcaObject.CodMarca))
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
