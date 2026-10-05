
using System;
using System.Linq;
using Employees.DataAccessLayer;
using Employees.Model;

// Этот код выполнится сразу при запуске
Console.WriteLine("=== Начало инициализации БД ===");

try
{
    using var db = new AppDbContext();

    // Создаем таблицу, если её нет
    db.Database.EnsureCreated();
    Console.WriteLine("Таблица проверена/создана.");

    if (!db.Employees.Any())
    {
        db.Employees.Add(new Employee
        {
            FirstName = "Иван",
            LastName = "Иванов",
            Position = "Разработчик"
        });
        db.SaveChanges();
        Console.WriteLine("✅ Добавлен тестовый сотрудник!");
    }
    else
    {
        Console.WriteLine("✅ База данных уже содержит данные.");
    }

    Console.WriteLine("=== Конец инициализации ===");
}
catch (Exception ex)
{
    Console.WriteLine($"❌ ОШИБКА: {ex.Message}");
    if (ex.InnerException != null)
    {
        Console.WriteLine($"Внутренняя ошибка: {ex.InnerException.Message}");
    }
}

// Эта строка не даст окну закрыться, пока вы не нажмете Enter
Console.WriteLine("\nНажмите Enter для выхода...");
Console.ReadLine();
