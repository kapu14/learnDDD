﻿using System;
using System.ComponentModel;
using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Infrastructure.MSSql;


namespace DDD.WinForm.ViewModels
{
    public class WeatherLatestViewModel : ViewModelBase

    {
        private IWeatherRepository _weather;
        private IAreasRepository _areas;

        public WeatherLatestViewModel()
            : this(new WeatherMSSql(),new AreasMSSql())
        {
        }

        public WeatherLatestViewModel(IWeatherRepository weather,
            IAreasRepository areas)
        {
            _weather = weather;
            _areas = areas;

            foreach (var area in _areas.GetData())
            {
                Areas.Add(new AreaEntity(area.AreaId, area.AreaName));
            }
        }
        private object _selectedAreaId;
        public object  SelectedAreaId
        {
            get { return _selectedAreaId; }
            set
            {
                SetProperty(ref _selectedAreaId, value);
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

        public BindingList<AreaEntity> Areas { get; set; }
        = new BindingList<AreaEntity>();

        public void Serch()
        {           
            var entity = _weather.GetLatest(Convert.ToInt32(SelectedAreaId));
            if (entity == null)
            {
                DataDateText = string.Empty;
                ConditionText = string.Empty;
                TemperatureText = string.Empty;
            }
            else
            {
                DataDateText = entity.DataDate.ToString();
                ConditionText = entity.Condition.DisplayValue;
                TemperatureText = entity.Temperature.DisplayValueWithUnitSpace;

            }
        }

    }
}
