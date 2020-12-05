using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using System;
using System.Collections.Generic;
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
            return MSSqlHelper.QuerySingle<WeatherEntity>(
                sql,
                new List<SqlParameter>
                {
                    new SqlParameter("@AreaId", areaId)
                }.ToArray() ,
                reader =>
                {
                    return new WeatherEntity(
                        areaId,
                        Convert.ToDateTime(reader["DataDate"]),
                        Convert.ToInt32(reader["Condition"]),
                        Convert.ToInt32(reader["Temperature"])
                        );
                },
                null
                );

        }

    }
}