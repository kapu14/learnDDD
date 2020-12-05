using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DDD.Infrastructure.MSSql
{
    public sealed class AreasMSSql : IAreasRepository
    {
        public IReadOnlyList<AreaEntity> GetData()
        {
            string sql = @"
select AreaId,
        AreaName
from Areas
";
            //return MSSqlHelper.Query<AreaEntity>(sql, CreateEntity); 省略できる
            return MSSqlHelper.Query(sql,
                reader =>
                {
                    return new AreaEntity(Convert.ToInt32(reader["AreaId"]),
                        Convert.ToString(reader["AreaName"]));
                });
               
        }

    }
}
