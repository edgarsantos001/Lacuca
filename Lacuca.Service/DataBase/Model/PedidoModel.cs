using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.DataBase.Model
{
  public class PedidoModel
  {
    public int PEDIDO_ID { get; set; }
    public UsuarioModel PEDIDO_USUARIO { get; set; }
    public LojaModel PEDIDO_LOJA { get; set; }
    public ProdutoModel PEDIDO_PRODUTO { get; set; }
    public DateTime DT_PEDIDO { get; set; }
    public bool ATIVO_PEDIDO { get; set; }

  }
}
