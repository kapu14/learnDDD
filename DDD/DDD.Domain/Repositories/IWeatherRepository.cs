using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DDD.Domain.Entities;

namespace DDD.Domain.Repositories
{
    public interface IWeatherRepository
    {
        WeatherEntity GetLatest(int areaId);
    }
}
