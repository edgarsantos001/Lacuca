using Lacuca.Web.DataBase.Model;
using Lacuca.Web.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Web.Business
{
  public class PedidoBusiness
  {
    IPedidoRepositorio _pedidoRepositorio;

    public PedidoBusiness()
    {
      _pedidoRepositorio = new PedidoRepositorio();
    }
    public List<PedidoModel> GetPedido()
    {
      return _pedidoRepositorio.GetAll().ToList();
    }
    public PedidoModel FindPedido(int id)
    {
      return _pedidoRepositorio.Find(id);
    }

    public void InsertPedido(PedidoModel model)
    {
      _pedidoRepositorio.Insert(model);
      _pedidoRepositorio.SaveChanges();
    }
    public void AlterPedido(PedidoModel model)
    {
      _pedidoRepositorio.Update(model);
      _pedidoRepositorio.SaveChanges();
    }

    public void DeletePedido(PedidoModel model)
    {
      _pedidoRepositorio.Delete(u => u == model);
      _pedidoRepositorio.SaveChanges();
    }
  }
}
