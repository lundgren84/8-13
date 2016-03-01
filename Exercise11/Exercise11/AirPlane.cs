using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
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
        public override string DescribeVehicle()
        {
            string wheelStatus;
            if (WheelPosition == true) { wheelStatus = "up / inside"; }
            else { wheelStatus = "out"; }
            string description = $"This Airpalne is a {VehicleType} and the wheels are {wheelStatus} ";
            return description;
        }


    }
}
