using System;

namespace R3DDD.Domain.Entities
{
    public sealed class WeatherEntity
    {
        public WeatherEntity(int areaId, string areaName, DateTime datadate, int condition, float temperature)
        {
            AreaId = areaId;
            AreaName = areaName;
            DataDate = datadate;
            Condition = condition;
            Temperature = temperature;

        }

        public int AreaId {get;}
        public string AreaName{ get; }
        public DateTime DataDate { get; }
        public int Condition { get; }
        public float Temperature { get; }
 

    }
}
