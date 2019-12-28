using DotNetCore.EntityFrameworkCore;
using DotNetCoreArchitecture.Database.Tables;
using DotNetCoreArchitecture.Domain;
using DotNetCoreArchitecture.Domain.FastFood.Catogry;
using DotNetCoreArchitecture.Domain.FastFood.elasticsearch;
using DotNetCoreArchitecture.Domain.FastFood.Foods;
using DotNetCoreArchitecture.Domain.FastFood.HistoryOrders;
using DotNetCoreArchitecture.Domain.FastFood.Items;
using DotNetCoreArchitecture.Domain.FastFood.Orders;
using DotNetCoreArchitecture.Domain.FastFood.OrderStatus;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Database
{
    public sealed class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        /*public Context() { }*/
        public DbSet<CatogriesTable> CatogriesTables { get; set; }

        /* Latest Updated */
        public DbSet<FoodCatogryEntity> FoodCatogryTables { get; set; }

        public DbSet<ElasticLoggly> ElasticLogglyTables { get; set; }


        public DbSet<FoodBrands> FoodBrandsTables { get; set; }

        public DbSet<FoodOrderHistory> FoodOrderHistoryTables { get; set; }

        public DbSet<FoodBrandItems> FoodBrandItemsTables { get; set; }

        public DbSet<ItemTypeCatogry> ItemTypeCatogryTables { get; set; }

        public DbSet<ItemTypeEntity> ItemTypeEntityTables { get; set; }

        public DbSet<FoodBrandOrder> FoodBrandOrderTables { get; set; }

        public DbSet<FoodOrderStatus> FoodOrderStatusTables { get; set; }

        /* Latest Updated */

        public DbSet<ItemsInventoryTable> ItemsInventoryTables { get; set; }

        public DbSet<ItemEntity> ItemEntities { get; set; }

        public DbSet<CatogryEntity> CatogryEntities { get; set; }

        public DbSet<HallEntity> HallEntities { get; set; }


        public DbSet<HallReservationEntity> HallReservationEntityies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CatogriesTable>(entity =>
            {
                entity.Property(e => e.Id).IsRequired();
                entity.Property(e => e.Value).IsRequired();
            });

            builder.Entity<ItemEntity>(entity =>
            {
                entity.Property(e => e.CatogryId).IsRequired();
                entity.Property(e => e.CreateDate).IsRequired();
                entity.Property(e => e.ItemName).IsRequired();
                entity.Property(e => e.MaxNum).IsRequired();
                entity.Property(e => e.MinNum).IsRequired();
                entity.Property(e => e.IsExist).IsRequired();
            });

            builder.Entity<ItemsInventoryTable>(entity =>
            {
                entity.Property(e => e.Id).IsRequired();
                entity.Property(e => e.ItemName).IsRequired();
                entity.Property(e => e.MaxNum).IsRequired();
                entity.Property(e => e.MinNum).IsRequired();
            });
            builder.Entity<CatogryEntity>(entity =>
            {
                entity.Property(e => e.CatogryId).IsRequired();
                entity.Property(e => e.Description).IsRequired();
            });

            builder.Entity<HallEntity>(entity =>
            {
                entity.Property(e => e.HallId).IsRequired();
                entity.Property(e => e.HallName).IsRequired();
                entity.Property(e => e.Description).IsRequired();
            });

            builder.Entity<HallReservationEntity>(entity =>
            {
                entity.Property(e => e.ReservationId).IsRequired();
                entity.Property(e => e.HallId).IsRequired();
                entity.Property(e => e.StartDate).IsRequired();
                entity.Property(e => e.EndDate).IsRequired();
                entity.Property(e => e.Notes).IsRequired();

            });

            /*

            resturant api


             */

            builder.Entity<FoodCatogryEntity>(entity =>
            {
                entity.Property(e => e.CatogryId).IsRequired();
                entity.Property(e => e.Description).IsRequired();
            });

            builder.Entity<ElasticLoggly>(entity =>
            {
                entity.Property(e => e.ClazzName).IsRequired();
                entity.Property(e => e.LogText).IsRequired();
                entity.Property(e => e.LogglyId).IsRequired();
                entity.Property(e => e.MethodName).IsRequired();
                entity.Property(e => e.OrderId).IsRequired();
            });


            builder.Entity<FoodBrands>(entity =>
            {
                entity.Property(e => e.CatogryId).IsRequired();
                entity.Property(e => e.CreatedDate).IsRequired();
                entity.Property(e => e.FoodId).IsRequired();
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.OwnerName).IsRequired();
                entity.Property(e => e.OwnerPlace).IsRequired();
            });



            builder.Entity<FoodOrderHistory>(entity =>
            {
                entity.Property(e => e.CreatedDate).IsRequired();
                entity.Property(e => e.IsExpired).IsRequired();
                entity.Property(e => e.OrderHistoryId).IsRequired();
                entity.Property(e => e.OrderId).IsRequired();
            });



            builder.Entity<FoodBrandItems>(entity =>
            {
                entity.Property(e => e.CreatedDate).IsRequired();
                entity.Property(e => e.ItemId).IsRequired();
                entity.Property(e => e.ItemType).IsRequired();
                entity.Property(e => e.ItemTypeCatogryId).IsRequired();
                entity.Property(e => e.ItemTypeId).IsRequired();
            });



            builder.Entity<ItemTypeCatogry>(entity =>
            {
                entity.Property(e => e.CatogryKey).IsRequired();
                entity.Property(e => e.CatogryDescription).IsRequired();
                entity.Property(e => e.ItemTypeCatogryId).IsRequired();
            });



            builder.Entity<ItemTypeEntity>(entity =>
            {
                entity.Property(e => e.ItemTypeId).IsRequired();
                entity.Property(e => e.ItemKey).IsRequired();
                entity.Property(e => e.CreatedDate).IsRequired();
            });



            builder.Entity<FoodBrandOrder>(entity =>
            {
                entity.Property(e => e.CreatedDate).IsRequired();
                entity.Property(e => e.FoodId).IsRequired();
                /*entity.Property(e => e.FoodOrderStatus).IsRequired();*/
                entity.Property(e => e.OrderId).IsRequired();
                entity.Property(e => e.OrderName).IsRequired();
                entity.Property(e => e.OrderStatusId).IsRequired();
            });

            builder.Entity<FoodBrandOrder>(entity =>
            {
                entity.Property(e => e.CreatedDate).IsRequired();
                entity.Property(e => e.FoodId).IsRequired();
                /*entity.Property(e => e.FoodOrderStatus).IsRequired();*/
                entity.Property(e => e.OrderId).IsRequired();
                entity.Property(e => e.OrderName).IsRequired();
                entity.Property(e => e.OrderStatusId).IsRequired();
            });

            /* end */


            builder.ApplyConfigurationsFromAssembly();
            builder.Seed();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*optionsBuilder.UseSqlServer("Server=NEWSOFT-TR02;Database=HrModule;User Id=sa; Password=opc@2018;");*/
        }
    }
}
