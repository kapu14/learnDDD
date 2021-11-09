using R3DDD.Domain.Entities;
using R3DDD.Domain.Repositories;

namespace R3DDD.Infrastructure.SqlServer
{
    internal sealed class WeatherSqlServer : IWeatherRepository
    {
        public WeatherEntity GetLatest()
        {
            throw new System.NotImplementedException();
        }
    }
}
