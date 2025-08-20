using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS2.Classes
{
    interface IVehicle
    {
        void Start();
        void Stop();
    }

    class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped.");
        }
    }

}
