using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CG_P.Models;

namespace Control_Gasto_Publico.Data
{
    public class Control_Gasto_PublicoContext : DbContext
    {
        public Control_Gasto_PublicoContext (DbContextOptions<Control_Gasto_PublicoContext> options)
            : base(options)
        {
        }

        public DbSet<CG_P.Models.Servicio>? Servicio { get; set; }

        public DbSet<CG_P.Models.Edificio>? Edificio { get; set; }

        public DbSet<CG_P.Models.Agregar_servicio>? Agregar_servicio { get; set; }
    }
}
