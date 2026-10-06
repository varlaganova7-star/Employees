using System;
using System.Windows.Forms;
using Employees.DataAccessLayer;

namespace Employees.View
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Создаём базу и таблицу, если их ещё нет (через EF)
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }

            // Запускаем главное окно
            Application.Run(new Form1());
        }
    }
}