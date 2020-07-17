using Lacuca.Service.DataBase.Model;
using Lacuca.Service.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.Business
{
  public class ProdutoBusiness
  {
    IProdutoRepositorio _produtoRepositorio;

    public ProdutoBusiness()
    {
      _produtoRepositorio = new ProdutoRepositorio();
    }
    public List<ProdutoModel> GetProduto()
    {
      return _produtoRepositorio.GetAll().ToList();
    }
    public ProdutoModel FindProduto(int id)
    {
      return _produtoRepositorio.Find(id);
    }

    public void InsertProduto(ProdutoModel model)
    {
      _produtoRepositorio.Insert(model);
      _produtoRepositorio.SaveChanges();
    }
    public void AlterProduto(ProdutoModel model)
    {
      _produtoRepositorio.Update(model);
      _produtoRepositorio.SaveChanges();
    }

    public void DeleteProduto(ProdutoModel model)
    {
      _produtoRepositorio.Delete(u => u == model);
      _produtoRepositorio.SaveChanges();
    }
  }
}
