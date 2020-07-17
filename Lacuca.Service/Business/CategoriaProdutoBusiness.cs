using Lacuca.Service.DataBase.Model;
using Lacuca.Service.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.Business
{
  public class CategoriaProdutoBusiness
  {
    ICategoriaProdutoRepositorio _categoriaProdutoRepositorio;

    public CategoriaProdutoBusiness()
    {
      _categoriaProdutoRepositorio = new CategoriaProdutoRepositorio();
    }
    public List<CategoriaProdutoModel> GetCategoriaProduto()
    {
      return _categoriaProdutoRepositorio.GetAll().ToList();
    }
    public CategoriaProdutoModel FindCategoriaProduto(int id)
    {
      return _categoriaProdutoRepositorio.Find(id);
    }
    public void InsertCategoriaProduto(CategoriaProdutoModel model)
    {
      _categoriaProdutoRepositorio.Insert(model);
      _categoriaProdutoRepositorio.SaveChanges();
    }
    public void AlterCategoriaProduto(CategoriaProdutoModel model)
    {
      _categoriaProdutoRepositorio.Update(model);
      _categoriaProdutoRepositorio.SaveChanges();
    }
    public void DeleteCategoriaProduto(CategoriaProdutoModel model)
    {
      _categoriaProdutoRepositorio.Delete(u => u == model);
      _categoriaProdutoRepositorio.SaveChanges();
    }
  }
}
