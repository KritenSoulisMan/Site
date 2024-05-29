namespace Type_D.Migrations
{
    using System.Data.Entity.Migrations;
    using Type_D.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Type_D.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Type_D.Models.ApplicationDbContext context)
        {
            context.Services.AddOrUpdate(
                s => s.Name,
                new Service { Name = "Уборка в саду", Description = "Полная уборка вашего сада", Price = 150 },
                new Service { Name = "Починка фонтана", Description = "Ремонт и обслуживание фонтанов", Price = 200 },
                new Service { Name = "Постройка дома", Description = "Строительство загородных домов", Price = 5000 }
            );
        }
    }
}
