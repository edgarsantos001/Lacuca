using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Condominios.DataBase.Model
{
  public class LojaModel
  {
    public int LOJA_ID { get; set; }
    public string NM_LOJA { get; set; }
    public string DESC_LOJA { get; set; }
    public string LOGO_LOJA { get; set; }
    public bool ATIVO_LOJA { get; set; }
    public UsuarioModel  USUARIO_LOJA { get; set; }
    public List<PedidoModel> PEDIDO_LOJA { get; set; }
    public List<ProdutoModel> PRODUTO_LOJA { get; set; }


  }
}
