using System;
using System.Data;
using System.Data.SqlClient;

namespace MYDDD.WinForm.Data
{
    public class WeatherSQL
    {
        private static readonly string ConnectionString = @"server=(local);Initial Catalog = DDD;Integrated Security=false;
                                                      User ID=sa;Password=";
        public static DataTable GetLatest(int areaId)
        {
            string sql = @"
Select Top 1 DataDate,
             Condition,
             Temperature
from Weather
where AreaId = @AreaId
order by DataDate desc
";

            DataTable dt = new DataTable();
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@AreaId", areaId);
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                }

            }
            return dt;
 
        }
    }
}
