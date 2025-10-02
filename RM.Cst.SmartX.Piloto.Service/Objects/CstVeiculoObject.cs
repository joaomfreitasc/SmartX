using RM.Lib.SmartX;

//DataSet
namespace RM.Cst.SmartX.Piloto.Service
{
  [SXObjectAttr("CstVeiculoObject", "ZVEICULO", typeof(Properties.Resources), nameof(Properties.Resources.VeiculoObject))]
  [SXFinderAttr(new[] { nameof(CodColigada), nameof(CodVeiculo) })]//chaves primárias
  public class CstVeiculoObject : SXObject
  {
    [SXPropertyAttr("CODCOLIGADA",//nome no banco de dados
        typeof(Properties.Resources),
        nameof(Properties.Resources.CodigoDaColigada),
        nameof(Properties.Resources.CodigoDaColigada),
        Required = true, //é obrigado a ter um valor
        DefaultValue = -1,
        Hidden = true, //não vai aparecer na tela
        IsPrimaryKey = true)] //primary key
    public int CodColigada { get; set; }

    [SXPropertyAttr("COD_VEICULO",
        typeof(Properties.Resources),
        nameof(Properties.Resources.CodigoDoVeiculo),
        nameof(Properties.Resources.CodigoDoVeiculo),
        Required = false,
        //DefaultValue = -1,
        //ReadOnly = true,
        IsPrimaryKey = true)]
    public int? CodVeiculo { get; set; } //Esse campo precisa ser int? proque o valor não sera passado pela tela.

    [SXPropertyAttr("COD_MARCA",
        typeof(Properties.Resources),
        nameof(Properties.Resources.CodigoDaMarca),
        nameof(Properties.Resources.CodigoDaMarca),
        Required = true,
        IsPrimaryKey = false)]
    public int CodMarca { get; set; }

    [SXPropertyAttr("COD_COR",
        typeof(Properties.Resources),
        nameof(Properties.Resources.CodigoDaCor),
        nameof(Properties.Resources.CodigoDaCor),
        Required = true,
        IsPrimaryKey = false)]
    public int CodCor { get; set; }

    [SXPropertyAttr("ANOFABRICACAO",
        typeof(Properties.Resources),
        nameof(Properties.Resources.AnoDaFabricacao),
        nameof(Properties.Resources.AnoDaFabricacao),
        Required = true,
        Mask = "9999", //só pode digitar 4 números
        MaxLength = 4,
        MinLength = 4,
        IsPrimaryKey = false)]
    public string AnoFabricacao { get; set; }

    [SXPropertyAttr("ANOMODELO",
        typeof(Properties.Resources),
        nameof(Properties.Resources.AnoDoModelo),
        nameof(Properties.Resources.AnoDoModelo),
        Required = true,
        Mask = "9999",
        MaxLength = 4,
        MinLength = 4,
        IsPrimaryKey = false)]
    public string AnoModelo { get; set; }

    [SXPropertyAttr("COMBUSTIVEL",
        typeof(Properties.Resources),
        nameof(Properties.Resources.Combustivel),
        nameof(Properties.Resources.Combustivel),
        Required = true,
        IsPrimaryKey = false)]
    [SXOptionValues(new object[] { 0, 1, 2, 3 }, typeof(Properties.Resources),
    new string[] { nameof(Properties.Resources.CstGasolina),
                     nameof(Properties.Resources.CstAlcool),
                     nameof(Properties.Resources.CstFlex),
                     nameof(Properties.Resources.CstDiesel)})]
    public int Combustivel { get; set; }

    [SXPropertyAttr("SIMBOLO",
        typeof(Properties.Resources),
        nameof(Properties.Resources.Simbolo),
        nameof(Properties.Resources.Simbolo),
        Required = true,
        IsPrimaryKey = false)]
    public string Simbolo { get; set; }

    [SXPropertyAttr("VENDIDO",
        typeof(Properties.Resources),
        nameof(Properties.Resources.Vendido),
        nameof(Properties.Resources.Vendido),
        Required = true,
        IsPrimaryKey = false)]
    public int Vendido { get; set; } //? significa que aceita null
  }
}
