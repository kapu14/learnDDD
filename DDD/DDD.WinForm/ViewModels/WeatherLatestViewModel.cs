using System;
using System.ComponentModel;
using DDD.Domain.Repositories;
using DDD.Infrastructure.MSSql;


namespace DDD.WinForm.ViewModels
{
    public class WeatherLatestViewModel : ViewModelBase

    {
        private IWeatherRepository _weather;

        public WeatherLatestViewModel()
            : this(new WeatherMSSql())
        {
        }

        public WeatherLatestViewModel(IWeatherRepository weather)
        {
            _weather = weather;
        }
        private string _areaIdText = string.Empty;
        public string AreaIdText
        {
            get { return _areaIdText; }
            set
            {
                SetProperty(ref _areaIdText, value);
            }
        }
        private string _dataDateText = string.Empty;
        public string DataDateText
        {
            get { return _dataDateText; }
            set
            {
                SetProperty(ref _dataDateText, value);
            }
        }
        private string _conditionText = string.Empty;
        public string ConditionText
        {
            get { return _conditionText; }
            set
            {
                SetProperty(ref _conditionText, value);
            }
        }
        private string _temperature = string.Empty;
        public string TemperatureText
        {
            get
            {
                return _temperature;
            }
            set
            {
                SetProperty(ref _temperature, value);
            }
        }

        public void Serch()
        {           
            var entity = _weather.GetLatest(Convert.ToInt32(AreaIdText));
            if (entity != null)
            {
                DataDateText = entity.DataDate.ToString();
                ConditionText = entity.Condition.DisplayValue;
                TemperatureText = entity.Temperature.DisplayValueWithUnitSpace;

            }
        }

    }
}
