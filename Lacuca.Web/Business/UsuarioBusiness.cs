using Lacuca.Web.DataBase.Model;
using Lacuca.Web.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Web.Business
{
  public class UsuarioBusiness
  {
    IUsuarioRepositorio _usuarioRepositorio;

    public UsuarioBusiness()
    {
      _usuarioRepositorio = new UsuarioRepositorio();
    }
    public List<UsuarioModel> GetUsers() 
    {
      return _usuarioRepositorio.GetAll().ToList();
    }
    public UsuarioModel FindUser(int id) 
    {
      return _usuarioRepositorio.Find(id);
    }

    public void InsertUser(UsuarioModel model) 
    {
      _usuarioRepositorio.Insert(model);
      _usuarioRepositorio.SaveChanges();
    }
    public void AlterUser(UsuarioModel model) 
    {
      _usuarioRepositorio.Update(model);
      _usuarioRepositorio.SaveChanges();
    }

    public void DeleteUser(UsuarioModel model) 
    {
      _usuarioRepositorio.Delete(u=> u == model);
      _usuarioRepositorio.SaveChanges();
    }
  }
}
