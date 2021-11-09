using R3DDD.Domain.Entities;
using R3DDD.Domain.Repositories;
using R3DDD.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3DDD.WinForm.ViewModels
{
    public sealed class WeatherLatestViewModel : ViewModelBase
    {

        private IWeatherRepository _weatherRepository;
        
        private string _areaIdText = string.Empty;
        private string _areaNameText = string.Empty;
        private string _dataDateText = string.Empty;
        private string _conditionText = string.Empty;
        private string _temperatureText = string.Empty;

        public WeatherLatestViewModel():this(Factories.CreateWeather())
        {

        }

        public WeatherLatestViewModel(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        public string AreaIdText
        {
            get { return _areaIdText; }
            set
            {
                SetProperty(ref _areaIdText, value);
            }
            
        } 
        public string AreaNameText
        {
            get
            {
                return _areaNameText;
            }
            set
            {
                SetProperty(ref _areaNameText, value);
            }
        } 
        public string DataDateText
        {
            get
            {
                return _dataDateText;
            }
            set
            {
                SetProperty(ref _dataDateText, value);
            }
        }

        public string ConditionText
        {
            get
            {
                return _conditionText;
            }
            set
            {
                SetProperty(ref _conditionText, value);
            }
        }
         
        public string TemperatureText
        {
            get
            {
                return _temperatureText;
            }
            set
            {
                SetProperty(ref _temperatureText, value);
            }

        }
        
    

        public void Search()
        {
            var weather = _weatherRepository.GetLatest();
            AreaIdText = weather.AreaId.ToString();
            AreaNameText = weather.AreaName.ToString();
            DataDateText = weather.DataDate.ToString();
            ConditionText = weather.Condition.ToString();
            TemperatureText = RoundString(weather.Temperature, 2) + " ℃";
        }

        public string RoundString(float value,int decimalPoint)
        {
            var temp = Convert.ToSingle(Math.Round(value, decimalPoint));
            return temp.ToString("F" + decimalPoint);

        }
    }
}



