using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using R3DDD.Domain.Entities;
using R3DDD.Domain.Repositories;
using R3DDD.WinForm.ViewModels;

namespace R3DDDTest.Tests.ViewModelTests
{
    [TestClass]
    public class WeatherLatestViewModelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //起動初期値
            var WeatherMock = new Mock<IWeatherRepository>();
            var vm = new WeatherLatestViewModel(WeatherMock.Object);
            vm.AreaIdText.Is("");
            vm.AreaNameText.Is("");
            vm.DataDateText.Is("");
            vm.ConditionText.Is("") ;
            vm.TemperatureText.Is("");

            var entiry = new WeatherEntity(1, "東京", Convert.ToDateTime("2021/01/02 11:22:33"), 1, 20.302F);
                        
            WeatherMock.Setup(x => x.GetLatest()).Returns(entiry);
            vm.Search();
            vm.AreaIdText.Is("1");
            vm.AreaNameText.Is("東京");
            vm.DataDateText.Is("2021/01/02 11:22:33");
            vm.ConditionText.Is("1");
            vm.TemperatureText.Is("20.30 ℃");



        }
    }
}


