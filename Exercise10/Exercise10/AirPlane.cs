using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class AirPlane : Vehicle
    {
        public bool WheelPosition { get; set; }
       public AirPlane(string VehicleType) : base (VehicleType)
        {
           this.WheelPosition = false;
        }
        public void TurnInWheels()
        {
            this.WheelPosition = false;
        }
        public void TurnOutWheels()
        {
            this.WheelPosition = true;
        }
    }
}
