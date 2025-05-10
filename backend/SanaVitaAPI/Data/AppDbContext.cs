using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SanaVitaAPI.Models;

namespace SanaVitaAPI.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alertum> Alerta { get; set; }

    public virtual DbSet<Comercializacao> Comercializacaos { get; set; }

    public virtual DbSet<Comparticipacao> Comparticipacaos { get; set; }

    public virtual DbSet<CondArmazenamento> CondArmazenamentos { get; set; }

    public virtual DbSet<DocumentoAlertum> DocumentoAlerta { get; set; }

    public virtual DbSet<Embalagem> Embalagems { get; set; }

    public virtual DbSet<Escoamento> Escoamentos { get; set; }

    public virtual DbSet<LnkCondArmazConserv> LnkCondArmazConservs { get; set; }

    public virtual DbSet<LnkEmbCnpem> LnkEmbCnpems { get; set; }

    public virtual DbSet<LnkProdAtc> LnkProdAtcs { get; set; }

    public virtual DbSet<LnkProdCft> LnkProdCfts { get; set; }

    public virtual DbSet<LnkProdClassDisp> LnkProdClassDisps { get; set; }

    public virtual DbSet<LnkProdGrupoProd> LnkProdGrupoProds { get; set; }

    public virtual DbSet<LnkProdSubgrupoProd> LnkProdSubgrupoProds { get; set; }

    public virtual DbSet<LnkProdSubst> LnkProdSubsts { get; set; }

    public virtual DbSet<LnkProdViaAdmin> LnkProdViaAdmins { get; set; }

    public virtual DbSet<MensagemAlertum> MensagemAlerta { get; set; }

    public virtual DbSet<Preco> Precos { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<ProdutoOperacao> ProdutoOperacaos { get; set; }

    public virtual DbSet<RefAcondPrimario> RefAcondPrimarios { get; set; }

    public virtual DbSet<RefAgrupFormaFarm> RefAgrupFormaFarms { get; set; }

    public virtual DbSet<RefAtc> RefAtcs { get; set; }

    public virtual DbSet<RefCft> RefCfts { get; set; }

    public virtual DbSet<RefChnm> RefChnms { get; set; }

    public virtual DbSet<RefClassDispensaProd> RefClassDispensaProds { get; set; }

    public virtual DbSet<RefClassEstpPsictr> RefClassEstpPsictrs { get; set; }

    public virtual DbSet<RefCondConservacao> RefCondConservacaos { get; set; }

    public virtual DbSet<RefDcipt> RefDcipts { get; set; }

    public virtual DbSet<RefEstadoAim> RefEstadoAims { get; set; }

    public virtual DbSet<RefEstadoArmaz> RefEstadoArmazs { get; set; }

    public virtual DbSet<RefEstadoComerc> RefEstadoComercs { get; set; }

    public virtual DbSet<RefEstadoEmb> RefEstadoEmbs { get; set; }

    public virtual DbSet<RefFormaFarm> RefFormaFarms { get; set; }

    public virtual DbSet<RefGrupoHom> RefGrupoHoms { get; set; }

    public virtual DbSet<RefGrupoProduto> RefGrupoProdutos { get; set; }

    public virtual DbSet<RefLocalDispensa> RefLocalDispensas { get; set; }

    public virtual DbSet<RefMotivoEscoam> RefMotivoEscoams { get; set; }

    public virtual DbSet<RefNivelCompart> RefNivelComparts { get; set; }

    public virtual DbSet<RefNormaRegExc> RefNormaRegExcs { get; set; }

    public virtual DbSet<RefRegimeExcecional> RefRegimeExcecionals { get; set; }

    public virtual DbSet<RefSexo> RefSexos { get; set; }

    public virtual DbSet<RefSubgrupoProduto> RefSubgrupoProdutos { get; set; }

    public virtual DbSet<RefSubstancium> RefSubstancia { get; set; }

    public virtual DbSet<RefTemperaturaArmaz> RefTemperaturaArmazs { get; set; }

    public virtual DbSet<RefTipoAlertum> RefTipoAlerta { get; set; }

    public virtual DbSet<RefTipoApresentacao> RefTipoApresentacaos { get; set; }

    public virtual DbSet<RefTipoAutoriz> RefTipoAutorizs { get; set; }

    public virtual DbSet<RefTipoDestinatario> RefTipoDestinatarios { get; set; }

    public virtual DbSet<RefTipoEmb> RefTipoEmbs { get; set; }

    public virtual DbSet<RefTipoPreco> RefTipoPrecos { get; set; }

    public virtual DbSet<RefTipoProcedimento> RefTipoProcedimentos { get; set; }

    public virtual DbSet<RefTipoProduto> RefTipoProdutos { get; set; }

    public virtual DbSet<RefTipoRegime> RefTipoRegimes { get; set; }

    public virtual DbSet<RefTipoTratamento> RefTipoTratamentos { get; set; }

    public virtual DbSet<RefTitularAim> RefTitularAims { get; set; }

    public virtual DbSet<RefUnidade> RefUnidades { get; set; }

    public virtual DbSet<RefUnidadeTemporal> RefUnidadeTemporals { get; set; }

    public virtual DbSet<RefViaAdmin> RefViaAdmins { get; set; }

    public DbSet<User> Users { get; set; }
    public DbSet<MedicationRequest> MedicationRequests { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<MedicationSchedule> MedicationSchedules { get; set; }

    public DbSet<AdministrationEvent> AdministrationEvents { get; set; }
    public DbSet<DispensingEvent> DispensingEvents { get; set; }
    public DbSet<InventoryItem> InventoryItems { get; set; }
    public DbSet<ExceptionEvent> ExceptionEvents { get; set; }
    public DbSet<BarcodeScanLog> BarcodeScanLogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alertum>(entity =>
        {
            entity.HasKey(e => e.AlertaId).HasName("ALERTA_PK");

            entity.ToTable("ALERTA");

            entity.Property(e => e.AlertaId)
                .ValueGeneratedNever()
                .HasColumnName("ALERTA_ID");
            entity.Property(e => e.DataFim).HasColumnName("DATA_FIM");
            entity.Property(e => e.DataInicio).HasColumnName("DATA_INICIO");
            entity.Property(e => e.FaixaEtariaFim).HasColumnName("FAIXA_ETARIA_FIM");
            entity.Property(e => e.FaixaEtariaInicio).HasColumnName("FAIXA_ETARIA_INICIO");
            entity.Property(e => e.SexoId).HasColumnName("SEXO_ID");
            entity.Property(e => e.TipoAlertaId).HasColumnName("TIPO_ALERTA_ID");
            entity.Property(e => e.TipoApresentacaoId).HasColumnName("TIPO_APRESENTACAO_ID");

            entity.HasOne(d => d.Sexo).WithMany(p => p.Alerta)
                .HasForeignKey(d => d.SexoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_SEXOALERTA");

            entity.HasOne(d => d.TipoAlerta).WithMany(p => p.Alerta)
                .HasForeignKey(d => d.TipoAlertaId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_TIPO_ALERTAALERTA");

            entity.HasOne(d => d.TipoApresentacao).WithMany(p => p.Alerta)
                .HasForeignKey(d => d.TipoApresentacaoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_TIPO_APRESENTACAOALERTA");
        });

        modelBuilder.Entity<Comercializacao>(entity =>
        {
            entity.HasKey(e => e.ComercId).HasName("COMERCIALIZACAO_PK");

            entity.ToTable("COMERCIALIZACAO");

            entity.Property(e => e.ComercId)
                .ValueGeneratedNever()
                .HasColumnName("COMERC_ID");
            entity.Property(e => e.DataFim).HasColumnName("DATA_FIM");
            entity.Property(e => e.DataInicio).HasColumnName("DATA_INICIO");
            entity.Property(e => e.EmbId).HasColumnName("EMB_ID");
            entity.Property(e => e.EstadoComercId).HasColumnName("ESTADO_COMERC_ID");

            entity.HasOne(d => d.Emb).WithMany(p => p.Comercializacaos)
                .HasForeignKey(d => d.EmbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("EMBALAGEMCOMERCIALIZACAO");

            entity.HasOne(d => d.EstadoComerc).WithMany(p => p.Comercializacaos)
                .HasForeignKey(d => d.EstadoComercId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_ESTADO_COMERCCOMERCIALIZACAO");
        });

        modelBuilder.Entity<Comparticipacao>(entity =>
        {
            entity.HasKey(e => e.CompartId).HasName("COMPARTICIPACAO_PK");

            entity.ToTable("COMPARTICIPACAO");

            entity.Property(e => e.CompartId)
                .ValueGeneratedNever()
                .HasColumnName("COMPART_ID");
            entity.Property(e => e.DataFim).HasColumnName("DATA_FIM");
            entity.Property(e => e.DataInicio).HasColumnName("DATA_INICIO");
            entity.Property(e => e.EmbId).HasColumnName("EMB_ID");
            entity.Property(e => e.NivelCompartId).HasColumnName("NIVEL_COMPART_ID");
            entity.Property(e => e.NormaRegExcId).HasColumnName("NORMA_REG_EXC_ID");
            entity.Property(e => e.RegimeExcecionalId).HasColumnName("REGIME_EXCECIONAL_ID");
            entity.Property(e => e.TipoRegimeId).HasColumnName("TIPO_REGIME_ID");

            entity.HasOne(d => d.Emb).WithMany(p => p.Comparticipacaos)
                .HasForeignKey(d => d.EmbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("EMBALAGEMCOMPARTICIPACAO");

            entity.HasOne(d => d.NivelCompart).WithMany(p => p.Comparticipacaos)
                .HasForeignKey(d => d.NivelCompartId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_NIVEL_COMPARTCOMPARTICIPACAO");

            entity.HasOne(d => d.NormaRegExc).WithMany(p => p.Comparticipacaos)
                .HasForeignKey(d => d.NormaRegExcId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_NORMA_REG_EXCCOMPARTICIPACAO");

            entity.HasOne(d => d.RegimeExcecional).WithMany(p => p.Comparticipacaos)
                .HasForeignKey(d => d.RegimeExcecionalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_REGIME_EXCECIONALCOMPARTICIPACAO");

            entity.HasOne(d => d.TipoRegime).WithMany(p => p.Comparticipacaos)
                .HasForeignKey(d => d.TipoRegimeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_TIPO_REGIMECOMPARTICIPACAO");
        });

        modelBuilder.Entity<CondArmazenamento>(entity =>
        {
            entity.HasKey(e => e.CondArmazId).HasName("COND_ARMAZENAMENTO_PK");

            entity.ToTable("COND_ARMAZENAMENTO");

            entity.Property(e => e.CondArmazId)
                .ValueGeneratedNever()
                .HasColumnName("COND_ARMAZ_ID");
            entity.Property(e => e.EmbId).HasColumnName("EMB_ID");
            entity.Property(e => e.EstadoArmazId).HasColumnName("ESTADO_ARMAZ_ID");
            entity.Property(e => e.NrPrazoVal)
                .HasMaxLength(50)
                .HasColumnName("NR_PRAZO_VAL");
            entity.Property(e => e.TemperaturaArmazId).HasColumnName("TEMPERATURA_ARMAZ_ID");
            entity.Property(e => e.UnidTempPrazoValId).HasColumnName("UNID_TEMP_PRAZO_VAL_ID");

            entity.HasOne(d => d.Emb).WithMany(p => p.CondArmazenamentos)
                .HasForeignKey(d => d.EmbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("EMBALAGEMCOND_ARMAZENAMENTO");

            entity.HasOne(d => d.EstadoArmaz).WithMany(p => p.CondArmazenamentos)
                .HasForeignKey(d => d.EstadoArmazId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_ESTADO_ARMAZCOND_ARMAZENAMENTO");

            entity.HasOne(d => d.TemperaturaArmaz).WithMany(p => p.CondArmazenamentos)
                .HasForeignKey(d => d.TemperaturaArmazId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_TEMPERATURA_ARMAZCOND_ARMAZENAMENTO");

            entity.HasOne(d => d.UnidTempPrazoVal).WithMany(p => p.CondArmazenamentos)
                .HasForeignKey(d => d.UnidTempPrazoValId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_UNIDADE_TEMPORALCOND_ARMAZENAMENTO");
        });

        modelBuilder.Entity<DocumentoAlertum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DOCUMENTO_ALERTA");

            entity.Property(e => e.AlertaId).HasColumnName("ALERTA_ID");
            entity.Property(e => e.DataAprovacao).HasColumnName("DATA_APROVACAO");
            entity.Property(e => e.DestinatarioCidadao)
                .HasMaxLength(1)
                .HasColumnName("DESTINATARIO_CIDADAO");
            entity.Property(e => e.DestinatarioFarmaceutico)
                .HasMaxLength(1)
                .HasColumnName("DESTINATARIO_FARMACEUTICO");
            entity.Property(e => e.DestinatarioMedico)
                .HasMaxLength(1)
                .HasColumnName("DESTINATARIO_MEDICO");
            entity.Property(e => e.EntregaFarmaceutico)
                .HasMaxLength(1)
                .HasColumnName("ENTREGA_FARMACEUTICO");
            entity.Property(e => e.EntregaMedico)
                .HasMaxLength(1)
                .HasColumnName("ENTREGA_MEDICO");
            entity.Property(e => e.Titulo).HasColumnName("TITULO");
            entity.Property(e => e.Url).HasColumnName("URL");

            entity.HasOne(d => d.Alerta).WithMany()
                .HasForeignKey(d => d.AlertaId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ALERTADOCUMENTO_ALERTA");
        });

        modelBuilder.Entity<Embalagem>(entity =>
        {
            entity.HasKey(e => e.EmbId).HasName("EMBALAGEM_PK");

            entity.ToTable("EMBALAGEM");

            entity.Property(e => e.EmbId)
                .ValueGeneratedNever()
                .HasColumnName("EMB_ID");
            entity.Property(e => e.AcondPrimarioId).HasColumnName("ACOND_PRIMARIO_ID");
            entity.Property(e => e.CaractEspecificas)
                .HasMaxLength(255)
                .HasColumnName("CARACT_ESPECIFICAS");
            entity.Property(e => e.Cdm).HasColumnName("CDM");
            entity.Property(e => e.ChnmCod).HasColumnName("CHNM_COD");
            entity.Property(e => e.Cnpem).HasColumnName("CNPEM");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.EstadoEmbId).HasColumnName("ESTADO_EMB_ID");
            entity.Property(e => e.GrupoHomCod)
                .HasMaxLength(6)
                .HasColumnName("GRUPO_HOM_COD");
            entity.Property(e => e.IndDispSeguranca)
                .HasMaxLength(1)
                .HasColumnName("IND_DISP_SEGURANCA");
            entity.Property(e => e.IndEmbHospitalar)
                .HasMaxLength(1)
                .HasColumnName("IND_EMB_HOSPITALAR");
            entity.Property(e => e.IndEmbUnitaria)
                .HasMaxLength(1)
                .HasColumnName("IND_EMB_UNITARIA");
            entity.Property(e => e.NrRegisto)
                .HasMaxLength(20)
                .HasColumnName("NR_REGISTO");
            entity.Property(e => e.PemAmb)
                .HasMaxLength(1)
                .HasColumnName("PEM_AMB");
            entity.Property(e => e.PemAmbBio)
                .HasMaxLength(1)
                .HasColumnName("PEM_AMB_BIO");
            entity.Property(e => e.PemAmbBioMs)
                .HasMaxLength(1)
                .HasColumnName("PEM_AMB_BIO_MS");
            entity.Property(e => e.PemAmbMs)
                .HasMaxLength(1)
                .HasColumnName("PEM_AMB_MS");
            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");
            entity.Property(e => e.QuantTot).HasColumnName("QUANT_TOT");
            entity.Property(e => e.Quantidade).HasColumnName("QUANTIDADE");
            entity.Property(e => e.Referencia)
                .HasMaxLength(255)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.TipoEmbId).HasColumnName("TIPO_EMB_ID");
            entity.Property(e => e.TipoTratamentoId).HasColumnName("TIPO_TRATAMENTO_ID");
            entity.Property(e => e.UnidQuantId).HasColumnName("UNID_QUANT_ID");
            entity.Property(e => e.UnidQuantTotId).HasColumnName("UNID_QUANT_TOT_ID");

            entity.HasOne(d => d.AcondPrimario).WithMany(p => p.Embalagems)
                .HasForeignKey(d => d.AcondPrimarioId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_ACOND_PRIMARIOEMBALAGEM");

            entity.HasOne(d => d.ChnmCodNavigation).WithMany(p => p.Embalagems)
                .HasForeignKey(d => d.ChnmCod)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_CHNMEMBALAGEM");

            entity.HasOne(d => d.EstadoEmb).WithMany(p => p.Embalagems)
                .HasForeignKey(d => d.EstadoEmbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_ESTADO_EMBEMBALAGEM");

            entity.HasOne(d => d.GrupoHomCodNavigation).WithMany(p => p.Embalagems)
                .HasForeignKey(d => d.GrupoHomCod)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_GRUPO_HOMEMBALAGEM");

            entity.HasOne(d => d.Prod).WithMany(p => p.Embalagems)
                .HasForeignKey(d => d.ProdId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("PRODUTOEMBALAGEM");

            entity.HasOne(d => d.TipoEmb).WithMany(p => p.Embalagems)
                .HasForeignKey(d => d.TipoEmbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_TIPO_EMBEMBALAGEM");

            entity.HasOne(d => d.TipoTratamento).WithMany(p => p.Embalagems)
                .HasForeignKey(d => d.TipoTratamentoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_TIPO_TRATAMENTOEMBALAGEM");

            entity.HasOne(d => d.UnidQuant).WithMany(p => p.EmbalagemUnidQuants)
                .HasForeignKey(d => d.UnidQuantId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_UNIDADEEMBALAGEM");

            entity.HasOne(d => d.UnidQuantTot).WithMany(p => p.EmbalagemUnidQuantTots)
                .HasForeignKey(d => d.UnidQuantTotId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_UNIDADEEMBALAGEM1");
        });

        modelBuilder.Entity<Escoamento>(entity =>
        {
            entity.HasKey(e => e.EscoamId).HasName("ESCOAMENTO_PK");

            entity.ToTable("ESCOAMENTO");

            entity.Property(e => e.EscoamId)
                .ValueGeneratedNever()
                .HasColumnName("ESCOAM_ID");
            entity.Property(e => e.DataFim).HasColumnName("DATA_FIM");
            entity.Property(e => e.DataInicio).HasColumnName("DATA_INICIO");
            entity.Property(e => e.EmbId).HasColumnName("EMB_ID");
            entity.Property(e => e.MotivoEscoamId).HasColumnName("MOTIVO_ESCOAM_ID");

            entity.HasOne(d => d.Emb).WithMany(p => p.Escoamentos)
                .HasForeignKey(d => d.EmbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("EMBALAGEMESCOAMENTO");

            entity.HasOne(d => d.MotivoEscoam).WithMany(p => p.Escoamentos)
                .HasForeignKey(d => d.MotivoEscoamId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_MOTIVO_ESCOAMESCOAMENTO");
        });

        modelBuilder.Entity<LnkCondArmazConserv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LNK_COND_ARMAZ_CONSERV");

            entity.Property(e => e.CondArmazId).HasColumnName("COND_ARMAZ_ID");
            entity.Property(e => e.CondConservId).HasColumnName("COND_CONSERV_ID");

            entity.HasOne(d => d.CondArmaz).WithMany()
                .HasForeignKey(d => d.CondArmazId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("COND_ARMAZENAMENTOLNK_COND_ARMAZ_CONSERV");

            entity.HasOne(d => d.CondConserv).WithMany()
                .HasForeignKey(d => d.CondConservId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_COND_CONSERVACAOLNK_COND_ARMAZ_CONSERV");
        });

        modelBuilder.Entity<LnkEmbCnpem>(entity =>
        {
            entity.HasKey(e => e.EmbCnpemId).HasName("LNK_EMB_CNPEM_PK");

            entity.ToTable("LNK_EMB_CNPEM");

            entity.Property(e => e.EmbCnpemId)
                .ValueGeneratedNever()
                .HasColumnName("EMB_CNPEM_ID");
            entity.Property(e => e.Cnpem).HasColumnName("CNPEM");
            entity.Property(e => e.DataFim).HasColumnName("DATA_FIM");
            entity.Property(e => e.DataInicio).HasColumnName("DATA_INICIO");
            entity.Property(e => e.EmbId).HasColumnName("EMB_ID");

            entity.HasOne(d => d.Emb).WithMany(p => p.LnkEmbCnpems)
                .HasForeignKey(d => d.EmbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("EMBALAGEMLNK_EMB_CNPEM");
        });

        modelBuilder.Entity<LnkProdAtc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LNK_PROD_ATC");

            entity.Property(e => e.AtcCod)
                .HasMaxLength(10)
                .HasColumnName("ATC_COD");
            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");

            entity.HasOne(d => d.AtcCodNavigation).WithMany()
                .HasForeignKey(d => d.AtcCod)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_ATCLNK_PROD_ATC");

            entity.HasOne(d => d.Prod).WithMany()
                .HasForeignKey(d => d.ProdId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("PRODUTOLNK_PROD_ATC");
        });

        modelBuilder.Entity<LnkProdCft>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LNK_PROD_CFT");

            entity.Property(e => e.CftChnm)
                .HasMaxLength(1)
                .HasColumnName("CFT_CHNM");
            entity.Property(e => e.CftCod)
                .HasMaxLength(14)
                .HasColumnName("CFT_COD");
            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");

            entity.HasOne(d => d.CftCodNavigation).WithMany()
                .HasForeignKey(d => d.CftCod)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_CFTLNK_PROD_CFT");

            entity.HasOne(d => d.Prod).WithMany()
                .HasForeignKey(d => d.ProdId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("PRODUTOLNK_PROD_CFT");
        });

        modelBuilder.Entity<LnkProdClassDisp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LNK_PROD_CLASS_DISP");

            entity.Property(e => e.ClassDispProdId).HasColumnName("CLASS_DISP_PROD_ID");
            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");

            entity.HasOne(d => d.ClassDispProd).WithMany()
                .HasForeignKey(d => d.ClassDispProdId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_CLASS_DISPENSA_PRODLNK_PROD_CLASS_DISP");

            entity.HasOne(d => d.Prod).WithMany()
                .HasForeignKey(d => d.ProdId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("PRODUTOLNK_PROD_CLASS_DISP");
        });

        modelBuilder.Entity<LnkProdGrupoProd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LNK_PROD_GRUPO_PROD");

            entity.Property(e => e.GrupoProdutoId).HasColumnName("GRUPO_PRODUTO_ID");
            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");

            entity.HasOne(d => d.GrupoProduto).WithMany()
                .HasForeignKey(d => d.GrupoProdutoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_GRUPO_PRODUTOLNK_PROD_GRUPO_PROD");

            entity.HasOne(d => d.Prod).WithMany()
                .HasForeignKey(d => d.ProdId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("PRODUTOLNK_PROD_GRUPO_PROD");
        });

        modelBuilder.Entity<LnkProdSubgrupoProd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LNK_PROD_SUBGRUPO_PROD");

            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");
            entity.Property(e => e.SubgrupoProdutoId).HasColumnName("SUBGRUPO_PRODUTO_ID");

            entity.HasOne(d => d.Prod).WithMany()
                .HasForeignKey(d => d.ProdId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("PRODUTOLNK_PROD_SUBGRUPO_PROD");

            entity.HasOne(d => d.SubgrupoProduto).WithMany()
                .HasForeignKey(d => d.SubgrupoProdutoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_SUBGRUPO_PRODUTOLNK_PROD_SUBGRUPO_PROD");
        });

        modelBuilder.Entity<LnkProdSubst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LNK_PROD_SUBST");

            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");
            entity.Property(e => e.Quantidade)
                .HasMaxLength(50)
                .HasColumnName("QUANTIDADE");
            entity.Property(e => e.SubstId).HasColumnName("SUBST_ID");
            entity.Property(e => e.UnidQuantId).HasColumnName("UNID_QUANT_ID");

            entity.HasOne(d => d.Prod).WithMany()
                .HasForeignKey(d => d.ProdId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("PRODUTOLNK_PROD_SUBST");

            entity.HasOne(d => d.Subst).WithMany()
                .HasForeignKey(d => d.SubstId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_SUBSTANCIALNK_PROD_SUBST");

            entity.HasOne(d => d.UnidQuant).WithMany()
                .HasForeignKey(d => d.UnidQuantId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_UNIDADELNK_PROD_SUBST");
        });

        modelBuilder.Entity<LnkProdViaAdmin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LNK_PROD_VIA_ADMIN");

            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");
            entity.Property(e => e.ViaAdminId).HasColumnName("VIA_ADMIN_ID");

            entity.HasOne(d => d.Prod).WithMany()
                .HasForeignKey(d => d.ProdId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("PRODUTOLNK_PROD_VIA_ADMIN");

            entity.HasOne(d => d.ViaAdmin).WithMany()
                .HasForeignKey(d => d.ViaAdminId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_VIA_ADMINLNK_PROD_VIA_ADMIN");
        });

        modelBuilder.Entity<MensagemAlertum>(entity =>
        {
            entity.HasKey(e => e.MensagemAlertaId).HasName("MENSAGEM_ALERTA_PK");

            entity.ToTable("MENSAGEM_ALERTA");

            entity.Property(e => e.MensagemAlertaId)
                .ValueGeneratedNever()
                .HasColumnName("MENSAGEM_ALERTA_ID");
            entity.Property(e => e.AlertaId).HasColumnName("ALERTA_ID");
            entity.Property(e => e.EmbId).HasColumnName("EMB_ID");
            entity.Property(e => e.Idioma)
                .HasMaxLength(255)
                .HasColumnName("IDIOMA");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("LINK");
            entity.Property(e => e.Mensagem).HasColumnName("MENSAGEM");
            entity.Property(e => e.TipoDestinatarioId).HasColumnName("TIPO_DESTINATARIO_ID");

            entity.HasOne(d => d.Alerta).WithMany(p => p.MensagemAlerta)
                .HasForeignKey(d => d.AlertaId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ALERTAMENSAGEM_ALERTA");

            entity.HasOne(d => d.Emb).WithMany(p => p.MensagemAlerta)
                .HasForeignKey(d => d.EmbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("EMBALAGEMMENSAGEM_ALERTA");

            entity.HasOne(d => d.TipoDestinatario).WithMany(p => p.MensagemAlerta)
                .HasForeignKey(d => d.TipoDestinatarioId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_TIPO_DESTINATARIOMENSAGEM_ALERTA");
        });

        modelBuilder.Entity<Preco>(entity =>
        {
            entity.HasKey(e => e.PrecoId).HasName("PRECO_PK");

            entity.ToTable("PRECO");

            entity.Property(e => e.PrecoId)
                .ValueGeneratedNever()
                .HasColumnName("PRECO_ID");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasColumnName("ATIVO");
            entity.Property(e => e.AtivoMs)
                .HasMaxLength(1)
                .HasColumnName("ATIVO_MS");
            entity.Property(e => e.DataFim).HasColumnName("DATA_FIM");
            entity.Property(e => e.DataInicio).HasColumnName("DATA_INICIO");
            entity.Property(e => e.EmbId).HasColumnName("EMB_ID");
            entity.Property(e => e.Preco1).HasColumnName("PRECO");
            entity.Property(e => e.TipoPrecoId).HasColumnName("TIPO_PRECO_ID");

            entity.HasOne(d => d.Emb).WithMany(p => p.Precos)
                .HasForeignKey(d => d.EmbId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("EMBALAGEMPRECO");

            entity.HasOne(d => d.TipoPreco).WithMany(p => p.Precos)
                .HasForeignKey(d => d.TipoPrecoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_TIPO_PRECOPRECO");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.ProdId).HasName("PRODUTO_PK");

            entity.ToTable("PRODUTO");

            entity.Property(e => e.ProdId)
                .ValueGeneratedNever()
                .HasColumnName("PROD_ID");
            entity.Property(e => e.AgrupFormaFarmId).HasColumnName("AGRUP_FORMA_FARM_ID");
            entity.Property(e => e.ClassEstpPsictrId).HasColumnName("CLASS_ESTP_PSICTR_ID");
            entity.Property(e => e.DataAim).HasColumnName("DATA_AIM");
            entity.Property(e => e.DataAlteracao).HasColumnName("DATA_ALTERACAO");
            entity.Property(e => e.DataEstAim).HasColumnName("DATA_EST_AIM");
            entity.Property(e => e.DciptId).HasColumnName("DCIPT_ID");
            entity.Property(e => e.Dosagem)
                .HasMaxLength(30)
                .HasColumnName("DOSAGEM");
            entity.Property(e => e.DosagemCedencia).HasColumnName("DOSAGEM_CEDENCIA");
            entity.Property(e => e.EstadoAimId).HasColumnName("ESTADO_AIM_ID");
            entity.Property(e => e.FormaFarmId).HasColumnName("FORMA_FARM_ID");
            entity.Property(e => e.IndFnm)
                .HasMaxLength(1)
                .HasColumnName("IND_FNM");
            entity.Property(e => e.IndGenerico)
                .HasMaxLength(1)
                .HasColumnName("IND_GENERICO");
            entity.Property(e => e.IndMargemTerap)
                .HasMaxLength(1)
                .HasColumnName("IND_MARGEM_TERAP");
            entity.Property(e => e.IndMonitAdicionalFv)
                .HasMaxLength(1)
                .HasColumnName("IND_MONIT_ADICIONAL_FV");
            entity.Property(e => e.Marca)
                .HasMaxLength(255)
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo)
                .HasMaxLength(255)
                .HasColumnName("MODELO");
            entity.Property(e => e.Nome).HasColumnName("NOME");
            entity.Property(e => e.NrProcesso)
                .HasMaxLength(50)
                .HasColumnName("NR_PROCESSO");
            entity.Property(e => e.ProdGuid)
                .HasMaxLength(50)
                .HasColumnName("PROD_GUID");
            entity.Property(e => e.TipoAutorizId).HasColumnName("TIPO_AUTORIZ_ID");
            entity.Property(e => e.TipoProcedimentoId).HasColumnName("TIPO_PROCEDIMENTO_ID");
            entity.Property(e => e.TipoProdutoId).HasColumnName("TIPO_PRODUTO_ID");
            entity.Property(e => e.TitularAimId).HasColumnName("TITULAR_AIM_ID");

            entity.HasOne(d => d.AgrupFormaFarm).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.AgrupFormaFarmId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_AGRUP_FORMA_FARMPRODUTO");

            entity.HasOne(d => d.ClassEstpPsictr).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.ClassEstpPsictrId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_CLASS_ESTP_PSICTRPRODUTO");

            entity.HasOne(d => d.Dcipt).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.DciptId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_DCIPTPRODUTO");

            entity.HasOne(d => d.EstadoAim).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.EstadoAimId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_ESTADO_AIMPRODUTO");

            entity.HasOne(d => d.FormaFarm).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.FormaFarmId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_FORMA_FARMPRODUTO");

            entity.HasOne(d => d.TipoAutoriz).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.TipoAutorizId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_TIPO_AUTORIZPRODUTO");

            entity.HasOne(d => d.TipoProcedimento).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.TipoProcedimentoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_TIPO_PROCEDIMENTOPRODUTO");

            entity.HasOne(d => d.TipoProduto).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.TipoProdutoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_TIPO_PRODUTOPRODUTO");

            entity.HasOne(d => d.TitularAim).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.TitularAimId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_TITULAR_AIMPRODUTO");
        });

        modelBuilder.Entity<ProdutoOperacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PRODUTO_OPERACAO");

            entity.Property(e => e.Data).HasColumnName("DATA");
            entity.Property(e => e.Operacao)
                .HasMaxLength(255)
                .HasColumnName("OPERACAO");
            entity.Property(e => e.ProdId).HasColumnName("PROD_ID");
        });

        modelBuilder.Entity<RefAcondPrimario>(entity =>
        {
            entity.HasKey(e => e.AcondPrimarioId).HasName("REF_ACOND_PRIMARIO_PK");

            entity.ToTable("REF_ACOND_PRIMARIO");

            entity.Property(e => e.AcondPrimarioId)
                .ValueGeneratedNever()
                .HasColumnName("ACOND_PRIMARIO_ID");
            entity.Property(e => e.AbrevChnm)
                .HasMaxLength(100)
                .HasColumnName("ABREV_CHNM");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefAgrupFormaFarm>(entity =>
        {
            entity.HasKey(e => e.AgrupFormaFarmId).HasName("REF_AGRUP_FORMA_FARM_PK");

            entity.ToTable("REF_AGRUP_FORMA_FARM");

            entity.Property(e => e.AgrupFormaFarmId)
                .ValueGeneratedNever()
                .HasColumnName("AGRUP_FORMA_FARM_ID");
            entity.Property(e => e.Abrev)
                .HasMaxLength(100)
                .HasColumnName("ABREV");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefAtc>(entity =>
        {
            entity.HasKey(e => e.AtcCod).HasName("REF_ATC_PK");

            entity.ToTable("REF_ATC");

            entity.Property(e => e.AtcCod)
                .HasMaxLength(10)
                .HasColumnName("ATC_COD");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefCft>(entity =>
        {
            entity.HasKey(e => e.CftCod).HasName("REF_CFT_PK");

            entity.ToTable("REF_CFT");

            entity.Property(e => e.CftCod)
                .HasMaxLength(14)
                .HasColumnName("CFT_COD");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefChnm>(entity =>
        {
            entity.HasKey(e => e.ChnmCod).HasName("REF_CHNM_PK");

            entity.ToTable("REF_CHNM");

            entity.Property(e => e.ChnmCod)
                .ValueGeneratedNever()
                .HasColumnName("CHNM_COD");
            entity.Property(e => e.Data).HasColumnName("DATA");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
        });

        modelBuilder.Entity<RefClassDispensaProd>(entity =>
        {
            entity.HasKey(e => e.ClassDispProdId).HasName("REF_CLASS_DISPENSA_PROD_PK");

            entity.ToTable("REF_CLASS_DISPENSA_PROD");

            entity.Property(e => e.ClassDispProdId)
                .ValueGeneratedNever()
                .HasColumnName("CLASS_DISP_PROD_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefClassEstpPsictr>(entity =>
        {
            entity.HasKey(e => e.ClassEstpPsictrId).HasName("REF_CLASS_ESTP_PSICTR_PK");

            entity.ToTable("REF_CLASS_ESTP_PSICTR");

            entity.Property(e => e.ClassEstpPsictrId)
                .ValueGeneratedNever()
                .HasColumnName("CLASS_ESTP_PSICTR_ID");
            entity.Property(e => e.Abrev)
                .HasMaxLength(100)
                .HasColumnName("ABREV");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefCondConservacao>(entity =>
        {
            entity.HasKey(e => e.CondConservId).HasName("REF_COND_CONSERVACAO_PK");

            entity.ToTable("REF_COND_CONSERVACAO");

            entity.Property(e => e.CondConservId)
                .ValueGeneratedNever()
                .HasColumnName("COND_CONSERV_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefDcipt>(entity =>
        {
            entity.HasKey(e => e.DciptId).HasName("REF_DCIPT_PK");

            entity.ToTable("REF_DCIPT");

            entity.Property(e => e.DciptId)
                .ValueGeneratedNever()
                .HasColumnName("DCIPT_ID");
            entity.Property(e => e.AbrevChnm)
                .HasMaxLength(100)
                .HasColumnName("ABREV_CHNM");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefEstadoAim>(entity =>
        {
            entity.HasKey(e => e.EstadoAimId).HasName("REF_ESTADO_AIM_PK");

            entity.ToTable("REF_ESTADO_AIM");

            entity.Property(e => e.EstadoAimId)
                .ValueGeneratedNever()
                .HasColumnName("ESTADO_AIM_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefEstadoArmaz>(entity =>
        {
            entity.HasKey(e => e.EstadoArmazId).HasName("REF_ESTADO_ARMAZ_PK");

            entity.ToTable("REF_ESTADO_ARMAZ");

            entity.Property(e => e.EstadoArmazId)
                .ValueGeneratedNever()
                .HasColumnName("ESTADO_ARMAZ_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefEstadoComerc>(entity =>
        {
            entity.HasKey(e => e.EstComercId).HasName("REF_ESTADO_COMERC_PK");

            entity.ToTable("REF_ESTADO_COMERC");

            entity.Property(e => e.EstComercId)
                .ValueGeneratedNever()
                .HasColumnName("EST_COMERC_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefEstadoEmb>(entity =>
        {
            entity.HasKey(e => e.EstadoEmbId).HasName("REF_ESTADO_EMB_PK");

            entity.ToTable("REF_ESTADO_EMB");

            entity.Property(e => e.EstadoEmbId)
                .ValueGeneratedNever()
                .HasColumnName("ESTADO_EMB_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefFormaFarm>(entity =>
        {
            entity.HasKey(e => e.FormaFarmId).HasName("REF_FORMA_FARM_PK");

            entity.ToTable("REF_FORMA_FARM");

            entity.Property(e => e.FormaFarmId)
                .ValueGeneratedNever()
                .HasColumnName("FORMA_FARM_ID");
            entity.Property(e => e.Abrev)
                .HasMaxLength(100)
                .HasColumnName("ABREV");
            entity.Property(e => e.AbrevChnm)
                .HasMaxLength(100)
                .HasColumnName("ABREV_CHNM");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefGrupoHom>(entity =>
        {
            entity.HasKey(e => e.GrupoHomCod).HasName("REF_GRUPO_HOM_PK");

            entity.ToTable("REF_GRUPO_HOM");

            entity.Property(e => e.GrupoHomCod)
                .HasMaxLength(6)
                .HasColumnName("GRUPO_HOM_COD");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefGrupoProduto>(entity =>
        {
            entity.HasKey(e => e.GrupoProdutoId).HasName("REF_GRUPO_PRODUTO_PK");

            entity.ToTable("REF_GRUPO_PRODUTO");

            entity.Property(e => e.GrupoProdutoId)
                .ValueGeneratedNever()
                .HasColumnName("GRUPO_PRODUTO_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefLocalDispensa>(entity =>
        {
            entity.HasKey(e => e.LocalDispensaId).HasName("REF_LOCAL_DISPENSA_PK");

            entity.ToTable("REF_LOCAL_DISPENSA");

            entity.Property(e => e.LocalDispensaId)
                .ValueGeneratedNever()
                .HasColumnName("LOCAL_DISPENSA_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefMotivoEscoam>(entity =>
        {
            entity.HasKey(e => e.MotivoEscoamId).HasName("REF_MOTIVO_ESCOAM_PK");

            entity.ToTable("REF_MOTIVO_ESCOAM");

            entity.Property(e => e.MotivoEscoamId)
                .ValueGeneratedNever()
                .HasColumnName("MOTIVO_ESCOAM_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefNivelCompart>(entity =>
        {
            entity.HasKey(e => e.NivelCompartId).HasName("REF_NIVEL_COMPART_PK");

            entity.ToTable("REF_NIVEL_COMPART");

            entity.Property(e => e.NivelCompartId)
                .ValueGeneratedNever()
                .HasColumnName("NIVEL_COMPART_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
            entity.Property(e => e.PercentCompart).HasColumnName("PERCENT_COMPART");
        });

        modelBuilder.Entity<RefNormaRegExc>(entity =>
        {
            entity.HasKey(e => e.NormaRegExcId).HasName("REF_NORMA_REG_EXC_PK");

            entity.ToTable("REF_NORMA_REG_EXC");

            entity.Property(e => e.NormaRegExcId)
                .ValueGeneratedNever()
                .HasColumnName("NORMA_REG_EXC_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
            entity.Property(e => e.LocalDispensaId).HasColumnName("LOCAL_DISPENSA_ID");

            entity.HasOne(d => d.LocalDispensa).WithMany(p => p.RefNormaRegExcs)
                .HasForeignKey(d => d.LocalDispensaId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("REF_LOCAL_DISPENSAREF_NORMA_REG_EXC");
        });

        modelBuilder.Entity<RefRegimeExcecional>(entity =>
        {
            entity.HasKey(e => e.RegimeExcecionalId).HasName("REF_REGIME_EXCECIONAL_PK");

            entity.ToTable("REF_REGIME_EXCECIONAL");

            entity.Property(e => e.RegimeExcecionalId)
                .ValueGeneratedNever()
                .HasColumnName("REGIME_EXCECIONAL_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefSexo>(entity =>
        {
            entity.HasKey(e => e.SexoId).HasName("REF_SEXO_PK");

            entity.ToTable("REF_SEXO");

            entity.Property(e => e.SexoId)
                .ValueGeneratedNever()
                .HasColumnName("SEXO_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefSubgrupoProduto>(entity =>
        {
            entity.HasKey(e => e.SubgrupoProdutoId).HasName("REF_SUBGRUPO_PRODUTO_PK");

            entity.ToTable("REF_SUBGRUPO_PRODUTO");

            entity.Property(e => e.SubgrupoProdutoId)
                .ValueGeneratedNever()
                .HasColumnName("SUBGRUPO_PRODUTO_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefSubstancium>(entity =>
        {
            entity.HasKey(e => e.SubstId).HasName("REF_SUBSTANCIA_PK");

            entity.ToTable("REF_SUBSTANCIA");

            entity.Property(e => e.SubstId)
                .ValueGeneratedNever()
                .HasColumnName("SUBST_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefTemperaturaArmaz>(entity =>
        {
            entity.HasKey(e => e.TemperaturaArmazId).HasName("REF_TEMPERATURA_ARMAZ_PK");

            entity.ToTable("REF_TEMPERATURA_ARMAZ");

            entity.Property(e => e.TemperaturaArmazId)
                .ValueGeneratedNever()
                .HasColumnName("TEMPERATURA_ARMAZ_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefTipoAlertum>(entity =>
        {
            entity.HasKey(e => e.TipoAlertaId).HasName("REF_TIPO_ALERTA_PK");

            entity.ToTable("REF_TIPO_ALERTA");

            entity.Property(e => e.TipoAlertaId)
                .ValueGeneratedNever()
                .HasColumnName("TIPO_ALERTA_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefTipoApresentacao>(entity =>
        {
            entity.HasKey(e => e.TipoApresentacaoId).HasName("REF_TIPO_APRESENTACAO_PK");

            entity.ToTable("REF_TIPO_APRESENTACAO");

            entity.Property(e => e.TipoApresentacaoId)
                .ValueGeneratedNever()
                .HasColumnName("TIPO_APRESENTACAO_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefTipoAutoriz>(entity =>
        {
            entity.HasKey(e => e.TipoAutorizId).HasName("REF_TIPO_AUTORIZ_PK");

            entity.ToTable("REF_TIPO_AUTORIZ");

            entity.Property(e => e.TipoAutorizId)
                .ValueGeneratedNever()
                .HasColumnName("TIPO_AUTORIZ_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefTipoDestinatario>(entity =>
        {
            entity.HasKey(e => e.TipoDestinatarioId).HasName("REF_TIPO_DESTINATARIO_PK");

            entity.ToTable("REF_TIPO_DESTINATARIO");

            entity.Property(e => e.TipoDestinatarioId)
                .ValueGeneratedNever()
                .HasColumnName("TIPO_DESTINATARIO_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefTipoEmb>(entity =>
        {
            entity.HasKey(e => e.TipoEmbId).HasName("REF_TIPO_EMB_PK");

            entity.ToTable("REF_TIPO_EMB");

            entity.Property(e => e.TipoEmbId)
                .ValueGeneratedNever()
                .HasColumnName("TIPO_EMB_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefTipoPreco>(entity =>
        {
            entity.HasKey(e => e.TipoPrecoId).HasName("REF_TIPO_PRECO_PK");

            entity.ToTable("REF_TIPO_PRECO");

            entity.Property(e => e.TipoPrecoId)
                .ValueGeneratedNever()
                .HasColumnName("TIPO_PRECO_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefTipoProcedimento>(entity =>
        {
            entity.HasKey(e => e.TipoProcedimentoId).HasName("REF_TIPO_PROCEDIMENTO_PK");

            entity.ToTable("REF_TIPO_PROCEDIMENTO");

            entity.Property(e => e.TipoProcedimentoId)
                .ValueGeneratedNever()
                .HasColumnName("TIPO_PROCEDIMENTO_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefTipoProduto>(entity =>
        {
            entity.HasKey(e => e.TipoProdutoId).HasName("REF_TIPO_PRODUTO_PK");

            entity.ToTable("REF_TIPO_PRODUTO");

            entity.Property(e => e.TipoProdutoId)
                .ValueGeneratedNever()
                .HasColumnName("TIPO_PRODUTO_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefTipoRegime>(entity =>
        {
            entity.HasKey(e => e.TipoRegimeId).HasName("REF_TIPO_REGIME_PK");

            entity.ToTable("REF_TIPO_REGIME");

            entity.Property(e => e.TipoRegimeId)
                .ValueGeneratedNever()
                .HasColumnName("TIPO_REGIME_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefTipoTratamento>(entity =>
        {
            entity.HasKey(e => e.TipoTratamentoId).HasName("REF_TIPO_TRATAMENTO_PK");

            entity.ToTable("REF_TIPO_TRATAMENTO");

            entity.Property(e => e.TipoTratamentoId)
                .ValueGeneratedNever()
                .HasColumnName("TIPO_TRATAMENTO_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefTitularAim>(entity =>
        {
            entity.HasKey(e => e.TitularAimId).HasName("REF_TITULAR_AIM_PK");

            entity.ToTable("REF_TITULAR_AIM");

            entity.Property(e => e.TitularAimId)
                .ValueGeneratedNever()
                .HasColumnName("TITULAR_AIM_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
        });

        modelBuilder.Entity<RefUnidade>(entity =>
        {
            entity.HasKey(e => e.UnidadeId).HasName("REF_UNIDADE_PK");

            entity.ToTable("REF_UNIDADE");

            entity.Property(e => e.UnidadeId)
                .ValueGeneratedNever()
                .HasColumnName("UNIDADE_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefUnidadeTemporal>(entity =>
        {
            entity.HasKey(e => e.UnidadeTemporalId).HasName("REF_UNIDADE_TEMPORAL_PK");

            entity.ToTable("REF_UNIDADE_TEMPORAL");

            entity.Property(e => e.UnidadeTemporalId)
                .ValueGeneratedNever()
                .HasColumnName("UNIDADE_TEMPORAL_ID");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<RefViaAdmin>(entity =>
        {
            entity.HasKey(e => e.ViaAdminId).HasName("REF_VIA_ADMIN_PK");

            entity.ToTable("REF_VIA_ADMIN");

            entity.Property(e => e.ViaAdminId)
                .ValueGeneratedNever()
                .HasColumnName("VIA_ADMIN_ID");
            entity.Property(e => e.AbrevChnm)
                .HasMaxLength(100)
                .HasColumnName("ABREV_CHNM");
            entity.Property(e => e.Descr)
                .HasMaxLength(255)
                .HasColumnName("DESCR");
            entity.Property(e => e.IndAtivo)
                .HasMaxLength(1)
                .HasColumnName("IND_ATIVO");
        });

        modelBuilder.Entity<User>()
               .Property(u => u.Role)
               .HasConversion<string>();

        modelBuilder.Entity<MedicationRequest>()
            .Property(m => m.Status)
            .HasConversion<string>();

        modelBuilder.Entity<Notification>()
            .Property(n => n.Type)
            .HasConversion<string>();

        modelBuilder.Entity<Notification>()
            .Property(n => n.Priority)
            .HasConversion<string>();

        modelBuilder.Entity<MedicationSchedule>()
            .Property(m => m.Frequency)
            .HasConversion<string>();

        modelBuilder.Entity<MedicationSchedule>()
            .Property(m => m.DosageUnits)
            .HasConversion<string>();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
