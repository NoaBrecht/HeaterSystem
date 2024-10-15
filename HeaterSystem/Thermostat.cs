using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterSystem
{
    public class Thermostat
    {
        private readonly IHeatingElement _heatingElement;
        private readonly ITemperatureSensor _temperatureSensor;


        public double SetPoint { get; set; }
        public double OffSet { get; set; }
        public void work()
        {

        }
        public Thermostat(ITemperatureSensor temperatureSensor, IHeatingElement heatingElement)
        {
            _temperatureSensor = temperatureSensor;
            _heatingElement = heatingElement;
        }
    }
}
