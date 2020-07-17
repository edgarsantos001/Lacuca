using Lacuca.Service.DataBase.Model;
using Lacuca.Service.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.Business
{
  public class CondominioBusiness
  {
    ICondominioRepositorio _condominioRepositorio;

    public CondominioBusiness()
    {
      _condominioRepositorio = new CondominioRepositorio();
    }
    public List<CondominioModel> GetCondominio()
    {
      return _condominioRepositorio.GetAll().ToList();
    }
    public CondominioModel FindCondominio(int id)
    {
      return _condominioRepositorio.Find(id);
    }

    public void InsertCondominio(CondominioModel model)
    {
      _condominioRepositorio.Insert(model);
      _condominioRepositorio.SaveChanges();
    }
    public void AlterCondominio(CondominioModel model)
    {
      _condominioRepositorio.Update(model);
      _condominioRepositorio.SaveChanges();
    }

    public void DeleteCondominio(CondominioModel model)
    {
      _condominioRepositorio.Delete(u => u == model);
      _condominioRepositorio.SaveChanges();
    }
  }
}
