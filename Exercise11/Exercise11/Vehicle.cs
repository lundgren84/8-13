using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    abstract public class Vehicle
    {
        private string _vehicleType;

        public string VehicleType
        {
            get { return _vehicleType; }
            set { _vehicleType = value; }
        }
        public Vehicle(string VehicleType)
        {
            this._vehicleType = VehicleType;
        }
        public virtual string DescribeVehicle()
        {
            string description = $"This vehicle is a {_vehicleType}";
            return description;
        }

    }
}
