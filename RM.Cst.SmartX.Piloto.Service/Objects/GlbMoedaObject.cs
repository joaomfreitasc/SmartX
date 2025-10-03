using RM.Lib.SmartX;

namespace RM.Cst.SmartX.Piloto.Service
{
  [SXObjectAttr("GlbMoedaObject", "GMOEDA", typeof(Properties.Resources), nameof(Properties.Resources.MoedaObject))]
  [SXFinderAttr(new[] { nameof(Simbolo) })]
  public class GlbMoedaObject : SXObject
  {
    [SXPropertyAttr("SIMBOLO",
        typeof(Properties.Resources),
        nameof(Properties.Resources.CodigoDaColigada),
        nameof(Properties.Resources.CodigoDaColigada),
        Required = true,
        IsPrimaryKey = true)]
    public string Simbolo { get; set; }

    [SXPropertyAttr("DESCRICAO",
        typeof(Properties.Resources),
        nameof(Properties.Resources.CodigoDaCor),
        nameof(Properties.Resources.CodigoDaCor),
        Required = false,
        IsPrimaryKey = false)]
    public string Descricao { get; set; }
  }
}

