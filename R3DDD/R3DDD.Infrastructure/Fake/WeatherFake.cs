using R3DDD.Domain.Entities;
using R3DDD.Domain.Repositories;
using System;

namespace R3DDD.Infrastructure.Fake
{
    internal sealed class WeatherFake : IWeatherRepository
    {
        public WeatherEntity GetLatest()
        {

            return  new WeatherEntity(3, "神戸", Convert.ToDateTime("2021/09/23 12:34:56"), 2, 12.345F);
        }
    }
}
