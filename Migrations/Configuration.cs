using System.Data.Entity.Migrations;
using Type_D.Models;

internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
{
    public Configuration()
    {
        AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(ApplicationDbContext context)
    {
        // Начальные данные услуг
        context.Services.AddOrUpdate(
            s => s.Name,
            new Service { Name = "Уборка сада", Duration = 2, Description = "Полная уборка вашего сада.", Price = 1500 },
            new Service { Name = "Починка фонтана", Duration = 4, Description = "Ремонт и обслуживание фонтана.", Price = 3000 },
            new Service { Name = "Постройка дома", Duration = 30, Description = "Строительство дома под ключ.", Price = 1500000 },
            new Service { Name = "Уход за газоном", Duration = 1, Description = "Стрижка и уход за газоном.", Price = 800 },
            new Service { Name = "Обрезка деревьев", Duration = 3, Description = "Профессиональная обрезка деревьев.", Price = 2500 },
            new Service { Name = "Установка забора", Duration = 5, Description = "Монтаж металлического забора.", Price = 50000 },
            new Service { Name = "Покраска дома", Duration = 7, Description = "Покраска фасада и внутренних стен.", Price = 70000 },
            new Service { Name = "Чистка бассейна", Duration = 2, Description = "Профессиональная чистка бассейна.", Price = 3500 },
            new Service { Name = "Укладка плитки", Duration = 6, Description = "Укладка плитки на любые поверхности.", Price = 45000 },
            new Service { Name = "Установка освещения", Duration = 3, Description = "Монтаж уличного освещения.", Price = 20000 },
            new Service { Name = "Ремонт крыши", Duration = 10, Description = "Ремонт и замена кровли.", Price = 120000 },
            new Service { Name = "Установка дверей", Duration = 1, Description = "Установка межкомнатных и входных дверей.", Price = 6000 },
            new Service { Name = "Монтаж окон", Duration = 2, Description = "Установка пластиковых окон.", Price = 15000 },
            new Service { Name = "Чистка водостоков", Duration = 1, Description = "Очистка водостоков от грязи и мусора.", Price = 3000 },
            new Service { Name = "Утепление стен", Duration = 5, Description = "Утепление стен снаружи и внутри.", Price = 80000 },
            new Service { Name = "Установка кондиционеров", Duration = 2, Description = "Монтаж и настройка кондиционеров.", Price = 25000 },
            new Service { Name = "Ремонт сантехники", Duration = 3, Description = "Ремонт и установка сантехники.", Price = 15000 },
            new Service { Name = "Прокладка труб", Duration = 4, Description = "Монтаж водопроводных труб.", Price = 40000 },
            new Service { Name = "Прокладка кабеля", Duration = 2, Description = "Прокладка электрических кабелей.", Price = 20000 },
            new Service { Name = "Дизайн интерьера", Duration = 10, Description = "Создание уникального дизайна интерьера.", Price = 100000 }
        );

        // Начальные данные пользователей
        context.UserProfiles.AddOrUpdate(
            u => u.Email,
            new UserProfile { Email = "admin@example.com", Name = "Admin", Password = "admin123" },
            new UserProfile { Email = "user@example.com", Name = "User", Password = "password123" }
        );

        context.SaveChanges();
    }
}
