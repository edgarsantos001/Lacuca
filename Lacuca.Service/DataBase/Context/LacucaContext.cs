using Lacuca.Service.Authentication;
using Lacuca.Service.DataBase.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lacuca.Service.DataBase.Context
{
  public class LacucaContext : IdentityDbContext<ApplicationUser> //DbContext
  {
    public LacucaContext(DbContextOptions<LacucaContext> options) : base(options)
    { }

    public DbSet<UsuarioModel> Usuario { get; set; }
    public DbSet<PedidoModel> Pedido { get; set; }
    public DbSet<ProdutoModel> Produto { get; set; }
    public DbSet<CategoriaProdutoModel> CategoriaProduto { get; set; }
    public DbSet<CondominioModel> Condominio { get; set; }
    protected override void OnModelCreating(ModelBuilder construtorDeModelos)
    {
      base.OnModelCreating(construtorDeModelos);

      construtorDeModelos.HasDefaultSchema("lacuca");
      ConfiguraUsuario(construtorDeModelos);
      ConfiguraPedido(construtorDeModelos);
      ConfiguraCategoria(construtorDeModelos);
      ConfiguraCondominio(construtorDeModelos);
      ConfiguraLoja(construtorDeModelos);
      ConfiguraAvaliacao(construtorDeModelos);
      ConfiguraControle(construtorDeModelos);
      ConfiguraProduto(construtorDeModelos);
      ConfiguraTipoUsuario(construtorDeModelos);

      
    }

    private void ConfiguraUsuario(ModelBuilder construtorDeModelos)
    {
      construtorDeModelos.Entity<UsuarioModel>(usu=>{
        usu.ToTable("USUARIO");
        usu.HasKey(u => u.USUARIO_ID);
        usu.Property(u => u.USUARIO_ID).ValueGeneratedOnAdd();
        usu.HasOne(u => u.CONDOMINIO_USUARIO).WithMany(u => u.CONDOMINIO_USUARIO).HasForeignKey(fk=>fk.CONDOMINIO_USUARIO_ID);
        usu.HasOne(u => u.TIPO_USUARIO_USUARIO).WithMany(t => t.TIPO_USUARIO).HasForeignKey(fk => fk.TIPO_USUARIO_USUARIO_ID);
      });
    }

    private void ConfiguraPedido(ModelBuilder construtorDeModelos)
    {
      construtorDeModelos.Entity<PedidoModel>(pd => {
        pd.ToTable("PEDIDO");
        pd.HasKey(pd => pd.PEDIDO_ID);
        pd.Property(pd => pd.PEDIDO_ID).ValueGeneratedOnAdd();
        pd.HasOne(u => u.PEDIDO_USUARIO).WithMany(u => u.PEDIDO_USUARIO);
        pd.HasOne(l => l.PEDIDO_LOJA).WithMany(l => l.PEDIDO_LOJA);
        pd.HasOne(p => p.PEDIDO_PRODUTO).WithMany(p => p.PEDIDO_PRODUTO);
      
      });
    }

    private void ConfiguraCategoria(ModelBuilder construtorDeModelos)
    {
      construtorDeModelos.Entity<CategoriaProdutoModel>(ct => {
        ct.ToTable("CATEGORIAPRODUTO");
        ct.HasKey(pd => pd.CATEGORIA_PRODUTO_ID);
        ct.Property(pd => pd.CATEGORIA_PRODUTO_ID).ValueGeneratedOnAdd();
        ct.HasOne(u => u.CATEGORIA_PRODUTO).WithMany(u => u.CATEGORIA_PRODUTO_PROD);
        
      });
    }

    private void ConfiguraCondominio(ModelBuilder construtorDeModelos)
    {
      construtorDeModelos.Entity<CondominioModel>(c => {
        c.ToTable("CONDOMINIO");
        c.HasKey(pd => pd.CONDOMINIO_ID);
        c.Property(pd => pd.CONDOMINIO_ID).ValueGeneratedOnAdd();
      //  usu.HasOne(u => u.CONDOMINIO_USUARIO).WithMany(usu => usu.CONDOMINIO_USUARIO).HasForeignKey(p => p.CONDOMINIO_USUARIO_ID);
      });
    }

    private void ConfiguraLoja(ModelBuilder construtorDeModelos)
    {
      construtorDeModelos.Entity<LojaModel>(c => {
        c.ToTable("LOJA");
        c.HasKey(l => l.LOJA_ID);
        c.Property(l => l.LOJA_ID).ValueGeneratedOnAdd();
        c.HasOne(u => u.USUARIO_LOJA).WithMany(u => u.LOJA_USUARIO);
      });
    }

    private void ConfiguraAvaliacao(ModelBuilder construtorDeModelos)
    {
      construtorDeModelos.Entity<AvaliacaoModel>(c => {
        c.ToTable("AVALIACAO");
        c.HasKey(a => a.AVALIACAO_ID);
        c.Property(a => a.AVALIACAO_ID).ValueGeneratedOnAdd();
        c.HasOne(u => u.USUARIO_AVALIACAO).WithMany(u => u.AVALIACAO_USUARIO);
      });
    }

    private void ConfiguraControle(ModelBuilder construtorDeModelos)
    {
      construtorDeModelos.Entity<ControlePagamentoModel>(c => {
        c.ToTable("CONTROLE_PAGAMENTO");
        c.HasKey(a => a.CONTROLE_PAGAMENTO_ID);
        c.Property(a => a.CONTROLE_PAGAMENTO_ID).ValueGeneratedOnAdd();
        c.HasOne(u => u.USUARIO_CONTROLE).WithMany(u => u.CONTROLE_PAGAMENTO_USUARIO);
      });
    }

    private void ConfiguraTipoUsuario(ModelBuilder construtorDeModelos)
    {
      construtorDeModelos.Entity<TipoUsuarioModel>(c => {
        c.ToTable("TIPO_USUARIO");
        c.HasKey(a => a.TIPO_USUARIO_ID);
        c.Property(a => a.TIPO_USUARIO_ID).ValueGeneratedOnAdd();
       // c.HasOne(u => u.TIPO_USUARIO).WithMany(u => u.TIPO_USUARIO_USUARIO);
      });
    }

    private void ConfiguraProduto(ModelBuilder construtorDeModelos)
    {
      construtorDeModelos.Entity<ProdutoModel>(c => {
        c.ToTable("PRODUTO");
        c.HasKey(p => p.PRODUTO_ID);
        c.Property(p => p.PRODUTO_ID).ValueGeneratedOnAdd();
        c.HasOne(p => p.LOJA_PRODUTO).WithMany(u => u.PRODUTO_LOJA);
      });
    }


  }
}
