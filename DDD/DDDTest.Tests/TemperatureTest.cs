using System;
using DDD.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDTest.Tests
{
    [TestClass]
    public class TemperatureTest
    {
        [TestMethod]
        public void 小数点以下2位で丸めて表示できる()
        {
            var t = new Temperature(12.3F);
            Assert.AreEqual(12.3F, t.Value);
            Assert.AreEqual("12.30", t.DisplayValue);
            Assert.AreEqual("12.30℃", t.DisplayValueWithUnit);
            Assert.AreEqual("12.30 ℃", t.DisplayValueWithUnitSpace);

        }

        [TestMethod]
        public void 温度equal()
        {
            var t1 = new Temperature(12.3F);
            var t2 = new Temperature(12.3F);
            Assert.AreEqual(true,t1.Equals(t2));


        }

        [TestMethod]
        public void 温度equalequal()
        {
            var t1 = new Temperature(12.3F);
            var t2 = new Temperature(12.3F);
            Assert.AreEqual(true, t1 == t2);
        }


        [TestMethod]
        public void 値equal()
        {
            float t1 = 12.3F;
            float t2 = 12.3F;
            Assert.AreEqual(true, t1.Equals(t2));
            Assert.AreEqual(true, t1 == t2);



        }

    }
}
