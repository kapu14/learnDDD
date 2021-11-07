using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MYDDD.Domain.Entities;
using MYDDD.Domain.Repositorys;
using MYDDD.Infrastructure.ViewModels;

namespace MYDDDTest.Tests
{
    [TestClass]
    public class WeatherLatestViewModelTest
    {

        [TestMethod]
        public void 表示シナリオ()
        {
            var weatherMock = new Mock<IWeatherRepository>();



            var areasMock = new Mock<IAreasRepository>();
            var areas = new List<AreaEntity>();
            areas.Add(new AreaEntity(1, "東京"));
            areas.Add(new AreaEntity(2, "神戸"));
            areas.Add(new AreaEntity(3, "沖縄"));

            areasMock.Setup(x => x.GetData()).Returns(areas);

            var viewModel = new WeatherLatestViewModel(weatherMock.Object,areasMock.Object);
            viewModel.selectedAreaId.IsNull();
            viewModel.DataDateText.Is ("");
            viewModel.ConditionText.Is("");
            viewModel.TemperatureText.Is ("");
            viewModel.Areas.Count.Is(3);
            viewModel.Areas[0].AreaId.Is(1);
            viewModel.Areas[0].AreaName.Is("東京");
            viewModel.Areas[1].AreaId.Is(2);
            viewModel.Areas[1].AreaName.Is("神戸");


            viewModel.selectedAreaId = 1;
            weatherMock.Setup(x => x.GetLatest(1))
                .Returns(new WeatherEntity(
                1, Convert.ToDateTime("2020/01/01 12:34:56"), 2,12.3F));

            viewModel.Search();
            viewModel.selectedAreaId.Is(1);
            viewModel.DataDateText.Is("2020/01/01 12:34:56"); ;
            viewModel.ConditionText.Is("曇り");
            viewModel.TemperatureText.Is("12.30 ℃");


            viewModel.selectedAreaId = 2;
            weatherMock.Setup(x => x.GetLatest(2))
                .Returns(new WeatherEntity(
                2, Convert.ToDateTime("2020/01/01 12:34:56"), 1, 22.1345F));

            viewModel.Search();
            viewModel.selectedAreaId.Is(2);
            viewModel.DataDateText.Is("2020/01/01 12:34:56"); ;
            viewModel.ConditionText.Is("晴れ");
            viewModel.TemperatureText.Is("22.13 ℃");

            viewModel.selectedAreaId = 3;

            viewModel.Search();
            viewModel.selectedAreaId.Is(3);
            viewModel.DataDateText.Is(""); ;
            viewModel.ConditionText.Is("");
            viewModel.TemperatureText.Is("");

        }
    }
}
