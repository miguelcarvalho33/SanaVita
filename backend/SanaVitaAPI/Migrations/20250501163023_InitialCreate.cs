using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanaVitaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PRODUTO_OPERACAO",
                columns: table => new
                {
                    PROD_ID = table.Column<int>(type: "int", nullable: true),
                    OPERACAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "REF_ACOND_PRIMARIO",
                columns: table => new
                {
                    ACOND_PRIMARIO_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ABREV_CHNM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_ACOND_PRIMARIO_PK", x => x.ACOND_PRIMARIO_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_AGRUP_FORMA_FARM",
                columns: table => new
                {
                    AGRUP_FORMA_FARM_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ABREV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_AGRUP_FORMA_FARM_PK", x => x.AGRUP_FORMA_FARM_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_ATC",
                columns: table => new
                {
                    ATC_COD = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_ATC_PK", x => x.ATC_COD);
                });

            migrationBuilder.CreateTable(
                name: "REF_CFT",
                columns: table => new
                {
                    CFT_COD = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_CFT_PK", x => x.CFT_COD);
                });

            migrationBuilder.CreateTable(
                name: "REF_CHNM",
                columns: table => new
                {
                    CHNM_COD = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_CHNM_PK", x => x.CHNM_COD);
                });

            migrationBuilder.CreateTable(
                name: "REF_CLASS_DISPENSA_PROD",
                columns: table => new
                {
                    CLASS_DISP_PROD_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_CLASS_DISPENSA_PROD_PK", x => x.CLASS_DISP_PROD_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_CLASS_ESTP_PSICTR",
                columns: table => new
                {
                    CLASS_ESTP_PSICTR_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ABREV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_CLASS_ESTP_PSICTR_PK", x => x.CLASS_ESTP_PSICTR_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_COND_CONSERVACAO",
                columns: table => new
                {
                    COND_CONSERV_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_COND_CONSERVACAO_PK", x => x.COND_CONSERV_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_DCIPT",
                columns: table => new
                {
                    DCIPT_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ABREV_CHNM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_DCIPT_PK", x => x.DCIPT_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_ESTADO_AIM",
                columns: table => new
                {
                    ESTADO_AIM_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_ESTADO_AIM_PK", x => x.ESTADO_AIM_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_ESTADO_ARMAZ",
                columns: table => new
                {
                    ESTADO_ARMAZ_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_ESTADO_ARMAZ_PK", x => x.ESTADO_ARMAZ_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_ESTADO_COMERC",
                columns: table => new
                {
                    EST_COMERC_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_ESTADO_COMERC_PK", x => x.EST_COMERC_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_ESTADO_EMB",
                columns: table => new
                {
                    ESTADO_EMB_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_ESTADO_EMB_PK", x => x.ESTADO_EMB_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_FORMA_FARM",
                columns: table => new
                {
                    FORMA_FARM_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ABREV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ABREV_CHNM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_FORMA_FARM_PK", x => x.FORMA_FARM_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_GRUPO_HOM",
                columns: table => new
                {
                    GRUPO_HOM_COD = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_GRUPO_HOM_PK", x => x.GRUPO_HOM_COD);
                });

            migrationBuilder.CreateTable(
                name: "REF_GRUPO_PRODUTO",
                columns: table => new
                {
                    GRUPO_PRODUTO_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_GRUPO_PRODUTO_PK", x => x.GRUPO_PRODUTO_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_LOCAL_DISPENSA",
                columns: table => new
                {
                    LOCAL_DISPENSA_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_LOCAL_DISPENSA_PK", x => x.LOCAL_DISPENSA_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_MOTIVO_ESCOAM",
                columns: table => new
                {
                    MOTIVO_ESCOAM_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_MOTIVO_ESCOAM_PK", x => x.MOTIVO_ESCOAM_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_NIVEL_COMPART",
                columns: table => new
                {
                    NIVEL_COMPART_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PERCENT_COMPART = table.Column<int>(type: "int", nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_NIVEL_COMPART_PK", x => x.NIVEL_COMPART_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_REGIME_EXCECIONAL",
                columns: table => new
                {
                    REGIME_EXCECIONAL_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_REGIME_EXCECIONAL_PK", x => x.REGIME_EXCECIONAL_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_SEXO",
                columns: table => new
                {
                    SEXO_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_SEXO_PK", x => x.SEXO_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_SUBGRUPO_PRODUTO",
                columns: table => new
                {
                    SUBGRUPO_PRODUTO_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_SUBGRUPO_PRODUTO_PK", x => x.SUBGRUPO_PRODUTO_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_SUBSTANCIA",
                columns: table => new
                {
                    SUBST_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_SUBSTANCIA_PK", x => x.SUBST_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_TEMPERATURA_ARMAZ",
                columns: table => new
                {
                    TEMPERATURA_ARMAZ_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_TEMPERATURA_ARMAZ_PK", x => x.TEMPERATURA_ARMAZ_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_TIPO_ALERTA",
                columns: table => new
                {
                    TIPO_ALERTA_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_TIPO_ALERTA_PK", x => x.TIPO_ALERTA_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_TIPO_APRESENTACAO",
                columns: table => new
                {
                    TIPO_APRESENTACAO_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_TIPO_APRESENTACAO_PK", x => x.TIPO_APRESENTACAO_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_TIPO_AUTORIZ",
                columns: table => new
                {
                    TIPO_AUTORIZ_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_TIPO_AUTORIZ_PK", x => x.TIPO_AUTORIZ_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_TIPO_DESTINATARIO",
                columns: table => new
                {
                    TIPO_DESTINATARIO_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_TIPO_DESTINATARIO_PK", x => x.TIPO_DESTINATARIO_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_TIPO_EMB",
                columns: table => new
                {
                    TIPO_EMB_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_TIPO_EMB_PK", x => x.TIPO_EMB_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_TIPO_PRECO",
                columns: table => new
                {
                    TIPO_PRECO_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_TIPO_PRECO_PK", x => x.TIPO_PRECO_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_TIPO_PROCEDIMENTO",
                columns: table => new
                {
                    TIPO_PROCEDIMENTO_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_TIPO_PROCEDIMENTO_PK", x => x.TIPO_PROCEDIMENTO_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_TIPO_PRODUTO",
                columns: table => new
                {
                    TIPO_PRODUTO_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_TIPO_PRODUTO_PK", x => x.TIPO_PRODUTO_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_TIPO_REGIME",
                columns: table => new
                {
                    TIPO_REGIME_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_TIPO_REGIME_PK", x => x.TIPO_REGIME_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_TIPO_TRATAMENTO",
                columns: table => new
                {
                    TIPO_TRATAMENTO_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_TIPO_TRATAMENTO_PK", x => x.TIPO_TRATAMENTO_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_TITULAR_AIM",
                columns: table => new
                {
                    TITULAR_AIM_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_TITULAR_AIM_PK", x => x.TITULAR_AIM_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_UNIDADE",
                columns: table => new
                {
                    UNIDADE_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_UNIDADE_PK", x => x.UNIDADE_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_UNIDADE_TEMPORAL",
                columns: table => new
                {
                    UNIDADE_TEMPORAL_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_UNIDADE_TEMPORAL_PK", x => x.UNIDADE_TEMPORAL_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_VIA_ADMIN",
                columns: table => new
                {
                    VIA_ADMIN_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ABREV_CHNM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_VIA_ADMIN_PK", x => x.VIA_ADMIN_ID);
                });

            migrationBuilder.CreateTable(
                name: "REF_NORMA_REG_EXC",
                columns: table => new
                {
                    NORMA_REG_EXC_ID = table.Column<int>(type: "int", nullable: false),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOCAL_DISPENSA_ID = table.Column<int>(type: "int", nullable: true),
                    IND_ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("REF_NORMA_REG_EXC_PK", x => x.NORMA_REG_EXC_ID);
                    table.ForeignKey(
                        name: "REF_LOCAL_DISPENSAREF_NORMA_REG_EXC",
                        column: x => x.LOCAL_DISPENSA_ID,
                        principalTable: "REF_LOCAL_DISPENSA",
                        principalColumn: "LOCAL_DISPENSA_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ALERTA",
                columns: table => new
                {
                    ALERTA_ID = table.Column<int>(type: "int", nullable: false),
                    DATA_INICIO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATA_FIM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TIPO_APRESENTACAO_ID = table.Column<int>(type: "int", nullable: true),
                    SEXO_ID = table.Column<int>(type: "int", nullable: true),
                    TIPO_ALERTA_ID = table.Column<int>(type: "int", nullable: true),
                    FAIXA_ETARIA_INICIO = table.Column<int>(type: "int", nullable: true),
                    FAIXA_ETARIA_FIM = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ALERTA_PK", x => x.ALERTA_ID);
                    table.ForeignKey(
                        name: "REF_SEXOALERTA",
                        column: x => x.SEXO_ID,
                        principalTable: "REF_SEXO",
                        principalColumn: "SEXO_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_TIPO_ALERTAALERTA",
                        column: x => x.TIPO_ALERTA_ID,
                        principalTable: "REF_TIPO_ALERTA",
                        principalColumn: "TIPO_ALERTA_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_TIPO_APRESENTACAOALERTA",
                        column: x => x.TIPO_APRESENTACAO_ID,
                        principalTable: "REF_TIPO_APRESENTACAO",
                        principalColumn: "TIPO_APRESENTACAO_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTO",
                columns: table => new
                {
                    PROD_ID = table.Column<int>(type: "int", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOSAGEM_CEDENCIA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOSAGEM = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FORMA_FARM_ID = table.Column<int>(type: "int", nullable: true),
                    AGRUP_FORMA_FARM_ID = table.Column<int>(type: "int", nullable: true),
                    DCIPT_ID = table.Column<int>(type: "int", nullable: true),
                    TIPO_PRODUTO_ID = table.Column<int>(type: "int", nullable: true),
                    TIPO_AUTORIZ_ID = table.Column<int>(type: "int", nullable: true),
                    CLASS_ESTP_PSICTR_ID = table.Column<int>(type: "int", nullable: true),
                    TITULAR_AIM_ID = table.Column<int>(type: "int", nullable: true),
                    DATA_AIM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ESTADO_AIM_ID = table.Column<int>(type: "int", nullable: true),
                    DATA_EST_AIM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NR_PROCESSO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TIPO_PROCEDIMENTO_ID = table.Column<int>(type: "int", nullable: true),
                    IND_GENERICO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    IND_MARGEM_TERAP = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    IND_MONIT_ADICIONAL_FV = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    IND_FNM = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MARCA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MODELO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PROD_GUID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRODUTO_PK", x => x.PROD_ID);
                    table.ForeignKey(
                        name: "REF_AGRUP_FORMA_FARMPRODUTO",
                        column: x => x.AGRUP_FORMA_FARM_ID,
                        principalTable: "REF_AGRUP_FORMA_FARM",
                        principalColumn: "AGRUP_FORMA_FARM_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_CLASS_ESTP_PSICTRPRODUTO",
                        column: x => x.CLASS_ESTP_PSICTR_ID,
                        principalTable: "REF_CLASS_ESTP_PSICTR",
                        principalColumn: "CLASS_ESTP_PSICTR_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_DCIPTPRODUTO",
                        column: x => x.DCIPT_ID,
                        principalTable: "REF_DCIPT",
                        principalColumn: "DCIPT_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_ESTADO_AIMPRODUTO",
                        column: x => x.ESTADO_AIM_ID,
                        principalTable: "REF_ESTADO_AIM",
                        principalColumn: "ESTADO_AIM_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_FORMA_FARMPRODUTO",
                        column: x => x.FORMA_FARM_ID,
                        principalTable: "REF_FORMA_FARM",
                        principalColumn: "FORMA_FARM_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_TIPO_AUTORIZPRODUTO",
                        column: x => x.TIPO_AUTORIZ_ID,
                        principalTable: "REF_TIPO_AUTORIZ",
                        principalColumn: "TIPO_AUTORIZ_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_TIPO_PROCEDIMENTOPRODUTO",
                        column: x => x.TIPO_PROCEDIMENTO_ID,
                        principalTable: "REF_TIPO_PROCEDIMENTO",
                        principalColumn: "TIPO_PROCEDIMENTO_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_TIPO_PRODUTOPRODUTO",
                        column: x => x.TIPO_PRODUTO_ID,
                        principalTable: "REF_TIPO_PRODUTO",
                        principalColumn: "TIPO_PRODUTO_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_TITULAR_AIMPRODUTO",
                        column: x => x.TITULAR_AIM_ID,
                        principalTable: "REF_TITULAR_AIM",
                        principalColumn: "TITULAR_AIM_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DOCUMENTO_ALERTA",
                columns: table => new
                {
                    TITULO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATA_APROVACAO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESTINATARIO_MEDICO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    DESTINATARIO_FARMACEUTICO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    DESTINATARIO_CIDADAO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    ENTREGA_MEDICO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    ENTREGA_FARMACEUTICO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    ALERTA_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "ALERTADOCUMENTO_ALERTA",
                        column: x => x.ALERTA_ID,
                        principalTable: "ALERTA",
                        principalColumn: "ALERTA_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EMBALAGEM",
                columns: table => new
                {
                    EMB_ID = table.Column<int>(type: "int", nullable: false),
                    PROD_ID = table.Column<int>(type: "int", nullable: true),
                    NR_REGISTO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GRUPO_HOM_COD = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    QUANT_TOT = table.Column<double>(type: "float", nullable: true),
                    UNID_QUANT_TOT_ID = table.Column<int>(type: "int", nullable: true),
                    QUANTIDADE = table.Column<double>(type: "float", nullable: true),
                    UNID_QUANT_ID = table.Column<int>(type: "int", nullable: true),
                    TIPO_EMB_ID = table.Column<int>(type: "int", nullable: true),
                    ACOND_PRIMARIO_ID = table.Column<int>(type: "int", nullable: true),
                    TIPO_TRATAMENTO_ID = table.Column<int>(type: "int", nullable: true),
                    ESTADO_EMB_ID = table.Column<int>(type: "int", nullable: true),
                    IND_EMB_UNITARIA = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    IND_EMB_HOSPITALAR = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    IND_DISP_SEGURANCA = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    PEM_AMB = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    PEM_AMB_MS = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    PEM_AMB_BIO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    PEM_AMB_BIO_MS = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CNPEM = table.Column<int>(type: "int", nullable: true),
                    CHNM_COD = table.Column<int>(type: "int", nullable: true),
                    CDM = table.Column<int>(type: "int", nullable: true),
                    REFERENCIA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CARACT_ESPECIFICAS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("EMBALAGEM_PK", x => x.EMB_ID);
                    table.ForeignKey(
                        name: "PRODUTOEMBALAGEM",
                        column: x => x.PROD_ID,
                        principalTable: "PRODUTO",
                        principalColumn: "PROD_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_ACOND_PRIMARIOEMBALAGEM",
                        column: x => x.ACOND_PRIMARIO_ID,
                        principalTable: "REF_ACOND_PRIMARIO",
                        principalColumn: "ACOND_PRIMARIO_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_CHNMEMBALAGEM",
                        column: x => x.CHNM_COD,
                        principalTable: "REF_CHNM",
                        principalColumn: "CHNM_COD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_ESTADO_EMBEMBALAGEM",
                        column: x => x.ESTADO_EMB_ID,
                        principalTable: "REF_ESTADO_EMB",
                        principalColumn: "ESTADO_EMB_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_GRUPO_HOMEMBALAGEM",
                        column: x => x.GRUPO_HOM_COD,
                        principalTable: "REF_GRUPO_HOM",
                        principalColumn: "GRUPO_HOM_COD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_TIPO_EMBEMBALAGEM",
                        column: x => x.TIPO_EMB_ID,
                        principalTable: "REF_TIPO_EMB",
                        principalColumn: "TIPO_EMB_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_TIPO_TRATAMENTOEMBALAGEM",
                        column: x => x.TIPO_TRATAMENTO_ID,
                        principalTable: "REF_TIPO_TRATAMENTO",
                        principalColumn: "TIPO_TRATAMENTO_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_UNIDADEEMBALAGEM",
                        column: x => x.UNID_QUANT_ID,
                        principalTable: "REF_UNIDADE",
                        principalColumn: "UNIDADE_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_UNIDADEEMBALAGEM1",
                        column: x => x.UNID_QUANT_TOT_ID,
                        principalTable: "REF_UNIDADE",
                        principalColumn: "UNIDADE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LNK_PROD_ATC",
                columns: table => new
                {
                    PROD_ID = table.Column<int>(type: "int", nullable: true),
                    ATC_COD = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "PRODUTOLNK_PROD_ATC",
                        column: x => x.PROD_ID,
                        principalTable: "PRODUTO",
                        principalColumn: "PROD_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_ATCLNK_PROD_ATC",
                        column: x => x.ATC_COD,
                        principalTable: "REF_ATC",
                        principalColumn: "ATC_COD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LNK_PROD_CFT",
                columns: table => new
                {
                    PROD_ID = table.Column<int>(type: "int", nullable: true),
                    CFT_COD = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    CFT_CHNM = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "PRODUTOLNK_PROD_CFT",
                        column: x => x.PROD_ID,
                        principalTable: "PRODUTO",
                        principalColumn: "PROD_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_CFTLNK_PROD_CFT",
                        column: x => x.CFT_COD,
                        principalTable: "REF_CFT",
                        principalColumn: "CFT_COD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LNK_PROD_CLASS_DISP",
                columns: table => new
                {
                    PROD_ID = table.Column<int>(type: "int", nullable: true),
                    CLASS_DISP_PROD_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "PRODUTOLNK_PROD_CLASS_DISP",
                        column: x => x.PROD_ID,
                        principalTable: "PRODUTO",
                        principalColumn: "PROD_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_CLASS_DISPENSA_PRODLNK_PROD_CLASS_DISP",
                        column: x => x.CLASS_DISP_PROD_ID,
                        principalTable: "REF_CLASS_DISPENSA_PROD",
                        principalColumn: "CLASS_DISP_PROD_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LNK_PROD_GRUPO_PROD",
                columns: table => new
                {
                    PROD_ID = table.Column<int>(type: "int", nullable: true),
                    GRUPO_PRODUTO_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "PRODUTOLNK_PROD_GRUPO_PROD",
                        column: x => x.PROD_ID,
                        principalTable: "PRODUTO",
                        principalColumn: "PROD_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_GRUPO_PRODUTOLNK_PROD_GRUPO_PROD",
                        column: x => x.GRUPO_PRODUTO_ID,
                        principalTable: "REF_GRUPO_PRODUTO",
                        principalColumn: "GRUPO_PRODUTO_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LNK_PROD_SUBGRUPO_PROD",
                columns: table => new
                {
                    PROD_ID = table.Column<int>(type: "int", nullable: true),
                    SUBGRUPO_PRODUTO_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "PRODUTOLNK_PROD_SUBGRUPO_PROD",
                        column: x => x.PROD_ID,
                        principalTable: "PRODUTO",
                        principalColumn: "PROD_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_SUBGRUPO_PRODUTOLNK_PROD_SUBGRUPO_PROD",
                        column: x => x.SUBGRUPO_PRODUTO_ID,
                        principalTable: "REF_SUBGRUPO_PRODUTO",
                        principalColumn: "SUBGRUPO_PRODUTO_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LNK_PROD_SUBST",
                columns: table => new
                {
                    PROD_ID = table.Column<int>(type: "int", nullable: true),
                    SUBST_ID = table.Column<int>(type: "int", nullable: true),
                    QUANTIDADE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNID_QUANT_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "PRODUTOLNK_PROD_SUBST",
                        column: x => x.PROD_ID,
                        principalTable: "PRODUTO",
                        principalColumn: "PROD_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_SUBSTANCIALNK_PROD_SUBST",
                        column: x => x.SUBST_ID,
                        principalTable: "REF_SUBSTANCIA",
                        principalColumn: "SUBST_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_UNIDADELNK_PROD_SUBST",
                        column: x => x.UNID_QUANT_ID,
                        principalTable: "REF_UNIDADE",
                        principalColumn: "UNIDADE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LNK_PROD_VIA_ADMIN",
                columns: table => new
                {
                    PROD_ID = table.Column<int>(type: "int", nullable: true),
                    VIA_ADMIN_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "PRODUTOLNK_PROD_VIA_ADMIN",
                        column: x => x.PROD_ID,
                        principalTable: "PRODUTO",
                        principalColumn: "PROD_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_VIA_ADMINLNK_PROD_VIA_ADMIN",
                        column: x => x.VIA_ADMIN_ID,
                        principalTable: "REF_VIA_ADMIN",
                        principalColumn: "VIA_ADMIN_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COMERCIALIZACAO",
                columns: table => new
                {
                    COMERC_ID = table.Column<int>(type: "int", nullable: false),
                    EMB_ID = table.Column<int>(type: "int", nullable: true),
                    ESTADO_COMERC_ID = table.Column<int>(type: "int", nullable: true),
                    DATA_INICIO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATA_FIM = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("COMERCIALIZACAO_PK", x => x.COMERC_ID);
                    table.ForeignKey(
                        name: "EMBALAGEMCOMERCIALIZACAO",
                        column: x => x.EMB_ID,
                        principalTable: "EMBALAGEM",
                        principalColumn: "EMB_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_ESTADO_COMERCCOMERCIALIZACAO",
                        column: x => x.ESTADO_COMERC_ID,
                        principalTable: "REF_ESTADO_COMERC",
                        principalColumn: "EST_COMERC_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COMPARTICIPACAO",
                columns: table => new
                {
                    COMPART_ID = table.Column<int>(type: "int", nullable: false),
                    EMB_ID = table.Column<int>(type: "int", nullable: true),
                    TIPO_REGIME_ID = table.Column<int>(type: "int", nullable: true),
                    NORMA_REG_EXC_ID = table.Column<int>(type: "int", nullable: true),
                    REGIME_EXCECIONAL_ID = table.Column<int>(type: "int", nullable: true),
                    NIVEL_COMPART_ID = table.Column<int>(type: "int", nullable: true),
                    DATA_INICIO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATA_FIM = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("COMPARTICIPACAO_PK", x => x.COMPART_ID);
                    table.ForeignKey(
                        name: "EMBALAGEMCOMPARTICIPACAO",
                        column: x => x.EMB_ID,
                        principalTable: "EMBALAGEM",
                        principalColumn: "EMB_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_NIVEL_COMPARTCOMPARTICIPACAO",
                        column: x => x.NIVEL_COMPART_ID,
                        principalTable: "REF_NIVEL_COMPART",
                        principalColumn: "NIVEL_COMPART_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_NORMA_REG_EXCCOMPARTICIPACAO",
                        column: x => x.NORMA_REG_EXC_ID,
                        principalTable: "REF_NORMA_REG_EXC",
                        principalColumn: "NORMA_REG_EXC_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_REGIME_EXCECIONALCOMPARTICIPACAO",
                        column: x => x.REGIME_EXCECIONAL_ID,
                        principalTable: "REF_REGIME_EXCECIONAL",
                        principalColumn: "REGIME_EXCECIONAL_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_TIPO_REGIMECOMPARTICIPACAO",
                        column: x => x.TIPO_REGIME_ID,
                        principalTable: "REF_TIPO_REGIME",
                        principalColumn: "TIPO_REGIME_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COND_ARMAZENAMENTO",
                columns: table => new
                {
                    COND_ARMAZ_ID = table.Column<int>(type: "int", nullable: false),
                    EMB_ID = table.Column<int>(type: "int", nullable: true),
                    ESTADO_ARMAZ_ID = table.Column<int>(type: "int", nullable: true),
                    TEMPERATURA_ARMAZ_ID = table.Column<int>(type: "int", nullable: true),
                    NR_PRAZO_VAL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNID_TEMP_PRAZO_VAL_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("COND_ARMAZENAMENTO_PK", x => x.COND_ARMAZ_ID);
                    table.ForeignKey(
                        name: "EMBALAGEMCOND_ARMAZENAMENTO",
                        column: x => x.EMB_ID,
                        principalTable: "EMBALAGEM",
                        principalColumn: "EMB_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_ESTADO_ARMAZCOND_ARMAZENAMENTO",
                        column: x => x.ESTADO_ARMAZ_ID,
                        principalTable: "REF_ESTADO_ARMAZ",
                        principalColumn: "ESTADO_ARMAZ_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_TEMPERATURA_ARMAZCOND_ARMAZENAMENTO",
                        column: x => x.TEMPERATURA_ARMAZ_ID,
                        principalTable: "REF_TEMPERATURA_ARMAZ",
                        principalColumn: "TEMPERATURA_ARMAZ_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_UNIDADE_TEMPORALCOND_ARMAZENAMENTO",
                        column: x => x.UNID_TEMP_PRAZO_VAL_ID,
                        principalTable: "REF_UNIDADE_TEMPORAL",
                        principalColumn: "UNIDADE_TEMPORAL_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ESCOAMENTO",
                columns: table => new
                {
                    ESCOAM_ID = table.Column<int>(type: "int", nullable: false),
                    EMB_ID = table.Column<int>(type: "int", nullable: true),
                    MOTIVO_ESCOAM_ID = table.Column<int>(type: "int", nullable: true),
                    DATA_INICIO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATA_FIM = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ESCOAMENTO_PK", x => x.ESCOAM_ID);
                    table.ForeignKey(
                        name: "EMBALAGEMESCOAMENTO",
                        column: x => x.EMB_ID,
                        principalTable: "EMBALAGEM",
                        principalColumn: "EMB_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_MOTIVO_ESCOAMESCOAMENTO",
                        column: x => x.MOTIVO_ESCOAM_ID,
                        principalTable: "REF_MOTIVO_ESCOAM",
                        principalColumn: "MOTIVO_ESCOAM_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LNK_EMB_CNPEM",
                columns: table => new
                {
                    EMB_CNPEM_ID = table.Column<int>(type: "int", nullable: false),
                    EMB_ID = table.Column<int>(type: "int", nullable: true),
                    CNPEM = table.Column<int>(type: "int", nullable: true),
                    DATA_INICIO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATA_FIM = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LNK_EMB_CNPEM_PK", x => x.EMB_CNPEM_ID);
                    table.ForeignKey(
                        name: "EMBALAGEMLNK_EMB_CNPEM",
                        column: x => x.EMB_ID,
                        principalTable: "EMBALAGEM",
                        principalColumn: "EMB_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MENSAGEM_ALERTA",
                columns: table => new
                {
                    MENSAGEM_ALERTA_ID = table.Column<int>(type: "int", nullable: false),
                    EMB_ID = table.Column<int>(type: "int", nullable: true),
                    MENSAGEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LINK = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIPO_DESTINATARIO_ID = table.Column<int>(type: "int", nullable: true),
                    ALERTA_ID = table.Column<int>(type: "int", nullable: true),
                    IDIOMA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MENSAGEM_ALERTA_PK", x => x.MENSAGEM_ALERTA_ID);
                    table.ForeignKey(
                        name: "ALERTAMENSAGEM_ALERTA",
                        column: x => x.ALERTA_ID,
                        principalTable: "ALERTA",
                        principalColumn: "ALERTA_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "EMBALAGEMMENSAGEM_ALERTA",
                        column: x => x.EMB_ID,
                        principalTable: "EMBALAGEM",
                        principalColumn: "EMB_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_TIPO_DESTINATARIOMENSAGEM_ALERTA",
                        column: x => x.TIPO_DESTINATARIO_ID,
                        principalTable: "REF_TIPO_DESTINATARIO",
                        principalColumn: "TIPO_DESTINATARIO_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRECO",
                columns: table => new
                {
                    PRECO_ID = table.Column<int>(type: "int", nullable: false),
                    EMB_ID = table.Column<int>(type: "int", nullable: true),
                    TIPO_PRECO_ID = table.Column<int>(type: "int", nullable: true),
                    PRECO = table.Column<double>(type: "float", nullable: true),
                    DATA_INICIO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATA_FIM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ATIVO = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    ATIVO_MS = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRECO_PK", x => x.PRECO_ID);
                    table.ForeignKey(
                        name: "EMBALAGEMPRECO",
                        column: x => x.EMB_ID,
                        principalTable: "EMBALAGEM",
                        principalColumn: "EMB_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_TIPO_PRECOPRECO",
                        column: x => x.TIPO_PRECO_ID,
                        principalTable: "REF_TIPO_PRECO",
                        principalColumn: "TIPO_PRECO_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LNK_COND_ARMAZ_CONSERV",
                columns: table => new
                {
                    COND_ARMAZ_ID = table.Column<int>(type: "int", nullable: true),
                    COND_CONSERV_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "COND_ARMAZENAMENTOLNK_COND_ARMAZ_CONSERV",
                        column: x => x.COND_ARMAZ_ID,
                        principalTable: "COND_ARMAZENAMENTO",
                        principalColumn: "COND_ARMAZ_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "REF_COND_CONSERVACAOLNK_COND_ARMAZ_CONSERV",
                        column: x => x.COND_CONSERV_ID,
                        principalTable: "REF_COND_CONSERVACAO",
                        principalColumn: "COND_CONSERV_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ALERTA_SEXO_ID",
                table: "ALERTA",
                column: "SEXO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ALERTA_TIPO_ALERTA_ID",
                table: "ALERTA",
                column: "TIPO_ALERTA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ALERTA_TIPO_APRESENTACAO_ID",
                table: "ALERTA",
                column: "TIPO_APRESENTACAO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COMERCIALIZACAO_EMB_ID",
                table: "COMERCIALIZACAO",
                column: "EMB_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COMERCIALIZACAO_ESTADO_COMERC_ID",
                table: "COMERCIALIZACAO",
                column: "ESTADO_COMERC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COMPARTICIPACAO_EMB_ID",
                table: "COMPARTICIPACAO",
                column: "EMB_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COMPARTICIPACAO_NIVEL_COMPART_ID",
                table: "COMPARTICIPACAO",
                column: "NIVEL_COMPART_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COMPARTICIPACAO_NORMA_REG_EXC_ID",
                table: "COMPARTICIPACAO",
                column: "NORMA_REG_EXC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COMPARTICIPACAO_REGIME_EXCECIONAL_ID",
                table: "COMPARTICIPACAO",
                column: "REGIME_EXCECIONAL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COMPARTICIPACAO_TIPO_REGIME_ID",
                table: "COMPARTICIPACAO",
                column: "TIPO_REGIME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COND_ARMAZENAMENTO_EMB_ID",
                table: "COND_ARMAZENAMENTO",
                column: "EMB_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COND_ARMAZENAMENTO_ESTADO_ARMAZ_ID",
                table: "COND_ARMAZENAMENTO",
                column: "ESTADO_ARMAZ_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COND_ARMAZENAMENTO_TEMPERATURA_ARMAZ_ID",
                table: "COND_ARMAZENAMENTO",
                column: "TEMPERATURA_ARMAZ_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COND_ARMAZENAMENTO_UNID_TEMP_PRAZO_VAL_ID",
                table: "COND_ARMAZENAMENTO",
                column: "UNID_TEMP_PRAZO_VAL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DOCUMENTO_ALERTA_ALERTA_ID",
                table: "DOCUMENTO_ALERTA",
                column: "ALERTA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EMBALAGEM_ACOND_PRIMARIO_ID",
                table: "EMBALAGEM",
                column: "ACOND_PRIMARIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EMBALAGEM_CHNM_COD",
                table: "EMBALAGEM",
                column: "CHNM_COD");

            migrationBuilder.CreateIndex(
                name: "IX_EMBALAGEM_ESTADO_EMB_ID",
                table: "EMBALAGEM",
                column: "ESTADO_EMB_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EMBALAGEM_GRUPO_HOM_COD",
                table: "EMBALAGEM",
                column: "GRUPO_HOM_COD");

            migrationBuilder.CreateIndex(
                name: "IX_EMBALAGEM_PROD_ID",
                table: "EMBALAGEM",
                column: "PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EMBALAGEM_TIPO_EMB_ID",
                table: "EMBALAGEM",
                column: "TIPO_EMB_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EMBALAGEM_TIPO_TRATAMENTO_ID",
                table: "EMBALAGEM",
                column: "TIPO_TRATAMENTO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EMBALAGEM_UNID_QUANT_ID",
                table: "EMBALAGEM",
                column: "UNID_QUANT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EMBALAGEM_UNID_QUANT_TOT_ID",
                table: "EMBALAGEM",
                column: "UNID_QUANT_TOT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ESCOAMENTO_EMB_ID",
                table: "ESCOAMENTO",
                column: "EMB_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ESCOAMENTO_MOTIVO_ESCOAM_ID",
                table: "ESCOAMENTO",
                column: "MOTIVO_ESCOAM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_COND_ARMAZ_CONSERV_COND_ARMAZ_ID",
                table: "LNK_COND_ARMAZ_CONSERV",
                column: "COND_ARMAZ_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_COND_ARMAZ_CONSERV_COND_CONSERV_ID",
                table: "LNK_COND_ARMAZ_CONSERV",
                column: "COND_CONSERV_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_EMB_CNPEM_EMB_ID",
                table: "LNK_EMB_CNPEM",
                column: "EMB_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_ATC_ATC_COD",
                table: "LNK_PROD_ATC",
                column: "ATC_COD");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_ATC_PROD_ID",
                table: "LNK_PROD_ATC",
                column: "PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_CFT_CFT_COD",
                table: "LNK_PROD_CFT",
                column: "CFT_COD");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_CFT_PROD_ID",
                table: "LNK_PROD_CFT",
                column: "PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_CLASS_DISP_CLASS_DISP_PROD_ID",
                table: "LNK_PROD_CLASS_DISP",
                column: "CLASS_DISP_PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_CLASS_DISP_PROD_ID",
                table: "LNK_PROD_CLASS_DISP",
                column: "PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_GRUPO_PROD_GRUPO_PRODUTO_ID",
                table: "LNK_PROD_GRUPO_PROD",
                column: "GRUPO_PRODUTO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_GRUPO_PROD_PROD_ID",
                table: "LNK_PROD_GRUPO_PROD",
                column: "PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_SUBGRUPO_PROD_PROD_ID",
                table: "LNK_PROD_SUBGRUPO_PROD",
                column: "PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_SUBGRUPO_PROD_SUBGRUPO_PRODUTO_ID",
                table: "LNK_PROD_SUBGRUPO_PROD",
                column: "SUBGRUPO_PRODUTO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_SUBST_PROD_ID",
                table: "LNK_PROD_SUBST",
                column: "PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_SUBST_SUBST_ID",
                table: "LNK_PROD_SUBST",
                column: "SUBST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_SUBST_UNID_QUANT_ID",
                table: "LNK_PROD_SUBST",
                column: "UNID_QUANT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_VIA_ADMIN_PROD_ID",
                table: "LNK_PROD_VIA_ADMIN",
                column: "PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LNK_PROD_VIA_ADMIN_VIA_ADMIN_ID",
                table: "LNK_PROD_VIA_ADMIN",
                column: "VIA_ADMIN_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MENSAGEM_ALERTA_ALERTA_ID",
                table: "MENSAGEM_ALERTA",
                column: "ALERTA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MENSAGEM_ALERTA_EMB_ID",
                table: "MENSAGEM_ALERTA",
                column: "EMB_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MENSAGEM_ALERTA_TIPO_DESTINATARIO_ID",
                table: "MENSAGEM_ALERTA",
                column: "TIPO_DESTINATARIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRECO_EMB_ID",
                table: "PRECO",
                column: "EMB_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRECO_TIPO_PRECO_ID",
                table: "PRECO",
                column: "TIPO_PRECO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_AGRUP_FORMA_FARM_ID",
                table: "PRODUTO",
                column: "AGRUP_FORMA_FARM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_CLASS_ESTP_PSICTR_ID",
                table: "PRODUTO",
                column: "CLASS_ESTP_PSICTR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_DCIPT_ID",
                table: "PRODUTO",
                column: "DCIPT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_ESTADO_AIM_ID",
                table: "PRODUTO",
                column: "ESTADO_AIM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_FORMA_FARM_ID",
                table: "PRODUTO",
                column: "FORMA_FARM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_TIPO_AUTORIZ_ID",
                table: "PRODUTO",
                column: "TIPO_AUTORIZ_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_TIPO_PROCEDIMENTO_ID",
                table: "PRODUTO",
                column: "TIPO_PROCEDIMENTO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_TIPO_PRODUTO_ID",
                table: "PRODUTO",
                column: "TIPO_PRODUTO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_TITULAR_AIM_ID",
                table: "PRODUTO",
                column: "TITULAR_AIM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_REF_NORMA_REG_EXC_LOCAL_DISPENSA_ID",
                table: "REF_NORMA_REG_EXC",
                column: "LOCAL_DISPENSA_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COMERCIALIZACAO");

            migrationBuilder.DropTable(
                name: "COMPARTICIPACAO");

            migrationBuilder.DropTable(
                name: "DOCUMENTO_ALERTA");

            migrationBuilder.DropTable(
                name: "ESCOAMENTO");

            migrationBuilder.DropTable(
                name: "LNK_COND_ARMAZ_CONSERV");

            migrationBuilder.DropTable(
                name: "LNK_EMB_CNPEM");

            migrationBuilder.DropTable(
                name: "LNK_PROD_ATC");

            migrationBuilder.DropTable(
                name: "LNK_PROD_CFT");

            migrationBuilder.DropTable(
                name: "LNK_PROD_CLASS_DISP");

            migrationBuilder.DropTable(
                name: "LNK_PROD_GRUPO_PROD");

            migrationBuilder.DropTable(
                name: "LNK_PROD_SUBGRUPO_PROD");

            migrationBuilder.DropTable(
                name: "LNK_PROD_SUBST");

            migrationBuilder.DropTable(
                name: "LNK_PROD_VIA_ADMIN");

            migrationBuilder.DropTable(
                name: "MENSAGEM_ALERTA");

            migrationBuilder.DropTable(
                name: "PRECO");

            migrationBuilder.DropTable(
                name: "PRODUTO_OPERACAO");

            migrationBuilder.DropTable(
                name: "REF_ESTADO_COMERC");

            migrationBuilder.DropTable(
                name: "REF_NIVEL_COMPART");

            migrationBuilder.DropTable(
                name: "REF_NORMA_REG_EXC");

            migrationBuilder.DropTable(
                name: "REF_REGIME_EXCECIONAL");

            migrationBuilder.DropTable(
                name: "REF_TIPO_REGIME");

            migrationBuilder.DropTable(
                name: "REF_MOTIVO_ESCOAM");

            migrationBuilder.DropTable(
                name: "COND_ARMAZENAMENTO");

            migrationBuilder.DropTable(
                name: "REF_COND_CONSERVACAO");

            migrationBuilder.DropTable(
                name: "REF_ATC");

            migrationBuilder.DropTable(
                name: "REF_CFT");

            migrationBuilder.DropTable(
                name: "REF_CLASS_DISPENSA_PROD");

            migrationBuilder.DropTable(
                name: "REF_GRUPO_PRODUTO");

            migrationBuilder.DropTable(
                name: "REF_SUBGRUPO_PRODUTO");

            migrationBuilder.DropTable(
                name: "REF_SUBSTANCIA");

            migrationBuilder.DropTable(
                name: "REF_VIA_ADMIN");

            migrationBuilder.DropTable(
                name: "ALERTA");

            migrationBuilder.DropTable(
                name: "REF_TIPO_DESTINATARIO");

            migrationBuilder.DropTable(
                name: "REF_TIPO_PRECO");

            migrationBuilder.DropTable(
                name: "REF_LOCAL_DISPENSA");

            migrationBuilder.DropTable(
                name: "EMBALAGEM");

            migrationBuilder.DropTable(
                name: "REF_ESTADO_ARMAZ");

            migrationBuilder.DropTable(
                name: "REF_TEMPERATURA_ARMAZ");

            migrationBuilder.DropTable(
                name: "REF_UNIDADE_TEMPORAL");

            migrationBuilder.DropTable(
                name: "REF_SEXO");

            migrationBuilder.DropTable(
                name: "REF_TIPO_ALERTA");

            migrationBuilder.DropTable(
                name: "REF_TIPO_APRESENTACAO");

            migrationBuilder.DropTable(
                name: "PRODUTO");

            migrationBuilder.DropTable(
                name: "REF_ACOND_PRIMARIO");

            migrationBuilder.DropTable(
                name: "REF_CHNM");

            migrationBuilder.DropTable(
                name: "REF_ESTADO_EMB");

            migrationBuilder.DropTable(
                name: "REF_GRUPO_HOM");

            migrationBuilder.DropTable(
                name: "REF_TIPO_EMB");

            migrationBuilder.DropTable(
                name: "REF_TIPO_TRATAMENTO");

            migrationBuilder.DropTable(
                name: "REF_UNIDADE");

            migrationBuilder.DropTable(
                name: "REF_AGRUP_FORMA_FARM");

            migrationBuilder.DropTable(
                name: "REF_CLASS_ESTP_PSICTR");

            migrationBuilder.DropTable(
                name: "REF_DCIPT");

            migrationBuilder.DropTable(
                name: "REF_ESTADO_AIM");

            migrationBuilder.DropTable(
                name: "REF_FORMA_FARM");

            migrationBuilder.DropTable(
                name: "REF_TIPO_AUTORIZ");

            migrationBuilder.DropTable(
                name: "REF_TIPO_PROCEDIMENTO");

            migrationBuilder.DropTable(
                name: "REF_TIPO_PRODUTO");

            migrationBuilder.DropTable(
                name: "REF_TITULAR_AIM");
        }
    }
}
