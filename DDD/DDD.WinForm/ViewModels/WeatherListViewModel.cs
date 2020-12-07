using System;
using System.Collections.Generic;
using System.ComponentModel;
using DDD.Domain.Repositories;
using DDD.Infrastructure.MSSql;

namespace DDD.WinForm.ViewModels
{
    public class WeatherListViewModel : ViewModelBase
    {
        private IWeatherRepository _weather;

        public WeatherListViewModel()
            : this(new WeatherMSSql())
        {
        }
        public WeatherListViewModel(IWeatherRepository weather)
        {
            _weather = weather;

            foreach(var entiry in _weather.GetData())
            {
                Weathers.Add(new WeatherListViewModelWeather(entiry));

            }
        }

        public BindingList<WeatherListViewModelWeather>
            Weathers
        { get; set; }
                = new BindingList<WeatherListViewModelWeather>();

    }
}
