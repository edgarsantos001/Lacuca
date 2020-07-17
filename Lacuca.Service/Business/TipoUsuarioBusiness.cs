using Lacuca.Service.DataBase.Model;
using Lacuca.Service.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.Business
{
  public class TipoUsuarioBusiness
  {
    ITipoUsuarioRepositorio _tipoUsuarioRepositorio;

    public TipoUsuarioBusiness()
    {
      _tipoUsuarioRepositorio = new TipoUsuarioRepositorio();
    }
    public List<TipoUsuarioModel> GetTipoUsuario()
    {
      return _tipoUsuarioRepositorio.GetAll().ToList();
    }
    public TipoUsuarioModel FindTipoUsuario(int id)
    {
      return _tipoUsuarioRepositorio.Find(id);
    }

    public void InsertTipoUsuario(TipoUsuarioModel model)
    {
      _tipoUsuarioRepositorio.Insert(model);
      _tipoUsuarioRepositorio.SaveChanges();
    }
    public void AlterTipoUsuario(TipoUsuarioModel model)
    {
      _tipoUsuarioRepositorio.Update(model);
      _tipoUsuarioRepositorio.SaveChanges();
    }

    public void DeleteTipoUsuario(TipoUsuarioModel model)
    {
      _tipoUsuarioRepositorio.Delete(u => u == model);
      _tipoUsuarioRepositorio.SaveChanges();

    }
  }
}
