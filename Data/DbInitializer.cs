using System.Collections.Generic;
using System.Data.Entity;
using Type_D.Models;

namespace Type_D.Data
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var services = new List<Service>
            {
                new Service { Name = "Уборка сада", Duration = 2, Description = "Полная уборка вашего сада.", Price = 1500 },
                new Service { Name = "Починка фонтана", Duration = 4, Description = "Ремонт и обслуживание фонтана.", Price = 3000 },
                // Добавьте еще услуги здесь
            };

            services.ForEach(s => context.Services.Add(s));
            context.SaveChanges();
        }
    }
}
