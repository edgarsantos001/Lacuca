using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.DataBase.Model
{
  public class ControlePagamentoModel
  {
    public int CONTROLE_PAGAMENTO_ID { get; set; }
    public DateTime DT_PAGAMENTO { get; set; }
    public DateTime DT_VENCIMENTO { get; set; }
    public double VALOR { get; set; }
    public int DESCONTO { get; set; }
    public bool ATIVO_CONTROLE_PAGAMENTO { get; set; }
    public UsuarioModel USUARIO_CONTROLE { get; set; }
  }
}
