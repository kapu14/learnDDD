using MYDDD.Domain.Entities;

namespace MYDDD.Infrastructure.Repositorys
{
    public interface IWeatherRepository
    {
        WeatherEntity GetLatest(int areaId);
    }
}
