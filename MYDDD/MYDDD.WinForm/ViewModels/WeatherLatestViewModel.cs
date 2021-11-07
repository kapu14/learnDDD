using MYDDD.Domain.Entities;
using MYDDD.Domain.Repositorys;
using MYDDD.Infrastructure.SQL;
using MYDDD.WinForm.ViewModels;
using System;
using System.ComponentModel;

namespace MYDDD.Infrastructure.ViewModels
{
    public class WeatherLatestViewModel : ViewModelBase
    {
        IWeatherRepository _weather;
        IAreasRepository _areas;
        public WeatherLatestViewModel()
            :this(new WeatherSQL(),new AreasSQL())
        {
                
        }

        public WeatherLatestViewModel(IWeatherRepository weather
            ,IAreasRepository areas)
        {
            _weather = weather;
            _areas = areas;
            foreach( var area in _areas.GetData())
            {
                Areas.Add(new AreaEntity(area.AreaId, area.AreaName));
            }
        }
        private object  _selectedAreaId;


        public object  selectedAreaId {
            get { return _selectedAreaId; }
            set
            {
                SetProperty(ref _selectedAreaId, value);
            }
        }
        private string _dataDate = string.Empty;
        public string DataDateText
        {
            get { return _dataDate; }
            set
            {
                SetProperty(ref _dataDate, value);
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


        private string _temperatureText = string.Empty;
        public string TemperatureText
        {
            get { return _temperatureText; }
            set
            {
                SetProperty(ref _temperatureText, value);
            }
        }

        public BindingList<AreaEntity> Areas { get; set; }
            = new BindingList<AreaEntity>();

        public void Search()
        {
           var entity =  _weather.GetLatest(Convert.ToInt32(selectedAreaId));

            if (entity == null)
            {
                DataDateText = string.Empty;
                ConditionText = string.Empty;
                TemperatureText = string.Empty;

            }
            else
            {
                DataDateText = entity.DateDate.ToString();
                ConditionText = entity.Condition.DisplayValue;
                TemperatureText
                    = entity.Temperature.DisplayValueWithUnitSpace;
            }
        }
    }
}
