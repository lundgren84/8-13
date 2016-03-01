using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData vehicleData = new VehicleData();
            Car car = new Car("Volvo v70");
            AirPlane airplane = new AirPlane("JumboJet");

            vehicleData.PrintVehicle(car);
            vehicleData.PrintVehicle(airplane);
            Console.ReadKey();
        }
    }
}
