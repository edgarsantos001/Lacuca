using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Condominios.DataBase.Model
{
  public class TipoUsuarioModel
  {
    public int TIPO_USUARIO_ID { get; set; }
    public string DESC_TIPO_USUARIO { get; set; }
    public bool ATIVO_TIPO_USUARIO { get; set; }
    public List<UsuarioModel> TIPO_USUARIO { get; set; }
  }
}
