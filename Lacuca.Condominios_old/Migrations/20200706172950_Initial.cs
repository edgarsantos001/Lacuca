using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Lacuca.Condominios.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "lacuca");

            migrationBuilder.CreateTable(
                name: "USUARIO",
                schema: "lacuca",
                columns: table => new
                {
                    USUARIO_ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NM_USUARIO = table.Column<string>(nullable: true),
                    CELULAR_USUARIO = table.Column<string>(nullable: true),
                    EMAIL_USUARIO = table.Column<string>(nullable: true),
                    LOGIN_USUARIO = table.Column<string>(nullable: true),
                    SENHA_USUARIO = table.Column<string>(nullable: true),
                    DT_CADASTRO_USUARIO = table.Column<DateTime>(nullable: false),
                    ATIVO_USUARIO = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.USUARIO_ID);
                });

            migrationBuilder.CreateTable(
                name: "AVALIACAO",
                schema: "lacuca",
                columns: table => new
                {
                    AVALIACAO_ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DT_AVALIACAO_ = table.Column<DateTime>(nullable: false),
                    PONTUACAO_AVALIACAO = table.Column<int>(nullable: false),
                    DESC_AVALIACAO = table.Column<int>(nullable: false),
                    ATIVO_AVALIACAO = table.Column<bool>(nullable: false),
                    USUARIO_AVALIACAOUSUARIO_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AVALIACAO", x => x.AVALIACAO_ID);
                    table.ForeignKey(
                        name: "FK_AVALIACAO_USUARIO_USUARIO_AVALIACAOUSUARIO_ID",
                        column: x => x.USUARIO_AVALIACAOUSUARIO_ID,
                        principalSchema: "lacuca",
                        principalTable: "USUARIO",
                        principalColumn: "USUARIO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CONDOMINIO",
                schema: "lacuca",
                columns: table => new
                {
                    CONDOMINIO_ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NM_CONDOMINIO = table.Column<string>(nullable: true),
                    LOGO_CONDOMINIO = table.Column<string>(nullable: true),
                    ENDERECO_CONDOMINIO = table.Column<string>(nullable: true),
                    ATIVO_CONDOMINIO = table.Column<bool>(nullable: false),
                    CONDOMINIO_USUARIOUSUARIO_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONDOMINIO", x => x.CONDOMINIO_ID);
                    table.ForeignKey(
                        name: "FK_CONDOMINIO_USUARIO_CONDOMINIO_USUARIOUSUARIO_ID",
                        column: x => x.CONDOMINIO_USUARIOUSUARIO_ID,
                        principalSchema: "lacuca",
                        principalTable: "USUARIO",
                        principalColumn: "USUARIO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_PAGAMENTO",
                schema: "lacuca",
                columns: table => new
                {
                    CONTROLE_PAGAMENTO_ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DT_PAGAMENTO = table.Column<DateTime>(nullable: false),
                    DT_VENCIMENTO = table.Column<DateTime>(nullable: false),
                    VALOR = table.Column<double>(nullable: false),
                    DESCONTO = table.Column<int>(nullable: false),
                    ATIVO_CONTROLE_PAGAMENTO = table.Column<bool>(nullable: false),
                    USUARIO_CONTROLEUSUARIO_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTROLE_PAGAMENTO", x => x.CONTROLE_PAGAMENTO_ID);
                    table.ForeignKey(
                        name: "FK_CONTROLE_PAGAMENTO_USUARIO_USUARIO_CONTROLEUSUARIO_ID",
                        column: x => x.USUARIO_CONTROLEUSUARIO_ID,
                        principalSchema: "lacuca",
                        principalTable: "USUARIO",
                        principalColumn: "USUARIO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LOJA",
                schema: "lacuca",
                columns: table => new
                {
                    LOJA_ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NM_LOJA = table.Column<string>(nullable: true),
                    DESC_LOJA = table.Column<string>(nullable: true),
                    LOGO_LOJA = table.Column<string>(nullable: true),
                    ATIVO_LOJA = table.Column<bool>(nullable: false),
                    USUARIO_LOJAUSUARIO_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOJA", x => x.LOJA_ID);
                    table.ForeignKey(
                        name: "FK_LOJA_USUARIO_USUARIO_LOJAUSUARIO_ID",
                        column: x => x.USUARIO_LOJAUSUARIO_ID,
                        principalSchema: "lacuca",
                        principalTable: "USUARIO",
                        principalColumn: "USUARIO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TIPO_USUARIO",
                schema: "lacuca",
                columns: table => new
                {
                    TIPO_USUARIO_ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DESC_TIPO_USUARIO = table.Column<string>(nullable: true),
                    ATIVO_TIPO_USUARIO = table.Column<bool>(nullable: false),
                    TIPO_USUARIOUSUARIO_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPO_USUARIO", x => x.TIPO_USUARIO_ID);
                    table.ForeignKey(
                        name: "FK_TIPO_USUARIO_USUARIO_TIPO_USUARIOUSUARIO_ID",
                        column: x => x.TIPO_USUARIOUSUARIO_ID,
                        principalSchema: "lacuca",
                        principalTable: "USUARIO",
                        principalColumn: "USUARIO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTO",
                schema: "lacuca",
                columns: table => new
                {
                    PRODUTO_ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NM_PRODUTO = table.Column<string>(nullable: true),
                    DESC_PRODUTO = table.Column<string>(nullable: true),
                    IMAGEM_PRODUTO = table.Column<string>(nullable: true),
                    PRECO_PRODUTO = table.Column<double>(nullable: false),
                    ATIVO_PRODUTO = table.Column<bool>(nullable: false),
                    LOJA_PRODUTOLOJA_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTO", x => x.PRODUTO_ID);
                    table.ForeignKey(
                        name: "FK_PRODUTO_LOJA_LOJA_PRODUTOLOJA_ID",
                        column: x => x.LOJA_PRODUTOLOJA_ID,
                        principalSchema: "lacuca",
                        principalTable: "LOJA",
                        principalColumn: "LOJA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORIAPRODUTO",
                schema: "lacuca",
                columns: table => new
                {
                    CATEGORIA_PRODUTO_ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DESC_CATEGORIA_PRODUTO = table.Column<string>(nullable: true),
                    ATIVO_CATEGORIA_PRODUTO = table.Column<bool>(nullable: false),
                    CATEGORIA_PRODUTOPRODUTO_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIAPRODUTO", x => x.CATEGORIA_PRODUTO_ID);
                    table.ForeignKey(
                        name: "FK_CATEGORIAPRODUTO_PRODUTO_CATEGORIA_PRODUTOPRODUTO_ID",
                        column: x => x.CATEGORIA_PRODUTOPRODUTO_ID,
                        principalSchema: "lacuca",
                        principalTable: "PRODUTO",
                        principalColumn: "PRODUTO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PEDIDO",
                schema: "lacuca",
                columns: table => new
                {
                    PEDIDO_ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PEDIDO_USUARIOUSUARIO_ID = table.Column<int>(nullable: true),
                    PEDIDO_LOJALOJA_ID = table.Column<int>(nullable: true),
                    PEDIDO_PRODUTOPRODUTO_ID = table.Column<int>(nullable: true),
                    DT_PEDIDO = table.Column<DateTime>(nullable: false),
                    ATIVO_PEDIDO = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDO", x => x.PEDIDO_ID);
                    table.ForeignKey(
                        name: "FK_PEDIDO_LOJA_PEDIDO_LOJALOJA_ID",
                        column: x => x.PEDIDO_LOJALOJA_ID,
                        principalSchema: "lacuca",
                        principalTable: "LOJA",
                        principalColumn: "LOJA_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PEDIDO_PRODUTO_PEDIDO_PRODUTOPRODUTO_ID",
                        column: x => x.PEDIDO_PRODUTOPRODUTO_ID,
                        principalSchema: "lacuca",
                        principalTable: "PRODUTO",
                        principalColumn: "PRODUTO_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PEDIDO_USUARIO_PEDIDO_USUARIOUSUARIO_ID",
                        column: x => x.PEDIDO_USUARIOUSUARIO_ID,
                        principalSchema: "lacuca",
                        principalTable: "USUARIO",
                        principalColumn: "USUARIO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AVALIACAO_USUARIO_AVALIACAOUSUARIO_ID",
                schema: "lacuca",
                table: "AVALIACAO",
                column: "USUARIO_AVALIACAOUSUARIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIAPRODUTO_CATEGORIA_PRODUTOPRODUTO_ID",
                schema: "lacuca",
                table: "CATEGORIAPRODUTO",
                column: "CATEGORIA_PRODUTOPRODUTO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CONDOMINIO_CONDOMINIO_USUARIOUSUARIO_ID",
                schema: "lacuca",
                table: "CONDOMINIO",
                column: "CONDOMINIO_USUARIOUSUARIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_PAGAMENTO_USUARIO_CONTROLEUSUARIO_ID",
                schema: "lacuca",
                table: "CONTROLE_PAGAMENTO",
                column: "USUARIO_CONTROLEUSUARIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LOJA_USUARIO_LOJAUSUARIO_ID",
                schema: "lacuca",
                table: "LOJA",
                column: "USUARIO_LOJAUSUARIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDO_PEDIDO_LOJALOJA_ID",
                schema: "lacuca",
                table: "PEDIDO",
                column: "PEDIDO_LOJALOJA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDO_PEDIDO_PRODUTOPRODUTO_ID",
                schema: "lacuca",
                table: "PEDIDO",
                column: "PEDIDO_PRODUTOPRODUTO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PEDIDO_PEDIDO_USUARIOUSUARIO_ID",
                schema: "lacuca",
                table: "PEDIDO",
                column: "PEDIDO_USUARIOUSUARIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_LOJA_PRODUTOLOJA_ID",
                schema: "lacuca",
                table: "PRODUTO",
                column: "LOJA_PRODUTOLOJA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TIPO_USUARIO_TIPO_USUARIOUSUARIO_ID",
                schema: "lacuca",
                table: "TIPO_USUARIO",
                column: "TIPO_USUARIOUSUARIO_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AVALIACAO",
                schema: "lacuca");

            migrationBuilder.DropTable(
                name: "CATEGORIAPRODUTO",
                schema: "lacuca");

            migrationBuilder.DropTable(
                name: "CONDOMINIO",
                schema: "lacuca");

            migrationBuilder.DropTable(
                name: "CONTROLE_PAGAMENTO",
                schema: "lacuca");

            migrationBuilder.DropTable(
                name: "PEDIDO",
                schema: "lacuca");

            migrationBuilder.DropTable(
                name: "TIPO_USUARIO",
                schema: "lacuca");

            migrationBuilder.DropTable(
                name: "PRODUTO",
                schema: "lacuca");

            migrationBuilder.DropTable(
                name: "LOJA",
                schema: "lacuca");

            migrationBuilder.DropTable(
                name: "USUARIO",
                schema: "lacuca");
        }
    }
}
