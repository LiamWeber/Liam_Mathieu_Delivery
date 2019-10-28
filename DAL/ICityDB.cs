﻿using DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface ICityDB
    {
        IConfiguration Configuration { get; }
        List<City> GetAllCities();
        City AddCity(City city);
    }
}
