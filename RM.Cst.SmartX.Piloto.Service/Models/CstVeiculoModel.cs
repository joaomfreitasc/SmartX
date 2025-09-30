using RM.Lib;
using RM.Lib.SmartX;
using System.Collections.Generic;

//DataServer
namespace RM.Cst.SmartX.Piloto.Service.Models
{
  [SXModelAttr("CstVeiculoModel", CodSistema.Fop, typeof(Properties.Resources), nameof(Properties.Resources.VeiculoModel))]
  [SXModelSecurityAttr(0)]
  //herda de uma classe e uma interface
  public class CstVeiculoModel : CstVeiculoObject, ISXModel
  {
    [SXRelationAttr("fk_veiculo_opcional",
          new string[] { "CODCOLIGADA", "COD_VEICULO" },
          new string[] { "CODCOLIGADA", "COD_VEICULO" },
        typeof(Properties.Resources),
        nameof(Properties.Resources.OpcionaisVeiculo))]
    public List<CstOpcionalVeiculoObject> Opcionais { get; set; } = new List<CstOpcionalVeiculoObject>();

    protected override void DoBeforeCreate(BeforeCreateParams parms)
    {
      ValidaAnoFaBricacao();
      this.CodColigada = 1;
    }

    protected override void DoBeforeUpdate(BeforeUpdateParams parms)
    {
      ValidaAnoFaBricacao();
    }

    private void ValidaAnoFaBricacao()
    {
      if (RMSConvert.ToInt32(this.AnoModelo) > RMSConvert.ToInt32(this.AnoFabricacao + 1)) {
        throw new RMSValidateException(Properties.Resources.AnoModeloNaoPodeSerMaiorQueAnoFabricacao);
      }
    }
  }
}
