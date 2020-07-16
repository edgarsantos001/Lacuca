using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.DataBase.Model
{
  public class CategoriaProdutoModel
  {
    public int CATEGORIA_PRODUTO_ID { get; set; }
    public string DESC_CATEGORIA_PRODUTO { get; set; }
    public bool ATIVO_CATEGORIA_PRODUTO { get; set; }
    public ProdutoModel CATEGORIA_PRODUTO { get; set; }
  }
}
