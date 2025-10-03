using RM.Cst.SmartX.Piloto.Service.Models;
using RM.Lib.SmartX;

namespace RM.Cst.SmartX.Piloto.Service.Routines
{
  [SXRoutineAttr("CstVeiculoRoutine", typeof(Properties.Resources), "CstCadastroVeiculos", "1.0")]
  public class CstVeiculoRoutine : CstVeiculoModel, ISXRoutineLayoutDataOperations
  {
    public void ConfigureLayout(IRoutineLayoutDataOperationsBuilder builder)
    {
      ConfigureGridSystem(builder);
    }

    private void ConfigureGridSystem(IRoutineLayoutDataOperationsBuilder builder)
    {
      builder.SetProperty(p => p.WithProperty(nameof(CstVeiculoModel.CodVeiculo)).AddGridSystem(g => g.WithSmallColumns(12).WithMediumColumns(12).WithLargeColumns(4).WithExtraLargeColumns(4)));
      builder.SetProperty(p => p.WithProperty(nameof(CstVeiculoModel.CodMarca)).AddGridSystem(g => g.WithSmallColumns(12).WithMediumColumns(12).WithLargeColumns(4).WithExtraLargeColumns(4)));
      builder.SetProperty(p => p.WithProperty(nameof(CstVeiculoModel.CodCor)).AddGridSystem(g => g.WithSmallColumns(12).WithMediumColumns(12).WithLargeColumns(4).WithExtraLargeColumns(4)));
      builder.SetProperty(p => p.WithProperty(nameof(CstVeiculoModel.AnoFabricacao)).AddGridSystem(g => g.WithSmallColumns(12).WithMediumColumns(12).WithLargeColumns(3).WithExtraLargeColumns(3)));
      builder.SetProperty(p => p.WithProperty(nameof(CstVeiculoModel.AnoModelo)).AddGridSystem(g => g.WithSmallColumns(12).WithMediumColumns(12).WithLargeColumns(3).WithExtraLargeColumns(3)));
      builder.SetProperty(p => p.WithProperty(nameof(CstVeiculoModel.Combustivel)).AddGridSystem(g => g.WithSmallColumns(12).WithMediumColumns(12).WithLargeColumns(3).WithExtraLargeColumns(3)));
      builder.SetProperty(p => p.WithProperty(nameof(CstVeiculoModel.Vendido)).AddGridSystem(g => g.WithSmallColumns(12).WithMediumColumns(12).WithLargeColumns(3).WithExtraLargeColumns(3)));
    }
  }
}
