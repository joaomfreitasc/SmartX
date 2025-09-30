using RM.Cst.SmartX.Piloto.Service.Models;
using RM.Lib.SmartX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
