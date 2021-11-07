using MYDDD.Domain.ValueObjects;
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
            :this(areaId,string.Empty, dataDate, condition, temperature)
        {
        }
        public WeatherEntity(int areaId,
                             string areaName,   
                             DateTime dataDate,
                             int condition,
                             float temperature)
        {
            AreaId = new AreaId(areaId);
            AreaName = areaName;
            DateDate = dataDate;
            Condition = new Condition(condition);
            Temperature = new Temperature(temperature);

        }
        public AreaId AreaId { get; }
        public string AreaName { get; }
        public DateTime DateDate { get; }
        public Condition Condition { get; }
        public Temperature Temperature { get; }
    }
}
