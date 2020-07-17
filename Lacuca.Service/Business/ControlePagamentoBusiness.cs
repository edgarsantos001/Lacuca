using Lacuca.Service.DataBase.Model;
using Lacuca.Service.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.Business
{
  public class ControlePagamentoBusiness
  {
    IControlePagamentoRepositorio _controlePagamentoRepositorio;

    public ControlePagamentoBusiness()
    {
      _controlePagamentoRepositorio = new ControlePagamentoRepositorio();
    }
    public List<ControlePagamentoModel> GetControlePagamento()
    {
      return _controlePagamentoRepositorio.GetAll().ToList();
    }
    public ControlePagamentoModel FindControlePagamento(int id)
    {
      return _controlePagamentoRepositorio.Find(id);
    }

    public void InsertControlePagamento(ControlePagamentoModel model)
    {
      _controlePagamentoRepositorio.Insert(model);
      _controlePagamentoRepositorio.SaveChanges();
    }
    public void AlterControlePagamento(ControlePagamentoModel model)
    {
      _controlePagamentoRepositorio.Update(model);
      _controlePagamentoRepositorio.SaveChanges();
    }

    public void DeleteControlePagamento(ControlePagamentoModel model)
    {
      _controlePagamentoRepositorio.Delete(u => u == model);
      _controlePagamentoRepositorio.SaveChanges();
    }
  }
}
