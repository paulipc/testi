using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbox
{
    public class Thermostat
    {
        public int Temperature { get; set; }
        public void SetTemperature(int temp)
        {
            Temperature = temp;
        }
    }
}
