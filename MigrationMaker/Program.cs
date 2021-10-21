using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace MigrationMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Gleb",20,new Company("UVZ"));
            Country c1 = new Country("Russia");

            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("AppSettings.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            using (var db = new AppContext(optionsBuilder.Options))
            {
                db.People.Add(p1);
        
                db.SaveChanges();
            }
        }
    }
}
