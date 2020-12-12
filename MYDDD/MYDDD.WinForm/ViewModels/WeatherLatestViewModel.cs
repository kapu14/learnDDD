using MYDDD.Infrastructure.Repositorys;
using MYDDD.WinForm.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYDDD.WinForm.ViewModels
{
    public class WeatherLatestViewModel
    {
        IWeatherRepository _weather;
        public object AreaIdText { get; set; } = string.Empty;
        public object DataDateText { get; set; } = string.Empty;
        public object TemperatureText { get; set; } = string.Empty;
        public object ConditionText { get; set; } = string.Empty;
        public WeatherLatestViewModel(IWeatherRepository weather)
        {
            _weather = weather;
        }

        public void Search()
        {
           var entity =  _weather.GetLatest(Convert.ToInt32(AreaIdText));

            if (entity != null)
            {
                DataDateText = entity.DateDate.ToString();
                ConditionText = entity.Condition.ToString();
                TemperatureText
                    = CommonFunc.RoundString(entity.Temperature,
                    CommonConst.TemperatureDecimalPoint)
                           + CommonConst.TemperatureUnitName;
            }


        }
    }
}
