using RM.Lib;
using RM.Lib.Client;
using RM.Lib.Client.Custom;
using RM.Lib.WinForms.Chromium;

namespace RM.Cst.SmartX.Piloto.Form
{
  [HostClientEnabled]
  [ActionInfo(typeof(Properties.Resources), nameof(Properties.Resources.CadastroVeiculos), CodSistema.Fop, 0)]
  
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

    protected override SmartXConfig SmartXConfig()
    {
      var config = base.SmartXConfig();
      config.showMenu = false;
      return config;
    }
  }
}
