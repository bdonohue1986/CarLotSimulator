using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public string IsDriveable { get; set; }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }

        public Car(string make, int year, string model, string enginenoise, string honknoise, string isdriveable)
        {
            Make = make;
            Year = year;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDriveable = isdriveable;
        }

        public Car()
        {
        }


    }

}
