using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using R3DDD.Domain.ValueObjects;

namespace R3DDDTest.Tests.ValueObjectTests
{
    [TestClass]
    public class TemperatureTest
    {
        [TestMethod]
        public void 小数点以下を丸めて表示できる()
        {
            var t = new Temperature(12.3f);
            t.Value.Is(12.3f);

        }
    }
}
