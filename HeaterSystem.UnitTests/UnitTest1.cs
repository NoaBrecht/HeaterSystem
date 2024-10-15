using Moq;

namespace HeaterSystem.UnitTests
{
    [TestClass]
    public class ThermostatTests
    {
        [TestMethod]
        public void WorkWhenTemperatureBetweenBoundariesDoNothing()
        {
            // arange
            var TemperatureSensor = new Mock<ITemperatureSensor>();
            TemperatureSensor.Setup(x => x.GetTemperature()).Returns(19);
            var HeatingElement = new Mock<IHeatingElement>();

            Thermostat thermostat = new Thermostat(TemperatureSensor.Object, HeatingElement.Object);
            thermostat.SetPoint = 20;
            thermostat.OffSet = 2;
            //ACT

            //ASSERT

        }
    }
}