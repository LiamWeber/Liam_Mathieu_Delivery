using System.Collections.Generic;
using DAL;
using DTO;
using Microsoft.Extensions.Configuration;

namespace BLL
{
    public class CityManager
    {
        public ICityDB CityDB { get; }

        public CityManager(IConfiguration configuration)
        {
            CityDB = new CityDB(configuration);
        }
        public List<City> GetAllCities()
        {
            return CityDB.GetAllCities();
        }
        public City AddCity(City city)
        {
            return CityDB.AddCity(city);
        }
    }
}
