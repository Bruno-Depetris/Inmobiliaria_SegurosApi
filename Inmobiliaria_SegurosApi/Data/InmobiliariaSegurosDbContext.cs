using System;
using System.Collections.Generic;
using Inmobiliaria_SegurosApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria_SegurosApi.Data;

public partial class InmobiliariaSegurosDbContext : DbContext
{
    public InmobiliariaSegurosDbContext(DbContextOptions<InmobiliariaSegurosDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Barrio> Barrios { get; set; }

    public virtual DbSet<Canales_Notif> Canales_Notifs { get; set; }

    public virtual DbSet<Ciudade> Ciudades { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Comisione> Comisiones { get; set; }

    public virtual DbSet<Contrato> Contratos { get; set; }

    public virtual DbSet<Estados_Civil> Estados_Civils { get; set; }

    public virtual DbSet<Estados_Contrato> Estados_Contratos { get; set; }

    public virtual DbSet<Estados_Envio> Estados_Envios { get; set; }

    public virtual DbSet<Estados_Pago> Estados_Pagos { get; set; }

    public virtual DbSet<Estados_Propiedad> Estados_Propiedads { get; set; }

    public virtual DbSet<Estados_Seguro> Estados_Seguros { get; set; }

    public virtual DbSet<Estados_Usuario> Estados_Usuarios { get; set; }

    public virtual DbSet<Fotos_Propiedade> Fotos_Propiedades { get; set; }

    public virtual DbSet<Interesado> Interesados { get; set; }

    public virtual DbSet<Log_Actividade> Log_Actividades { get; set; }

    public virtual DbSet<Metodos_Pago> Metodos_Pagos { get; set; }

    public virtual DbSet<Moneda> Monedas { get; set; }

    public virtual DbSet<Notificacione> Notificaciones { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Productore> Productores { get; set; }

    public virtual DbSet<Propiedade> Propiedades { get; set; }

    public virtual DbSet<Roles_Cliente> Roles_Clientes { get; set; }

    public virtual DbSet<Roles_Usuario> Roles_Usuarios { get; set; }

    public virtual DbSet<Seguro> Seguros { get; set; }

    public virtual DbSet<Sesiones_JWT> Sesiones_JWTs { get; set; }

    public virtual DbSet<Tipos_Destinatario> Tipos_Destinatarios { get; set; }

    public virtual DbSet<Tipos_Documento> Tipos_Documentos { get; set; }

    public virtual DbSet<Tipos_Intere> Tipos_Interes { get; set; }

    public virtual DbSet<Tipos_Notificacion> Tipos_Notificacions { get; set; }

    public virtual DbSet<Tipos_Pago> Tipos_Pagos { get; set; }

    public virtual DbSet<Tipos_Propiedad> Tipos_Propiedads { get; set; }

    public virtual DbSet<Tipos_Seguro> Tipos_Seguros { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<V_Contratos_Completo> V_Contratos_Completos { get; set; }

    public virtual DbSet<V_Pagos_Pendiente> V_Pagos_Pendientes { get; set; }

    public virtual DbSet<Variables_Impositiva> Variables_Impositivas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Barrio>(entity =>
        {
            entity.HasKey(e => e.BarrioID).HasName("PRIMARY");

            entity.HasIndex(e => e.CiudadID, "fk_barrios_ciudad");

            entity.Property(e => e.Estado).HasDefaultValueSql("'1'");
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Ciudad).WithMany(p => p.Barrios)
                .HasForeignKey(d => d.CiudadID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_barrios_ciudad");
        });

        modelBuilder.Entity<Canales_Notif>(entity =>
        {
            entity.HasKey(e => e.CanalID).HasName("PRIMARY");

            entity.ToTable("Canales_Notif");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.CanalID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(30);
        });

        modelBuilder.Entity<Ciudade>(entity =>
        {
            entity.HasKey(e => e.CiudadID).HasName("PRIMARY");

            entity.Property(e => e.Codigo_Postal).HasMaxLength(10);
            entity.Property(e => e.Estado).HasDefaultValueSql("'1'");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Provincia).HasMaxLength(100);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteID).HasName("PRIMARY");

            entity.HasIndex(e => e.Codigo_Cliente, "Codigo_Cliente").IsUnique();

            entity.HasIndex(e => e.PersonaID, "fk_clientes_persona");

            entity.HasIndex(e => e.UsuarioID, "fk_clientes_usuario");

            entity.Property(e => e.Calificacion_Crediticia).HasMaxLength(20);
            entity.Property(e => e.Codigo_Cliente).HasMaxLength(20);
            entity.Property(e => e.Fecha_Alta)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Ingresos_Declarados).HasPrecision(15, 2);
            entity.Property(e => e.Observaciones).HasColumnType("text");

            entity.HasOne(d => d.Persona).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.PersonaID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientes_persona");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.UsuarioID)
                .HasConstraintName("fk_clientes_usuario");

            entity.HasMany(d => d.RolClientes).WithMany(p => p.Clientes)
                .UsingEntity<Dictionary<string, object>>(
                    "Cliente_Role",
                    r => r.HasOne<Roles_Cliente>().WithMany()
                        .HasForeignKey("RolClienteID")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_clienterol_rol"),
                    l => l.HasOne<Cliente>().WithMany()
                        .HasForeignKey("ClienteID")
                        .HasConstraintName("fk_clienterol_cliente"),
                    j =>
                    {
                        j.HasKey("ClienteID", "RolClienteID")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("Cliente_Roles");
                        j.HasIndex(new[] { "RolClienteID" }, "fk_clienterol_rol");
                    });
        });

        modelBuilder.Entity<Comisione>(entity =>
        {
            entity.HasKey(e => e.ComisionID).HasName("PRIMARY");

            entity.HasIndex(e => e.ContratoID, "fk_comisiones_contrato");

            entity.HasIndex(e => e.ProductorID, "fk_comisiones_productor");

            entity.HasIndex(e => e.SeguroID, "fk_comisiones_seguro");

            entity.HasIndex(e => e.UsuarioID, "fk_comisiones_usuario");

            entity.Property(e => e.Estado_Comision)
                .HasMaxLength(20)
                .HasDefaultValueSql("'Pendiente'");
            entity.Property(e => e.Fecha_Creacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Monto_Base).HasPrecision(15, 2);
            entity.Property(e => e.Monto_Comision).HasPrecision(15, 2);
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Porcentaje).HasPrecision(5, 2);
            entity.Property(e => e.Tipo_Comision).HasMaxLength(30);

            entity.HasOne(d => d.Contrato).WithMany(p => p.Comisiones)
                .HasForeignKey(d => d.ContratoID)
                .HasConstraintName("fk_comisiones_contrato");

            entity.HasOne(d => d.Productor).WithMany(p => p.Comisiones)
                .HasForeignKey(d => d.ProductorID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_comisiones_productor");

            entity.HasOne(d => d.Seguro).WithMany(p => p.Comisiones)
                .HasForeignKey(d => d.SeguroID)
                .HasConstraintName("fk_comisiones_seguro");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Comisiones)
                .HasForeignKey(d => d.UsuarioID)
                .HasConstraintName("fk_comisiones_usuario");
        });

        modelBuilder.Entity<Contrato>(entity =>
        {
            entity.HasKey(e => e.ContratoID).HasName("PRIMARY");

            entity.HasIndex(e => e.Numero_Contrato, "Numero_Contrato").IsUnique();

            entity.HasIndex(e => e.EstadoContratoID, "fk_contratos_estadocon");

            entity.HasIndex(e => e.InquilinoID, "fk_contratos_inquilino");

            entity.HasIndex(e => e.MonedaID, "fk_contratos_moneda");

            entity.HasIndex(e => e.ProductorID, "fk_contratos_productor");

            entity.HasIndex(e => e.PropiedadID, "fk_contratos_propiedad");

            entity.HasIndex(e => e.PropietarioID, "fk_contratos_propietario");

            entity.HasIndex(e => e.UsuarioID, "fk_contratos_usuario");

            entity.Property(e => e.Archivo_Contrato).HasMaxLength(500);
            entity.Property(e => e.Deposito_Garantia).HasPrecision(15, 2);
            entity.Property(e => e.EstadoContratoID).HasDefaultValueSql("'1'");
            entity.Property(e => e.Fecha_Creacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Incremento_Meses).HasDefaultValueSql("'12'");
            entity.Property(e => e.Incremento_Porcentaje).HasPrecision(5, 2);
            entity.Property(e => e.MonedaID).HasDefaultValueSql("'1'");
            entity.Property(e => e.Monto_Alquiler).HasPrecision(15, 2);
            entity.Property(e => e.Numero_Contrato).HasMaxLength(30);
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Vencimiento_Pago).HasDefaultValueSql("'10'");

            entity.HasOne(d => d.EstadoContrato).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.EstadoContratoID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contratos_estadocon");

            entity.HasOne(d => d.Inquilino).WithMany(p => p.ContratoInquilinos)
                .HasForeignKey(d => d.InquilinoID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contratos_inquilino");

            entity.HasOne(d => d.Moneda).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.MonedaID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contratos_moneda");

            entity.HasOne(d => d.Productor).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.ProductorID)
                .HasConstraintName("fk_contratos_productor");

            entity.HasOne(d => d.Propiedad).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.PropiedadID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contratos_propiedad");

            entity.HasOne(d => d.Propietario).WithMany(p => p.ContratoPropietarios)
                .HasForeignKey(d => d.PropietarioID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contratos_propietario");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.UsuarioID)
                .HasConstraintName("fk_contratos_usuario");
        });

        modelBuilder.Entity<Estados_Civil>(entity =>
        {
            entity.HasKey(e => e.EstadoCivilID).HasName("PRIMARY");

            entity.ToTable("Estados_Civil");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.EstadoCivilID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(30);
        });

        modelBuilder.Entity<Estados_Contrato>(entity =>
        {
            entity.HasKey(e => e.EstadoContratoID).HasName("PRIMARY");

            entity.ToTable("Estados_Contrato");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.EstadoContratoID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Estados_Envio>(entity =>
        {
            entity.HasKey(e => e.EstadoEnvioID).HasName("PRIMARY");

            entity.ToTable("Estados_Envio");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.EstadoEnvioID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(40);
        });

        modelBuilder.Entity<Estados_Pago>(entity =>
        {
            entity.HasKey(e => e.EstadoPagoID).HasName("PRIMARY");

            entity.ToTable("Estados_Pago");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.EstadoPagoID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Estados_Propiedad>(entity =>
        {
            entity.HasKey(e => e.EstadoPropiedadID).HasName("PRIMARY");

            entity.ToTable("Estados_Propiedad");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.EstadoPropiedadID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Estados_Seguro>(entity =>
        {
            entity.HasKey(e => e.EstadoSeguroID).HasName("PRIMARY");

            entity.ToTable("Estados_Seguro");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.EstadoSeguroID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Estados_Usuario>(entity =>
        {
            entity.HasKey(e => e.EstadoUsuarioID).HasName("PRIMARY");

            entity.ToTable("Estados_Usuario");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.EstadoUsuarioID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Fotos_Propiedade>(entity =>
        {
            entity.HasKey(e => e.FotoID).HasName("PRIMARY");

            entity.HasIndex(e => e.PropiedadID, "fk_fotos_prop");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Es_Principal).HasDefaultValueSql("'0'");
            entity.Property(e => e.Fecha_Subida)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Foto_URL).HasMaxLength(500);
            entity.Property(e => e.Orden_Display).HasDefaultValueSql("'1'");

            entity.HasOne(d => d.Propiedad).WithMany(p => p.Fotos_Propiedades)
                .HasForeignKey(d => d.PropiedadID)
                .HasConstraintName("fk_fotos_prop");
        });

        modelBuilder.Entity<Interesado>(entity =>
        {
            entity.HasKey(e => e.InteresadoID).HasName("PRIMARY");

            entity.HasIndex(e => e.PersonaID, "fk_interesados_persona");

            entity.HasIndex(e => e.PropiedadID, "fk_interesados_propiedad");

            entity.HasIndex(e => e.TipoInteresID, "fk_interesados_tipointeres");

            entity.HasIndex(e => e.UsuarioID, "fk_interesados_usuario");

            entity.Property(e => e.Estado).HasDefaultValueSql("'1'");
            entity.Property(e => e.Fecha_Registro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Presupuesto_Maximo).HasPrecision(15, 2);

            entity.HasOne(d => d.Persona).WithMany(p => p.Interesados)
                .HasForeignKey(d => d.PersonaID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_interesados_persona");

            entity.HasOne(d => d.Propiedad).WithMany(p => p.Interesados)
                .HasForeignKey(d => d.PropiedadID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_interesados_propiedad");

            entity.HasOne(d => d.TipoInteres).WithMany(p => p.Interesados)
                .HasForeignKey(d => d.TipoInteresID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_interesados_tipointeres");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Interesados)
                .HasForeignKey(d => d.UsuarioID)
                .HasConstraintName("fk_interesados_usuario");
        });

        modelBuilder.Entity<Log_Actividade>(entity =>
        {
            entity.HasKey(e => e.LogID).HasName("PRIMARY");

            entity.HasIndex(e => e.UsuarioID, "fk_log_usuario");

            entity.Property(e => e.Accion).HasMaxLength(100);
            entity.Property(e => e.Fecha_Actividad)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.IP_Address).HasMaxLength(45);
            entity.Property(e => e.Tabla_Afectada).HasMaxLength(50);
            entity.Property(e => e.User_Agent).HasColumnType("text");
            entity.Property(e => e.Valores_Anteriores).HasColumnType("json");
            entity.Property(e => e.Valores_Nuevos).HasColumnType("json");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Log_Actividades)
                .HasForeignKey(d => d.UsuarioID)
                .HasConstraintName("fk_log_usuario");
        });

        modelBuilder.Entity<Metodos_Pago>(entity =>
        {
            entity.HasKey(e => e.MetodoPagoID).HasName("PRIMARY");

            entity.ToTable("Metodos_Pago");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.MetodoPagoID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Moneda>(entity =>
        {
            entity.HasKey(e => e.MonedaID).HasName("PRIMARY");

            entity.HasIndex(e => e.Codigo, "Codigo").IsUnique();

            entity.Property(e => e.MonedaID).ValueGeneratedNever();
            entity.Property(e => e.Codigo).HasMaxLength(3);
            entity.Property(e => e.Decimales).HasDefaultValueSql("'2'");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Simbolo).HasMaxLength(5);
        });

        modelBuilder.Entity<Notificacione>(entity =>
        {
            entity.HasKey(e => e.NotificacionID).HasName("PRIMARY");

            entity.HasIndex(e => e.CanalID, "fk_notif_canal");

            entity.HasIndex(e => e.Destinatario_TipoID, "fk_notif_desttipo");

            entity.HasIndex(e => e.EstadoEnvioID, "fk_notif_estado");

            entity.HasIndex(e => e.TipoNotifID, "fk_notif_tipo");

            entity.HasIndex(e => e.UsuarioID, "fk_notif_usuario");

            entity.Property(e => e.Error_Mensaje).HasColumnType("text");
            entity.Property(e => e.EstadoEnvioID).HasDefaultValueSql("'1'");
            entity.Property(e => e.Fecha_Creacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Fecha_Envio).HasColumnType("datetime");
            entity.Property(e => e.Fecha_Programada).HasColumnType("datetime");
            entity.Property(e => e.Intentos_Envio).HasDefaultValueSql("'0'");
            entity.Property(e => e.Mensaje).HasColumnType("text");
            entity.Property(e => e.Titulo).HasMaxLength(255);

            entity.HasOne(d => d.Canal).WithMany(p => p.Notificaciones)
                .HasForeignKey(d => d.CanalID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_notif_canal");

            entity.HasOne(d => d.Destinatario_Tipo).WithMany(p => p.Notificaciones)
                .HasForeignKey(d => d.Destinatario_TipoID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_notif_desttipo");

            entity.HasOne(d => d.EstadoEnvio).WithMany(p => p.Notificaciones)
                .HasForeignKey(d => d.EstadoEnvioID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_notif_estado");

            entity.HasOne(d => d.TipoNotif).WithMany(p => p.Notificaciones)
                .HasForeignKey(d => d.TipoNotifID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_notif_tipo");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Notificaciones)
                .HasForeignKey(d => d.UsuarioID)
                .HasConstraintName("fk_notif_usuario");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.PagoID).HasName("PRIMARY");

            entity.HasIndex(e => e.Numero_Recibo, "Numero_Recibo").IsUnique();

            entity.HasIndex(e => e.ContratoID, "fk_pagos_contrato");

            entity.HasIndex(e => e.EstadoPagoID, "fk_pagos_estadopago");

            entity.HasIndex(e => e.MetodoPagoID, "fk_pagos_metodo");

            entity.HasIndex(e => e.MonedaID, "fk_pagos_moneda");

            entity.HasIndex(e => e.TipoPagoID, "fk_pagos_tipopago");

            entity.HasIndex(e => e.UsuarioID, "fk_pagos_usuario");

            entity.Property(e => e.Archivo_Comprobante).HasMaxLength(500);
            entity.Property(e => e.EstadoPagoID).HasDefaultValueSql("'1'");
            entity.Property(e => e.Fecha_Creacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.MonedaID).HasDefaultValueSql("'1'");
            entity.Property(e => e.Monto).HasPrecision(15, 2);
            entity.Property(e => e.Monto_Pagado).HasPrecision(15, 2);
            entity.Property(e => e.Numero_Recibo).HasMaxLength(30);
            entity.Property(e => e.Observaciones).HasColumnType("text");

            entity.HasOne(d => d.Contrato).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.ContratoID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pagos_contrato");

            entity.HasOne(d => d.EstadoPago).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.EstadoPagoID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pagos_estadopago");

            entity.HasOne(d => d.MetodoPago).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.MetodoPagoID)
                .HasConstraintName("fk_pagos_metodo");

            entity.HasOne(d => d.Moneda).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.MonedaID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pagos_moneda");

            entity.HasOne(d => d.TipoPago).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.TipoPagoID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pagos_tipopago");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.UsuarioID)
                .HasConstraintName("fk_pagos_usuario");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.PersonaID).HasName("PRIMARY");

            entity.HasIndex(e => e.Documento, "Documento").IsUnique();

            entity.HasIndex(e => e.CiudadID, "fk_personas_ciudad");

            entity.HasIndex(e => e.EstadoCivilID, "fk_personas_estadocivil");

            entity.HasIndex(e => e.TipoDocumentoID, "fk_personas_tipodoc");

            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Direccion).HasColumnType("text");
            entity.Property(e => e.Documento).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Estado).HasDefaultValueSql("'1'");
            entity.Property(e => e.Fecha_Creacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Profesion).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);
            entity.Property(e => e.TipoDocumentoID).HasDefaultValueSql("'1'");

            entity.HasOne(d => d.Ciudad).WithMany(p => p.Personas)
                .HasForeignKey(d => d.CiudadID)
                .HasConstraintName("fk_personas_ciudad");

            entity.HasOne(d => d.EstadoCivil).WithMany(p => p.Personas)
                .HasForeignKey(d => d.EstadoCivilID)
                .HasConstraintName("fk_personas_estadocivil");

            entity.HasOne(d => d.TipoDocumento).WithMany(p => p.Personas)
                .HasForeignKey(d => d.TipoDocumentoID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_personas_tipodoc");
        });

        modelBuilder.Entity<Productore>(entity =>
        {
            entity.HasKey(e => e.ProductorID).HasName("PRIMARY");

            entity.HasIndex(e => e.Codigo_Productor, "Codigo_Productor").IsUnique();

            entity.HasIndex(e => e.UsuarioID, "fk_productores_usuario");

            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Codigo_Productor).HasMaxLength(20);
            entity.Property(e => e.Comision_Default)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("'3.00'");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Estado).HasDefaultValueSql("'1'");
            entity.Property(e => e.Fecha_Alta)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);

            entity.HasOne(d => d.Usuario).WithMany(p => p.Productores)
                .HasForeignKey(d => d.UsuarioID)
                .HasConstraintName("fk_productores_usuario");
        });

        modelBuilder.Entity<Propiedade>(entity =>
        {
            entity.HasKey(e => e.PropiedadID).HasName("PRIMARY");

            entity.HasIndex(e => e.Codigo_Propiedad, "Codigo_Propiedad").IsUnique();

            entity.HasIndex(e => e.BarrioID, "fk_propiedades_barrio");

            entity.HasIndex(e => e.EstadoPropiedadID, "fk_propiedades_estadoprop");

            entity.HasIndex(e => e.MonedaID, "fk_propiedades_moneda");

            entity.HasIndex(e => e.PropietarioID, "fk_propiedades_propietario");

            entity.HasIndex(e => e.TipoPropiedadID, "fk_propiedades_tipoprop");

            entity.HasIndex(e => e.UsuarioID, "fk_propiedades_usuario");

            entity.Property(e => e.Amenities).HasColumnType("text");
            entity.Property(e => e.Anio_Construccion).HasColumnType("year");
            entity.Property(e => e.Codigo_Propiedad).HasMaxLength(20);
            entity.Property(e => e.Coordenadas_GPS).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.EstadoPropiedadID).HasDefaultValueSql("'1'");
            entity.Property(e => e.Expensas)
                .HasPrecision(10, 2)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Fecha_Actualizacion)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Fecha_Alta)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Metros_Cuadrados).HasPrecision(8, 2);
            entity.Property(e => e.MonedaID).HasDefaultValueSql("'1'");
            entity.Property(e => e.Valor_Alquiler).HasPrecision(15, 2);
            entity.Property(e => e.Valor_Venta).HasPrecision(15, 2);

            entity.HasOne(d => d.Barrio).WithMany(p => p.Propiedades)
                .HasForeignKey(d => d.BarrioID)
                .HasConstraintName("fk_propiedades_barrio");

            entity.HasOne(d => d.EstadoPropiedad).WithMany(p => p.Propiedades)
                .HasForeignKey(d => d.EstadoPropiedadID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_propiedades_estadoprop");

            entity.HasOne(d => d.Moneda).WithMany(p => p.Propiedades)
                .HasForeignKey(d => d.MonedaID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_propiedades_moneda");

            entity.HasOne(d => d.Propietario).WithMany(p => p.Propiedades)
                .HasForeignKey(d => d.PropietarioID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_propiedades_propietario");

            entity.HasOne(d => d.TipoPropiedad).WithMany(p => p.Propiedades)
                .HasForeignKey(d => d.TipoPropiedadID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_propiedades_tipoprop");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Propiedades)
                .HasForeignKey(d => d.UsuarioID)
                .HasConstraintName("fk_propiedades_usuario");
        });

        modelBuilder.Entity<Roles_Cliente>(entity =>
        {
            entity.HasKey(e => e.RolClienteID).HasName("PRIMARY");

            entity.ToTable("Roles_Cliente");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.RolClienteID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(30);
        });

        modelBuilder.Entity<Roles_Usuario>(entity =>
        {
            entity.HasKey(e => e.RolUsuarioID).HasName("PRIMARY");

            entity.ToTable("Roles_Usuario");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.RolUsuarioID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Seguro>(entity =>
        {
            entity.HasKey(e => e.SeguroID).HasName("PRIMARY");

            entity.HasIndex(e => e.Numero_Poliza, "Numero_Poliza").IsUnique();

            entity.HasIndex(e => e.EstadoSeguroID, "fk_seguros_estadoseg");

            entity.HasIndex(e => e.MonedaID, "fk_seguros_moneda");

            entity.HasIndex(e => e.ProductorID, "fk_seguros_productor");

            entity.HasIndex(e => e.PropiedadID, "fk_seguros_propiedad");

            entity.HasIndex(e => e.TipoSeguroID, "fk_seguros_tiposeg");

            entity.HasIndex(e => e.UsuarioID, "fk_seguros_usuario");

            entity.Property(e => e.Archivo_Poliza).HasMaxLength(500);
            entity.Property(e => e.Compania_Seguro).HasMaxLength(100);
            entity.Property(e => e.EstadoSeguroID).HasDefaultValueSql("'1'");
            entity.Property(e => e.Fecha_Creacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.MonedaID).HasDefaultValueSql("'1'");
            entity.Property(e => e.Numero_Poliza).HasMaxLength(50);
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Prima_Mensual).HasPrecision(10, 2);

            entity.HasOne(d => d.EstadoSeguro).WithMany(p => p.Seguros)
                .HasForeignKey(d => d.EstadoSeguroID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_seguros_estadoseg");

            entity.HasOne(d => d.Moneda).WithMany(p => p.Seguros)
                .HasForeignKey(d => d.MonedaID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_seguros_moneda");

            entity.HasOne(d => d.Productor).WithMany(p => p.Seguros)
                .HasForeignKey(d => d.ProductorID)
                .HasConstraintName("fk_seguros_productor");

            entity.HasOne(d => d.Propiedad).WithMany(p => p.Seguros)
                .HasForeignKey(d => d.PropiedadID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_seguros_propiedad");

            entity.HasOne(d => d.TipoSeguro).WithMany(p => p.Seguros)
                .HasForeignKey(d => d.TipoSeguroID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_seguros_tiposeg");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Seguros)
                .HasForeignKey(d => d.UsuarioID)
                .HasConstraintName("fk_seguros_usuario");
        });

        modelBuilder.Entity<Sesiones_JWT>(entity =>
        {
            entity.HasKey(e => e.SesionID).HasName("PRIMARY");

            entity.ToTable("Sesiones_JWT");

            entity.HasIndex(e => e.Token_JTI, "Token_JTI").IsUnique();

            entity.HasIndex(e => e.UsuarioID, "fk_sesiones_usuario");

            entity.Property(e => e.Estado).HasDefaultValueSql("'1'");
            entity.Property(e => e.Fecha_Creacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Fecha_Expiracion).HasColumnType("datetime");
            entity.Property(e => e.IP_Address).HasMaxLength(45);
            entity.Property(e => e.User_Agent).HasColumnType("text");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Sesiones_JWTs)
                .HasForeignKey(d => d.UsuarioID)
                .HasConstraintName("fk_sesiones_usuario");
        });

        modelBuilder.Entity<Tipos_Destinatario>(entity =>
        {
            entity.HasKey(e => e.Destinatario_TipoID).HasName("PRIMARY");

            entity.ToTable("Tipos_Destinatario");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.Destinatario_TipoID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(30);
        });

        modelBuilder.Entity<Tipos_Documento>(entity =>
        {
            entity.HasKey(e => e.TipoDocumentoID).HasName("PRIMARY");

            entity.ToTable("Tipos_Documento");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.TipoDocumentoID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(30);
        });

        modelBuilder.Entity<Tipos_Intere>(entity =>
        {
            entity.HasKey(e => e.TipoInteresID).HasName("PRIMARY");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.TipoInteresID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(30);
        });

        modelBuilder.Entity<Tipos_Notificacion>(entity =>
        {
            entity.HasKey(e => e.TipoNotifID).HasName("PRIMARY");

            entity.ToTable("Tipos_Notificacion");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.TipoNotifID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(60);
        });

        modelBuilder.Entity<Tipos_Pago>(entity =>
        {
            entity.HasKey(e => e.TipoPagoID).HasName("PRIMARY");

            entity.ToTable("Tipos_Pago");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.TipoPagoID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Tipos_Propiedad>(entity =>
        {
            entity.HasKey(e => e.TipoPropiedadID).HasName("PRIMARY");

            entity.ToTable("Tipos_Propiedad");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.TipoPropiedadID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Tipos_Seguro>(entity =>
        {
            entity.HasKey(e => e.TipoSeguroID).HasName("PRIMARY");

            entity.ToTable("Tipos_Seguro");

            entity.HasIndex(e => e.Nombre, "Nombre").IsUnique();

            entity.Property(e => e.TipoSeguroID).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioID).HasName("PRIMARY");

            entity.HasIndex(e => e.Email, "Email").IsUnique();

            entity.HasIndex(e => e.EstadoUsuarioID, "idx_usuarios_estado");

            entity.HasIndex(e => e.RolUsuarioID, "idx_usuarios_rol");

            entity.HasIndex(e => e.Username, "idx_usuarios_username").IsUnique();

            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Bloqueado_Hasta).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.EstadoUsuarioID).HasDefaultValueSql("'1'");
            entity.Property(e => e.Fecha_Actualizacion)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Fecha_Creacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Intentos_Login).HasDefaultValueSql("'0'");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Password_Hash).HasMaxLength(255);
            entity.Property(e => e.Reset_Token).HasMaxLength(255);
            entity.Property(e => e.Reset_Token_Expiry).HasColumnType("datetime");
            entity.Property(e => e.RolUsuarioID).HasDefaultValueSql("'2'");
            entity.Property(e => e.Telefono).HasMaxLength(20);
            entity.Property(e => e.Ultimo_Login).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.EstadoUsuario).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.EstadoUsuarioID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuarios_estado");

            entity.HasOne(d => d.RolUsuario).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolUsuarioID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuarios_rol");
        });

        modelBuilder.Entity<V_Contratos_Completo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Contratos_Completos");

            entity.Property(e => e.Barrio).HasMaxLength(100);
            entity.Property(e => e.Ciudad).HasMaxLength(100);
            entity.Property(e => e.Estado_Contrato).HasMaxLength(50);
            entity.Property(e => e.Inquilino).HasMaxLength(201);
            entity.Property(e => e.Monto_Alquiler).HasPrecision(15, 2);
            entity.Property(e => e.Numero_Contrato).HasMaxLength(30);
            entity.Property(e => e.Productor).HasMaxLength(100);
            entity.Property(e => e.Propiedad_Direccion).HasMaxLength(255);
            entity.Property(e => e.Propietario).HasMaxLength(201);
            entity.Property(e => e.Usuario_Creador).HasMaxLength(100);
        });

        modelBuilder.Entity<V_Pagos_Pendiente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Pagos_Pendientes");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Estado_Temporal)
                .HasMaxLength(10)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Inquilino).HasMaxLength(201);
            entity.Property(e => e.Monto).HasPrecision(15, 2);
            entity.Property(e => e.Numero_Contrato).HasMaxLength(30);
            entity.Property(e => e.Numero_Recibo).HasMaxLength(30);
            entity.Property(e => e.Propiedad).HasMaxLength(255);
            entity.Property(e => e.Telefono).HasMaxLength(20);
            entity.Property(e => e.Tipo_Pago).HasMaxLength(50);
        });

        modelBuilder.Entity<Variables_Impositiva>(entity =>
        {
            entity.HasKey(e => e.VariableID).HasName("PRIMARY");

            entity.HasIndex(e => e.UsuarioID, "fk_variables_usuario");

            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Estado).HasDefaultValueSql("'1'");
            entity.Property(e => e.Fecha_Creacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Monto_Fijo).HasPrecision(15, 2);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Porcentaje).HasPrecision(5, 4);
            entity.Property(e => e.Tipo_Aplicacion).HasMaxLength(20);

            entity.HasOne(d => d.Usuario).WithMany(p => p.Variables_Impositivas)
                .HasForeignKey(d => d.UsuarioID)
                .HasConstraintName("fk_variables_usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
