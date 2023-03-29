// using BSIStore.Data;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Design;

// public class BsiStoreContextFactory : IDesignTimeDbContextFactory<BsiStoreContext>
// {
//         public BsiStoreContext CreateDbContext(string[] args)
//         {
//             var optionsBuilder = new DbContextOptionsBuilder<BsiStoreContext>();
//             optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EcommerceDb;Trusted_Connection=True;MultipleActiveResultSets=true");

//             return new BsiStoreContext(optionsBuilder.Options);
//         }
// }