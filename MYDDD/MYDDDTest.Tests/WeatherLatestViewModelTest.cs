using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MYDDD.Domain.Entities;
using MYDDD.Infrastructure.Repositorys;
using MYDDD.WinForm.ViewModels;

namespace MYDDDTest.Tests
{
    [TestClass]
    public class WeatherLatestViewModelTest
    {

        [TestMethod]
        public void 表示シナリオ()
        {
            var weatherMock = new Mock<IWeatherRepository>();


            var viewModel = new WeatherLatestViewModel(weatherMock.Object);
            viewModel.AreaIdText.Is ("");
            viewModel.DataDateText.Is ("");
            viewModel.ConditionText.Is("");
            viewModel.TemperatureText.Is ("");

            viewModel.AreaIdText = "1";
            weatherMock.Setup(x => x.GetLatest(1))
                .Returns(new WeatherEntity(
                1, Convert.ToDateTime("2020/01/01 12:34:56"), 2,12.3F));

                        viewModel.Search();
            viewModel.AreaIdText.Is("1");
            viewModel.DataDateText.Is("2020/01/01 12:34:56"); ;

            viewModel.ConditionText.Is("2");
            viewModel.TemperatureText.Is("12.30℃");


        }
    }
}
