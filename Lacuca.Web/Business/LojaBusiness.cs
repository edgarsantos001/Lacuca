using Lacuca.Web.DataBase.Model;
using Lacuca.Web.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Web.Business
{
  public class LojaBusiness
  {
    ILojaRepositorio _lojaRepositorio;

    public LojaBusiness()
    {
      _lojaRepositorio = new LojaRepositorio();
    }
    public List<LojaModel> GetLoja()
    {
      return _lojaRepositorio.GetAll().ToList();
    }
    public LojaModel FindLoja(int id)
    {
      return _lojaRepositorio.Find(id);
    }

    public void InsertLoja(LojaModel model)
    {
      _lojaRepositorio.Insert(model);
      _lojaRepositorio.SaveChanges();
    }
    public void AlterLoja(LojaModel model)
    {
      _lojaRepositorio.Update(model);
      _lojaRepositorio.SaveChanges();
    }

    public void DeleteLoja(LojaModel model)
    {
      _lojaRepositorio.Delete(u => u == model);
      _lojaRepositorio.SaveChanges();
    }
  }
}
