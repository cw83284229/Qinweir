using Microsoft.EntityFrameworkCore;
using Qinweir.OrderMaterials;
using Qinweir.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users.EntityFrameworkCore;

namespace Qinweir.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See QinweirMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class QinweirDbContext : AbpDbContext<QinweirDbContext>
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<CommonMaterial> CommonMaterials { get; set; }
        public DbSet<BillMaterials> BillMaterials { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside QinweirDbContextModelCreatingExtensions.ConfigureQinweir
         */

        public QinweirDbContext(DbContextOptions<QinweirDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable("AbpUsers"); //Sharing the same table "AbpUsers" with the IdentityUser
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                //Moved customization to a method so we can share it with the QinweirMigrationsDbContext class
                b.ConfigureCustomUserProperties();
            });

            /* Configure your own tables/entities inside the ConfigureQinweir method */

            builder.ConfigureQinweir();
        }
    }
}
