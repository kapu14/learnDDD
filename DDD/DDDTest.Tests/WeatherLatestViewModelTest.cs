using System;
using System.Collections.Generic;
using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DDDTest.Tests
{
    [TestClass]
    public class WeatherLatestViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var weatherMock = new Mock<IWeatherRepository>();
            weatherMock.Setup(x=> x.GetLatest(1)).Returns(
                new WeatherEntity(
                     1, 
                     Convert.ToDateTime("2020/11/22 10:11:22"),
                     2, 
                     12.3F)                   
                    );

            weatherMock.Setup(x => x.GetLatest(2)).Returns(
                  new WeatherEntity(
                    2,
                    Convert.ToDateTime("2020/11/30 9:01:01"),
                    1,
                    22.392F)
                    );

            var areasMock = new Mock<IAreasRepository>();
            var areas = new List<AreaEntity>();
            areas.Add(new AreaEntity(1, "東京"));
            areas.Add(new AreaEntity(2, "神戸"));
            areas.Add(new AreaEntity(3, "沖縄"));

            areasMock.Setup(x => x.GetData()).Returns(areas);


            var viewModel = new DDD.WinForm.ViewModels.WeatherLatestViewModel(weatherMock.Object, areasMock.Object);
            Assert.IsNull( viewModel.SelectedAreaId);
            Assert.AreEqual("", viewModel.DataDateText);
            Assert.AreEqual("", viewModel.ConditionText);
            Assert.AreEqual("", viewModel.TemperatureText);
            Assert.AreEqual(3, viewModel.Areas.Count);
            Assert.AreEqual(1, viewModel.Areas[0].AreaId);
            Assert.AreEqual("東京", viewModel.Areas[0].AreaName);
            Assert.AreEqual(2, viewModel.Areas[1].AreaId);
            Assert.AreEqual("神戸", viewModel.Areas[1].AreaName);

            viewModel.SelectedAreaId = 1;
            viewModel.Serch();
            Assert.AreEqual(1, viewModel.SelectedAreaId);
            Assert.AreEqual("2020/11/22 10:11:22", viewModel.DataDateText);
            Assert.AreEqual("曇り", viewModel.ConditionText);
            Assert.AreEqual("12.30 ℃", viewModel.TemperatureText);

            viewModel.SelectedAreaId = 2;
            viewModel.Serch();
            Assert.AreEqual(2, viewModel.SelectedAreaId);
            Assert.AreEqual("2020/11/30 09:01:01", viewModel.DataDateText);
            Assert.AreEqual("晴れ", viewModel.ConditionText);
            Assert.AreEqual("22.39 ℃", viewModel.TemperatureText);

            viewModel.SelectedAreaId = 3;
            viewModel.Serch();
            Assert.AreEqual(3, viewModel.SelectedAreaId);
            Assert.AreEqual("", viewModel.DataDateText);
            Assert.AreEqual("", viewModel.ConditionText);
            Assert.AreEqual("", viewModel.TemperatureText);


        }
    }



}
