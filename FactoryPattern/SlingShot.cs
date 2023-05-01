using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class SlingShot : IVehicle
    {
        public SlingShot()
        {

        }

        

        public void Build()
        {
            Console.WriteLine("Feel the air and the sun while you ride with the music turned up!");
        }
    }
}
