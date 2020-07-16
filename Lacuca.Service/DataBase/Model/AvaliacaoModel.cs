using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.DataBase.Model
{
  public class AvaliacaoModel
  {
    public int AVALIACAO_ID { get; set; }
    public DateTime DT_AVALIACAO_ { get; set; }
    public int PONTUACAO_AVALIACAO { get; set; }
    public int DESC_AVALIACAO { get; set; }
    public bool ATIVO_AVALIACAO { get; set; }
    public UsuarioModel USUARIO_AVALIACAO { get; set; }
  }
}
