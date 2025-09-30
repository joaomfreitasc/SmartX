using RM.Cst.SmartX.Piloto.Service.Models;
using RM.Lib.SmartX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Cst.SmartX.Piloto.Service.Routines
{
  [SXRoutineAttr("CstCorRoutine", typeof(Properties.Resources), "CstCadastroCores", "1.0")]
  public class CstCorRoutine : CstCorModel, ISXRoutineLayoutDataOperations
  {
    public void ConfigureLayout(IRoutineLayoutDataOperationsBuilder builder)
    {
    }
  }
}
