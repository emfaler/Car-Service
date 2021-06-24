using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Garage
    {
        public List<Car> ListofCars = new List<Car>();

        public void AddCar(Car car)
        {
            ListofCars.Add(car);
        }

        public Car SelectCar()
        {
            int index = 1;

            Console.WriteLine("Please select a car from the list:");
            foreach (Car car in ListofCars)
            {
                Console.WriteLine($"{index}. {car.Color} {car.Make} {car.Model}");
                index++;
            }

            int indexSelected = Convert.ToInt32(Console.ReadLine());

            return ListofCars[indexSelected - 1];

        }


    }
}
