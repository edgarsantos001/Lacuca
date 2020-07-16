using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.DataBase.Model
{
  public class UsuarioModel
  {
    public int USUARIO_ID { get; set; }
    public string NM_USUARIO { get; set; }
    public string CELULAR_USUARIO { get; set; }
    public string EMAIL_USUARIO { get; set; }
    public string LOGIN_USUARIO { get; set; }
    public string SENHA_USUARIO { get; set; }
    public DateTime DT_CADASTRO_USUARIO { get; set; }
    public bool ATIVO_USUARIO { get; set; }
    public int CONDOMINIO_USUARIO_ID { get; set; }
    public CondominioModel CONDOMINIO_USUARIO { get; set; }
    public int TIPO_USUARIO_USUARIO_ID { get; set; }
    public TipoUsuarioModel TIPO_USUARIO_USUARIO { get; set; }
    public List<PedidoModel> PEDIDO_USUARIO { get; set; }
    public List<LojaModel> LOJA_USUARIO { get; set; }
    public List<AvaliacaoModel> AVALIACAO_USUARIO { get; set; }
    public List<ControlePagamentoModel> CONTROLE_PAGAMENTO_USUARIO { get; set; }
    
  }
}
