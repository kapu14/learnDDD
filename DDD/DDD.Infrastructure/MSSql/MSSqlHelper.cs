using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DDD.Infrastructure.MSSql
{
    internal class MSSqlHelper
    {
        internal const string ConnectionString = @"server=(local);Initial Catalog = DDD;Integrated Security=false;
                                                      User ID=sa;Password=";

        internal static IReadOnlyList<T> Query<T>(
            string sql,
            Func<SqlDataReader, T> createEntity)
        {
            return Query<T>(sql, null, createEntity);
        }
        internal static IReadOnlyList<T> Query<T>(
            string sql,
            SqlParameter[] parameters,
            Func<SqlDataReader,T> createEntity)
        {
            var result = new List<T>();
            using (var connection = new SqlConnection(MSSqlHelper.ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(createEntity(reader));

                    }
                }
                return result;

            }
        }

        internal static T QuerySingle<T>(
            string sql,
            Func<SqlDataReader, T> createEntity,
            T nullEntity
            )
        {
            return QuerySingle<T>(sql, null, createEntity, nullEntity);
        }
        internal static T QuerySingle<T>(
            string sql,
            SqlParameter[] parameters,
            Func<SqlDataReader, T> createEntity,
            T nullEntity
            )
        {
            using (var connection = new SqlConnection(MSSqlHelper.ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return createEntity(reader);

                    }
                }
                return nullEntity;

            }
        }
    }
}
