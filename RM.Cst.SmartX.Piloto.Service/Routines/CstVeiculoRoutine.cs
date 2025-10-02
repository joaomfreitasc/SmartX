using RM.Cst.SmartX.Piloto.Service.Models;
using RM.Lib.SmartX;

namespace RM.Cst.SmartX.Piloto.Service.Routines
{
  [SXRoutineAttr("CstVeiculoRoutine", typeof(Properties.Resources), "CstCadastroVeiculos", "1.0")]
  public class CstVeiculoRoutine : CstVeiculoModel, ISXRoutineLayoutDataOperations
  {
    public void ConfigureLayout(IRoutineLayoutDataOperationsBuilder builder)
    {
    }
  }
}
