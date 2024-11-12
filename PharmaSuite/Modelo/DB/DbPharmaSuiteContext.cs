using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PharmaSuite.Modelo.DB;

public partial class DbPharmaSuiteContext : DbContext
{
    public DbPharmaSuiteContext()
    {
    }

    public DbPharmaSuiteContext(DbContextOptions<DbPharmaSuiteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<FormaPago> FormaPagos { get; set; }

    public virtual DbSet<Medida> Medida { get; set; }

    public virtual DbSet<Perfil> Perfils { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<PresentacionProd> PresentacionProds { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VentaDetalle> VentaDetalles { get; set; }

    public virtual DbSet<Venta> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-RLTVHDQ\\SQLEXPRESS;Initial Catalog=db_PharmaSuite;Integrated Security=True;TrustServerCertificate=True");
    // => optionsBuilder.UseSqlServer("Data Source=CARLOS\\SQLEXPRESS01;Initial Catalog=db_PharmaSuite;Integrated Security=True;TrustServerCertificate=True");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK_categoria_id");

            entity.ToTable("categoria");

            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.Activo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("si")
                .HasColumnName("activo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<FormaPago>(entity =>
        {
            entity.HasKey(e => e.IdFormaPago);

            entity.ToTable("forma_pago");

            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.Forma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("forma");
        });

        modelBuilder.Entity<Medida>(entity =>
        {
            entity.HasKey(e => e.IdMedida).HasName("PK_medida_id");

            entity.ToTable("medida");

            entity.Property(e => e.IdMedida).HasColumnName("id_medida");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unidad_medida");
        });

        modelBuilder.Entity<Perfil>(entity =>
        {
            entity.HasKey(e => e.IdPerfil).HasName("PK_perfil_id");

            entity.ToTable("perfil");

            entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("PK_persona_id");

            entity.ToTable("persona");

            entity.HasIndex(e => e.Dni, "UQ_persona_dni").IsUnique();

            entity.HasIndex(e => e.Email, "UQ_persona_email").IsUnique();

            entity.HasIndex(e => e.Telefono, "UQ_persona_telefono").IsUnique();

            entity.Property(e => e.IdPersona).HasColumnName("id_persona");
            entity.Property(e => e.Activo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("si")
                .HasColumnName("activo");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FechaNac).HasColumnName("fechaNac");
            entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Sexo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sexo");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdPerfil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_persona_id_perfil");
        });

        modelBuilder.Entity<PresentacionProd>(entity =>
        {
            entity.HasKey(e => new { e.IdProd, e.IdMedida }).HasName("PK_presentacion");

            entity.ToTable("presentacion_prod");

            entity.Property(e => e.IdProd).HasColumnName("id_prod");
            entity.Property(e => e.IdMedida).HasColumnName("id_medida");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.FormaPresentacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("forma_presentacion");

            entity.HasOne(d => d.IdMedidaNavigation).WithMany(p => p.PresentacionProds)
                .HasForeignKey(d => d.IdMedida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_presentacion_medida");

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.PresentacionProds)
                .HasForeignKey(d => d.IdProd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_presentacion_producto");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.CodBarra).HasName("PK_codbarra");

            entity.ToTable("producto");

            entity.Property(e => e.CodBarra)
                .ValueGeneratedNever()
                .HasColumnName("codBarra");
            entity.Property(e => e.Activo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("si")
                .HasColumnName("activo");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.NombreProd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_prod");
            entity.Property(e => e.PrecioLista).HasColumnName("precio_lista");
            entity.Property(e => e.PrecioVenta).HasColumnName("precio_venta");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.StockMin).HasColumnName("stock_min");
            entity.Property(e => e.VentaLibre)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("si")
                .HasColumnName("venta_libre");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_producto_categoria");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK_usuario_id");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.Nombre, "UQ_persona_usuario").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdPersona).HasColumnName("id_persona");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pass");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_usuario_id_persona");
        });

        modelBuilder.Entity<VentaDetalle>(entity =>
        {
            entity.HasKey(e => e.IdVentaDetalle);

            entity.ToTable("venta_detalle");

            entity.Property(e => e.IdVentaDetalle).HasColumnName("id_venta_detalle");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.CodBarra).HasColumnName("codBarra");
            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.Subtotal).HasColumnName("subtotal");

            entity.HasOne(d => d.CodBarraNavigation).WithMany(p => p.VentaDetalles)
                .HasForeignKey(d => d.CodBarra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_detalle_producto");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.VentaDetalles)
                .HasForeignKey(d => d.IdVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_detalle_venta");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.IdVenta);

            entity.ToTable("venta");

            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.Cliente).HasColumnName("cliente");
            entity.Property(e => e.FechaVta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_vta");
            entity.Property(e => e.IdFormapago).HasColumnName("id_formapago");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Total).HasColumnName("total");

            entity.HasOne(d => d.ClienteNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.Cliente)
                .HasConstraintName("FK_venta_cliente");

            entity.HasOne(d => d.IdFormapagoNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdFormapago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_formapago");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
