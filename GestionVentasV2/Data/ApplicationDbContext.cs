using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionVentasV2.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestionVentasV2.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

            
        }


        public DbSet<estados> estados { get; set; }
        public DbSet<rol> rol { get; set; }

        public DbSet<establecimiento> establecimiento { get; set; }

        public DbSet<GestionVentasV2.Models.producto> producto { get; set; }

        public DbSet<GestionVentasV2.Models.usuario> usuario { get; set; }

        public DbSet<GestionVentasV2.Models.rolUsuario> rolUsuario { get; set; }

        public DbSet<GestionVentasV2.Models.tipoUsuario> tipoUsuario { get; set; }

        public DbSet<GestionVentasV2.Models.compra> compra { get; set; }

        public DbSet<GestionVentasV2.Models.detalleCompra> detalleCompra { get; set; }

        public DbSet<GestionVentasV2.Models.stock> stock { get; set; }

        public DbSet<cliente> cliente { get; set; }

        public DbSet<GestionVentasV2.Models.oferta> oferta { get; set; }

        public DbSet<GestionVentasV2.Models.pedido> pedido { get; set; }

        public DbSet<GestionVentasV2.Models.detallePedido> detallePedido { get; set; }

        public DbSet<GestionVentasV2.Models.tipoEstablecimiento> tipoEstablecimiento { get; set; }

        public DbSet<GestionVentasV2.Models.venta> venta { get; set; }

        public DbSet<GestionVentasV2.Models.detalleVenta> detalleVenta { get; set; }

        //public DbSet<User> User { get; set; }
    }
}
