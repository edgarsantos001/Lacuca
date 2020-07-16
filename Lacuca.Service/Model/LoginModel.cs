using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.Model
{
  public class LoginModel
  {
    public string Username { get; set; }
    public string Password { get; set; }
    public bool Valido  { get; set; }
  }
}
