﻿// <auto-generated />
using System;
using Lacuca.Service.DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Lacuca.Service.Migrations
{
    [DbContext(typeof(LacucaContext))]
    [Migration("20200715185410_Lacuca")]
    partial class Lacuca
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("lacuca")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.AvaliacaoModel", b =>
                {
                    b.Property<int>("AVALIACAO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("ATIVO_AVALIACAO")
                        .HasColumnType("boolean");

                    b.Property<int>("DESC_AVALIACAO")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DT_AVALIACAO_")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PONTUACAO_AVALIACAO")
                        .HasColumnType("integer");

                    b.Property<int?>("USUARIO_AVALIACAOUSUARIO_ID")
                        .HasColumnType("integer");

                    b.HasKey("AVALIACAO_ID");

                    b.HasIndex("USUARIO_AVALIACAOUSUARIO_ID");

                    b.ToTable("AVALIACAO");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.CategoriaProdutoModel", b =>
                {
                    b.Property<int>("CATEGORIA_PRODUTO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("ATIVO_CATEGORIA_PRODUTO")
                        .HasColumnType("boolean");

                    b.Property<int?>("CATEGORIA_PRODUTOPRODUTO_ID")
                        .HasColumnType("integer");

                    b.Property<string>("DESC_CATEGORIA_PRODUTO")
                        .HasColumnType("text");

                    b.HasKey("CATEGORIA_PRODUTO_ID");

                    b.HasIndex("CATEGORIA_PRODUTOPRODUTO_ID");

                    b.ToTable("CATEGORIAPRODUTO");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.CondominioModel", b =>
                {
                    b.Property<int>("CONDOMINIO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("ATIVO_CONDOMINIO")
                        .HasColumnType("boolean");

                    b.Property<string>("ENDERECO_CONDOMINIO")
                        .HasColumnType("text");

                    b.Property<string>("LOGO_CONDOMINIO")
                        .HasColumnType("text");

                    b.Property<string>("NM_CONDOMINIO")
                        .HasColumnType("text");

                    b.HasKey("CONDOMINIO_ID");

                    b.ToTable("CONDOMINIO");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.ControlePagamentoModel", b =>
                {
                    b.Property<int>("CONTROLE_PAGAMENTO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("ATIVO_CONTROLE_PAGAMENTO")
                        .HasColumnType("boolean");

                    b.Property<int>("DESCONTO")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DT_PAGAMENTO")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DT_VENCIMENTO")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("USUARIO_CONTROLEUSUARIO_ID")
                        .HasColumnType("integer");

                    b.Property<double>("VALOR")
                        .HasColumnType("double precision");

                    b.HasKey("CONTROLE_PAGAMENTO_ID");

                    b.HasIndex("USUARIO_CONTROLEUSUARIO_ID");

                    b.ToTable("CONTROLE_PAGAMENTO");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.LojaModel", b =>
                {
                    b.Property<int>("LOJA_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("ATIVO_LOJA")
                        .HasColumnType("boolean");

                    b.Property<string>("DESC_LOJA")
                        .HasColumnType("text");

                    b.Property<string>("LOGO_LOJA")
                        .HasColumnType("text");

                    b.Property<string>("NM_LOJA")
                        .HasColumnType("text");

                    b.Property<int?>("USUARIO_LOJAUSUARIO_ID")
                        .HasColumnType("integer");

                    b.HasKey("LOJA_ID");

                    b.HasIndex("USUARIO_LOJAUSUARIO_ID");

                    b.ToTable("LOJA");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.PedidoModel", b =>
                {
                    b.Property<int>("PEDIDO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("ATIVO_PEDIDO")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("DT_PEDIDO")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("PEDIDO_LOJALOJA_ID")
                        .HasColumnType("integer");

                    b.Property<int?>("PEDIDO_PRODUTOPRODUTO_ID")
                        .HasColumnType("integer");

                    b.Property<int?>("PEDIDO_USUARIOUSUARIO_ID")
                        .HasColumnType("integer");

                    b.HasKey("PEDIDO_ID");

                    b.HasIndex("PEDIDO_LOJALOJA_ID");

                    b.HasIndex("PEDIDO_PRODUTOPRODUTO_ID");

                    b.HasIndex("PEDIDO_USUARIOUSUARIO_ID");

                    b.ToTable("PEDIDO");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.ProdutoModel", b =>
                {
                    b.Property<int>("PRODUTO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("ATIVO_PRODUTO")
                        .HasColumnType("boolean");

                    b.Property<string>("DESC_PRODUTO")
                        .HasColumnType("text");

                    b.Property<string>("IMAGEM_PRODUTO")
                        .HasColumnType("text");

                    b.Property<int?>("LOJA_PRODUTOLOJA_ID")
                        .HasColumnType("integer");

                    b.Property<string>("NM_PRODUTO")
                        .HasColumnType("text");

                    b.Property<double>("PRECO_PRODUTO")
                        .HasColumnType("double precision");

                    b.HasKey("PRODUTO_ID");

                    b.HasIndex("LOJA_PRODUTOLOJA_ID");

                    b.ToTable("PRODUTO");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.TipoUsuarioModel", b =>
                {
                    b.Property<int>("TIPO_USUARIO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("ATIVO_TIPO_USUARIO")
                        .HasColumnType("boolean");

                    b.Property<string>("DESC_TIPO_USUARIO")
                        .HasColumnType("text");

                    b.HasKey("TIPO_USUARIO_ID");

                    b.ToTable("TIPO_USUARIO");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.UsuarioModel", b =>
                {
                    b.Property<int>("USUARIO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("ATIVO_USUARIO")
                        .HasColumnType("boolean");

                    b.Property<string>("CELULAR_USUARIO")
                        .HasColumnType("text");

                    b.Property<int>("CONDOMINIO_USUARIO_ID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DT_CADASTRO_USUARIO")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("EMAIL_USUARIO")
                        .HasColumnType("text");

                    b.Property<string>("LOGIN_USUARIO")
                        .HasColumnType("text");

                    b.Property<string>("NM_USUARIO")
                        .HasColumnType("text");

                    b.Property<string>("SENHA_USUARIO")
                        .HasColumnType("text");

                    b.Property<int>("TIPO_USUARIO_USUARIO_ID")
                        .HasColumnType("integer");

                    b.HasKey("USUARIO_ID");

                    b.HasIndex("CONDOMINIO_USUARIO_ID");

                    b.HasIndex("TIPO_USUARIO_USUARIO_ID");

                    b.ToTable("USUARIO");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<string>", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("IdentityRole<string>");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole<string>");

                    b.HasDiscriminator().HasValue("IdentityRole");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.AvaliacaoModel", b =>
                {
                    b.HasOne("Lacuca.Service.DataBase.Model.UsuarioModel", "USUARIO_AVALIACAO")
                        .WithMany("AVALIACAO_USUARIO")
                        .HasForeignKey("USUARIO_AVALIACAOUSUARIO_ID");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.CategoriaProdutoModel", b =>
                {
                    b.HasOne("Lacuca.Service.DataBase.Model.ProdutoModel", "CATEGORIA_PRODUTO")
                        .WithMany("CATEGORIA_PRODUTO_PROD")
                        .HasForeignKey("CATEGORIA_PRODUTOPRODUTO_ID");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.ControlePagamentoModel", b =>
                {
                    b.HasOne("Lacuca.Service.DataBase.Model.UsuarioModel", "USUARIO_CONTROLE")
                        .WithMany("CONTROLE_PAGAMENTO_USUARIO")
                        .HasForeignKey("USUARIO_CONTROLEUSUARIO_ID");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.LojaModel", b =>
                {
                    b.HasOne("Lacuca.Service.DataBase.Model.UsuarioModel", "USUARIO_LOJA")
                        .WithMany("LOJA_USUARIO")
                        .HasForeignKey("USUARIO_LOJAUSUARIO_ID");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.PedidoModel", b =>
                {
                    b.HasOne("Lacuca.Service.DataBase.Model.LojaModel", "PEDIDO_LOJA")
                        .WithMany("PEDIDO_LOJA")
                        .HasForeignKey("PEDIDO_LOJALOJA_ID");

                    b.HasOne("Lacuca.Service.DataBase.Model.ProdutoModel", "PEDIDO_PRODUTO")
                        .WithMany("PEDIDO_PRODUTO")
                        .HasForeignKey("PEDIDO_PRODUTOPRODUTO_ID");

                    b.HasOne("Lacuca.Service.DataBase.Model.UsuarioModel", "PEDIDO_USUARIO")
                        .WithMany("PEDIDO_USUARIO")
                        .HasForeignKey("PEDIDO_USUARIOUSUARIO_ID");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.ProdutoModel", b =>
                {
                    b.HasOne("Lacuca.Service.DataBase.Model.LojaModel", "LOJA_PRODUTO")
                        .WithMany("PRODUTO_LOJA")
                        .HasForeignKey("LOJA_PRODUTOLOJA_ID");
                });

            modelBuilder.Entity("Lacuca.Service.DataBase.Model.UsuarioModel", b =>
                {
                    b.HasOne("Lacuca.Service.DataBase.Model.CondominioModel", "CONDOMINIO_USUARIO")
                        .WithMany("CONDOMINIO_USUARIO")
                        .HasForeignKey("CONDOMINIO_USUARIO_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lacuca.Service.DataBase.Model.TipoUsuarioModel", "TIPO_USUARIO_USUARIO")
                        .WithMany("TIPO_USUARIO")
                        .HasForeignKey("TIPO_USUARIO_USUARIO_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
