# ������ ������

��� ������ ASP.NET MVC ��� �������������� ��������� ������ �����. � ������� ���� ���������� ��� ���������� �������� ������������, ��������� � ������������ �����, � ����� ����������� ������ ��������� ����� �� ������� ��������.

## ��������� �������

������ ������� �� ��������� �������� ������:

- **Controllers**: ��������� ������� ��������� ��������.
  - `HomeController`: ������� �������� � �������� "� ���".
  - `ServicesController`: ���������� �������� � ��������������.
  - `ProfileController`: ���������� �������� ������������.

- **Models**: ���������� ������, ������������ � ����������.
  - `Service`: ������ ������.
  - `Booking`: ������ ������������ ������.
  - `UserProfile`: ������ ������� ������������.

- **Views**: ���������� ������ ������������.
  - `Home/Index.cshtml`: ������� ��������.
  - `Services/Index.cshtml`: ������ �����.
  - `Services/Details.cshtml`: ������ ������.
  - `Services/Book.cshtml`: ������������ ������.
  - `Profile/Index.cshtml`: �������� ������� ������������.
  - `Profile/Edit.cshtml`: �������������� ������� ������������.
  - `Shared/_Layout.cshtml`: ������� ������ ��� ���� �������.

## ��������� ���� ������

������ ���������� Entity Framework Code First ��� ���������� ����� ������. ������������ ��������� ���� ������ (LocalDB), ������� ����� ������� � ��������� ��� ������ ������� �������.

### ��������� ������ �����������

� ����� `Web.config` ��������� ������ ����������� � ���� ������:

```xml
<connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=YourDatabaseName;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>
