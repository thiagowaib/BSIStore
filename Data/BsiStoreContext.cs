using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BSIStore.Models;

namespace BSIStore.Data
{
    public class BsiStoreContext : DbContext
    {
        public BsiStoreContext (DbContextOptions<BsiStoreContext> options) : base(options)
        {
        }

        public DbSet<BSIStore.Models.Produto> Produto { get; set; }

        public DbSet<BSIStore.Models.Funcionario> Funcionario { get; set; }
    }
}
