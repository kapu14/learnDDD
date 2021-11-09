using System;
using R3DDD.Domain.Entities;

namespace R3DDD.Domain.Repositories
{
    public interface IWeatherRepository
    {
        WeatherEntity GetLatest();
    }
}
