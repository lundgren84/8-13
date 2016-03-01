using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
   public class Car : Vehicle
    {
        private bool _engineIsRunning;

        public bool EngineIsRunning
        {
            get { return _engineIsRunning; }
            set { _engineIsRunning = value; }
        }


       public Car(string VehicleType) :base (VehicleType)
        {           
            this._engineIsRunning = false;
        }
        public void StartEngine()
        {
            this._engineIsRunning = true;
        }
        public void StopEngine()
        {
            this._engineIsRunning = false;
        }
    }
}
