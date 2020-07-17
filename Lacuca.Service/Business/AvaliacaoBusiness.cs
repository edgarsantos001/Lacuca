using Lacuca.Service.DataBase.Model;
using Lacuca.Service.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.Business
{
  public class AvaliacaoBusiness
  {
    IAvaliacaoRepositorio  _avaliacaoRepositorio;

    public AvaliacaoBusiness()
    {
      _avaliacaoRepositorio = new AvaliacaoRepositorio();
    }
    public List<AvaliacaoModel> GetAvaliacao()
    {
      return _avaliacaoRepositorio.GetAll().ToList();
    }
    public AvaliacaoModel FindAvaliacao(int id)
    {
      return _avaliacaoRepositorio.Find(id);
    }

    public void InsertAvaliacao(AvaliacaoModel model)
    {
      _avaliacaoRepositorio.Insert(model);
      _avaliacaoRepositorio.SaveChanges();
    }
    public void AlterAvaliacao(AvaliacaoModel model)
    {
      _avaliacaoRepositorio.Update(model);
      _avaliacaoRepositorio.SaveChanges();
    }

    public void DeleteAvaliacao(AvaliacaoModel model)
    {
      _avaliacaoRepositorio.Delete(u => u == model);
      _avaliacaoRepositorio.SaveChanges();
    }
  }
}
