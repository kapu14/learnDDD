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
        public IReadOnlyList<WeatherEntity> GetData()
        {
            string sql = @"
select A.AreaId,
       isnull(B.AreaName,'') as AreaName,
       A.DataDate,
       A.Condition,
       A.Temperature
from Weather A
left join Areas B
on A.AreaId = B.AreaId
";

            return MSSqlHelper.Query(sql,
                reader =>
                {
                    return new WeatherEntity(
                        Convert.ToInt32(reader["AreaID"]),
                        Convert.ToString(reader["AreaName"]),
                        Convert.ToDateTime(reader["DataDate"]),
                        Convert.ToInt32(reader["Condition"]),
                        Convert.ToSingle(reader["Temperature"]));
                });
        }
    }
}