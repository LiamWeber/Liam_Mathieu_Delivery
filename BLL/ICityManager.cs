using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public interface ICityManager
    {
        List<City> GetAllCities();
    }
}
