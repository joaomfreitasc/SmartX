using RM.Lib;
using RM.Lib.Client;
using RM.Lib.WinForms.Chromium;

namespace RM.Cst.SmartX.Piloto.Service
{
  [HostClientEnabled]
  [ActionInfo(typeof(Properties.Resources), nameof(Properties.Resources.CadastroVeiculos), CodSistema.Cst, 0)]
  public class CstVeiculoAction : RMSActionSmartX
  {

    protected override string RoutineName()
    {
      return "CstVeiculoRoutine";
    }

    protected override object SmartXContext()
    {
      return new
      {
        RMSSession.Context.CodColigada,
        RMSSession.Context.CodSistema
      };
    }
  }
}
