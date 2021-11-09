using R3DDD.Domain;
using R3DDD.Domain.Repositories;
using R3DDD.Infrastructure.Fake;
using R3DDD.Infrastructure.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace R3DDD.Infrastructure
{
    public static class Factories
    {
        public static IWeatherRepository CreateWeather()
        {
#if DEBUG
            if(Shared.IsFake)
            {
                return new WeatherFake();
            }
#endif
            return new WeatherSqlServer();
        }
    }
}
