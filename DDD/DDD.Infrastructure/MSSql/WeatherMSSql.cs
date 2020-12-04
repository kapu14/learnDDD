using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using System;
using System.Data.SqlClient;

namespace DDD.Infrastructure.MSSql
{
    public class WeatherMSSql : IWeatherRepository
    {
        public WeatherEntity GetLatest(int areaId)
        {
            string sql = @"
select Top 1 DataDate,
        condition,
        Temperature
from Weather
where AreaId = @AreaId
order by DataDate desc
";

            using (var connection = new SqlConnection(MSSqlHelper.ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@AreaId", areaId);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new WeatherEntity(
                            areaId,
                            Convert.ToDateTime(reader["DataDate"]),
                            Convert.ToInt32(reader["Condition"]),
                            Convert.ToInt32(reader["Temperature"])
                            );
                    }
                }
                return null;
            }
        }

    }
}