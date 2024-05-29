# Дачные услуги

Это проект ASP.NET MVC для предоставления различных дачных услуг. В проекте есть функционал для управления профилем пользователя, просмотра и бронирования услуг, а также отображение списка доступных услуг на главной странице.

## Структура проекта

Проект состоит из следующих основных частей:

- **Controllers**: Управляют логикой обработки запросов.
  - `HomeController`: Главная страница и страница "О нас".
  - `ServicesController`: Управление услугами и бронированиями.
  - `ProfileController`: Управление профилем пользователя.

- **Models**: Определяют данные, используемые в приложении.
  - `Service`: Модель услуги.
  - `Booking`: Модель бронирования услуги.
  - `UserProfile`: Модель профиля пользователя.

- **Views**: Отображают данные пользователю.
  - `Home/Index.cshtml`: Главная страница.
  - `Services/Index.cshtml`: Список услуг.
  - `Services/Details.cshtml`: Детали услуги.
  - `Services/Book.cshtml`: Бронирование услуги.
  - `Profile/Index.cshtml`: Просмотр профиля пользователя.
  - `Profile/Edit.cshtml`: Редактирование профиля пользователя.
  - `Shared/_Layout.cshtml`: Главный шаблон для всех страниц.

## Настройка базы данных

Проект использует Entity Framework Code First для управления базой данных. Используется локальная база данных (LocalDB), которая будет создана и настроена при первом запуске проекта.

### Настройка строки подключения

В файле `Web.config` находится строка подключения к базе данных:

```xml
<connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=YourDatabaseName;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>
