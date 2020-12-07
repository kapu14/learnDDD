using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace DDDTest.Tests
{
    [TestClass]
    public class WeatherListViewModelTest
    {
        public object Weathers { get; private set; }

        [TestMethod]
        public void 天気一覧画面シナリオ()
        {
            var weatherMock = new Mock<IWeatherRepository>();

            var entities = new List<WeatherEntity>();
            entities.Add(
               new WeatherEntity(
                     1,
                     "東京",
                     Convert.ToDateTime("2020/11/22 10:11:22"),
                     2,
                     12.3F)
                    );

            entities.Add(
            new WeatherEntity(
                      2,
                      "神戸",
                      Convert.ToDateTime("2020/11/30 9:01:01"),
                      1,
                      22.392F)
                    );

            weatherMock.Setup(x => x.GetData()).Returns(entities);

            var viewModel = 
                new WeatherListViewModel(weatherMock.Object);
            viewModel.Weathers.Count.Is(2);
            viewModel.Weathers[0].AreaId.Is("0001");
            viewModel.Weathers[0].AreaName.Is("東京");
            viewModel.Weathers[0].DataDate.Is("2020/11/22 10:11:22");
            viewModel.Weathers[0].Condition.Is("曇り");
            viewModel.Weathers[0].Temperture.Is("12.30 ℃");


        }
    }
}
