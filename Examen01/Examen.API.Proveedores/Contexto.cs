using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coling.Shared;

namespace Examen.API.Proveedores
{
        public class Contexto : DbContext
        {
            public Contexto(DbContextOptions<Contexto> options) : base(options)
            {

            }
            public virtual DbSet<Proveedor> Proveedores { get; set; }
        }
    }
