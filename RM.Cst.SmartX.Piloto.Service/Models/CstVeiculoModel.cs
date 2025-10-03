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
    /* Erlon: Não descomentar nesse momento. Iremos falar de mestre/detalhe mais pra frente.
      [SXRelationAttr("fk_veiculo_opcional",
          new string[] { "CODCOLIGADA", "COD_VEICULO" },
          new string[] { "CODCOLIGADA", "COD_VEICULO" },
        typeof(Properties.Resources),
        nameof(Properties.Resources.OpcionaisVeiculo))]
    public List<CstOpcionalVeiculoObject> Opcionais { get; set; } = new List<CstOpcionalVeiculoObject>();*/

    protected override void DoConfigure(IConfigurationModelBuilder builder)
    {
      builder.SetProperty(y => y //Configurar uma propriedade - Lambida
        .WithProperty(nameof(CstVeiculoObject.CodVeiculo))// Seleciono a propriedade
          .WithReadOnly(true) //Fazer ele ficar readonly
          .WithAutoinc(true)); //fazer ele ser autoincremento 

      builder.SetProperty(p => p
        .WithProperty(nameof(CstVeiculoObject.CodMarca))//qual a propriedade que eu quero que aparece o componente de lookup.
        .AddLookup(l => l//quero adicio0njar um lookup
          .WithModelRef("CstMarcaModel")//qual vai ser o modelo que ele vai trazer a lista de dados no lookup.
          .WithDisplayFields(new[] { nameof(CstMarcaModel.CodMarca), nameof(CstMarcaModel.Descricao)})//quais os campos que virão na grid do lookup.
          .WithFieldValue(nameof(CstMarcaModel.CodMarca))//qual campo eu quero que sai da lookup e encaixa no campo a ser gravado.
          .WithLookupFinder(new FinderResult(new[] { nameof(CstMarcaModel.CodColigada), nameof(CstMarcaModel.CodMarca)}))));

      builder.SetProperty(p => p
        .WithProperty(nameof(CstVeiculoObject.CodCor))
        .AddLookup(l => l
          .WithModelRef("CstCorModel")
          .WithDisplayFields(new[] { nameof(CstCorModel.CodCor), nameof(CstCorModel.Descricao)})
          .WithFieldValue(nameof(CstCorModel.CodCor))
          .WithLookupFinder(new FinderResult(new[] { nameof(CstCorModel.CodColigada), nameof(CstCorModel.CodCor)}))));

      builder.SetProperty(p => p
       .WithProperty(nameof(CstVeiculoObject.Simbolo))
       .AddLookup(l => l
         .WithModelRef("GlbMoedaModel")
         .WithDisplayFields(new[] { nameof(GlbMoedaModel.Simbolo), nameof(GlbMoedaModel.Descricao)})
         .WithFieldValue(nameof(GlbMoedaModel.Simbolo))
         .WithLookupFinder(new FinderResult(new[] { nameof(GlbMoedaModel.Simbolo), nameof(GlbMoedaModel.Descricao) }))));
    }

    protected override void DoBeforeCreate(BeforeCreateParams parms)
    {
      this.CodColigada = 1;
      this.Context.CodColigada = 1;//Codigo temporario poraue não está sendo chamado do RM.exe
      ValidaAnoFabricacao();
    }

    protected override void DoBeforeUpdate(BeforeUpdateParams parms)
    {
      ValidaAnoFabricacao();
    }

    private void ValidaAnoFabricacao()
    {
      if (RMSConvert.ToInt32(this.AnoModelo) > RMSConvert.ToInt32(this.AnoFabricacao + 1)) {
        throw new RMSValidateException(Properties.Resources.AnoModeloNaoPodeSerMaiorQueAnoFabricacao);
      }
    }
  }
}
