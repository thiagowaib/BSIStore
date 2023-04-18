using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BSIStore.Models;

namespace BSIStore.Data
{
    public class BSIStoreContext : DbContext
    {
        public BSIStoreContext (DbContextOptions<BSIStoreContext> options)
            : base(options)
        {
        }

        public DbSet<BSIStore.Models.Produto> Produto { get; set; }

        public DbSet<BSIStore.Models.Cliente> Cliente { get; set; }

        public DbSet<BSIStore.Models.Categoria> Categoria { get; set; }
    }
}
