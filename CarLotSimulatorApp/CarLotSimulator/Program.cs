using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {


        static void Main(string[] args)
        {

            var newCar = new Car();



            CarLot carLot = new CarLot();
            carLot.CarList = new List<Car>();

            newCar.Year = 2010;
            newCar.Make = "BMW";
            newCar.Model = "745LI";
            newCar.EngineNoise = "Vroom,Vroom";
            newCar.HonkNoise = "Beep Beep";
            newCar.IsDriveable = "YES";
            newCar.MakeEngineNoise();
            newCar.MakeHonkNoise();
            carLot.CarList.Add(newCar);
            int spot = CarLot.numOfCars(1);
            Console.WriteLine();

            // next

            var newCar2 = new Car() {

                Year = 2020,
                Make = "FORD",
                Model = "FOCUS",
                EngineNoise = "Vroom,Vroom",
            HonkNoise = "Beep Beep",
                IsDriveable = "YES",
            };
                 newCar2.MakeEngineNoise();
                 newCar2.MakeHonkNoise();
                carLot.CarList.Add(newCar2);
            int spot1 = CarLot.numOfCars(2);
            Console.WriteLine();

            // Next

            var newCar3 = new Car() { Year = 2014, Model = "Pontiac", Make = "Sunfire", IsDriveable = "yes", EngineNoise = "vroom", HonkNoise = "Beep beep" };


               newCar3.MakeEngineNoise();
                newCar3.MakeHonkNoise();
                carLot.CarList.Add(newCar3);
            int spot2 = CarLot.numOfCars(3);
            Console.WriteLine();



                foreach(var car in carLot.CarList)
                {
                    Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                }
                


            }




            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
        

