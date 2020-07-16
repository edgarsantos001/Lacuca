using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Condominios.DataBase.Model
{
  public class CondominioModel
  {
    public int CONDOMINIO_ID { get; set; }
    public string NM_CONDOMINIO { get; set; }
    public string LOGO_CONDOMINIO { get; set; }
    public string ENDERECO_CONDOMINIO { get; set; }
    public bool ATIVO_CONDOMINIO { get; set; }
    public List<UsuarioModel> CONDOMINIO_USUARIO { get; set; }
  }
}
