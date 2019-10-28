using BLL;
using DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cityDbManager = new CityManager(Configuration);


            // Méthode qui montre toutes les cities présentes dans la BD
            Console.WriteLine("--GET ALL CITIES--");
            var cities = cityDbManager.GetAllCities();

            foreach (var city in cities)
            {
                Console.WriteLine(city.ToString());
                Console.WriteLine("Tip top");
            }
            /*
            //Add City
            Console.WriteLine("--NEW CITY--");
            var newCity = cityDbManager.AddCity(new City { Name = "Monthey"});
            Console.WriteLine($"ID : {newCity.IdCity} Name : {newCity.Name}");
            cities = cityDbManager.GetAllCities();
            foreach (var city in cities)
            {
                Console.WriteLine($"ID : {city.IdCity} Name : {city.Name}");
            }
            */
        }

        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
           .Build();

    }
}
