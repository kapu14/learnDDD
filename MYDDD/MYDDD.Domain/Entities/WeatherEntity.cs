using System;


namespace MYDDD.Domain.Entities
{
    public sealed class WeatherEntity
    {
        //完全コンストラクターパターン
        public WeatherEntity(int areaId,
                             DateTime dataDate,
                             int condition,
                             float temperature)
        {
            AreaId = areaId;
            DateDate = dataDate;
            Condition = condition;
            Temperature = temperature;

        }

        public int AreaId { get; }
        public DateTime DateDate { get; }
        public int Condition { get; }
        public float Temperature { get; }
    }
}
