using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.DataBase.Model
{
  public class ProdutoModel
  {
    public int PRODUTO_ID { get; set; }
    public string NM_PRODUTO { get; set; }
    public string DESC_PRODUTO { get; set; }
    public string IMAGEM_PRODUTO { get; set; }
    public double PRECO_PRODUTO { get; set; }
    public bool ATIVO_PRODUTO { get; set; }
    public LojaModel LOJA_PRODUTO { get; set; }
    public List<CategoriaProdutoModel> CATEGORIA_PRODUTO_PROD { get; set; }
    public List<PedidoModel> PEDIDO_PRODUTO { get; set; }
  
  }
}
