using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Qinweir.OrderMaterials;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

namespace Qinweir.EntityFrameworkCore
{
    public static class QinweirDbContextModelCreatingExtensions
    {
        public static void ConfigureQinweir(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(QinweirConsts.DbTablePrefix + "YourEntities", QinweirConsts.DbSchema);

            //    //...
            //});

            builder.Entity<CommonMaterial>(b =>
            {
                b.ToTable(QinweirConsts.DbTablePrefix + "CommonMaterials", QinweirConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Id).IsRequired().HasMaxLength(128);
            });
            builder.Entity<BillMaterials>(b =>
            {
                b.ToTable(QinweirConsts.DbTablePrefix + "BillMaterials", QinweirConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Id).IsRequired().HasMaxLength(128);
            });
            ////配置1对多外键关系
            //builder.Entity<BillMaterials>().HasOne(c => c.CommonMaterial).WithMany(c => c.BillMaterials).HasForeignKey(c => c.CommonMaterialId);


        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}