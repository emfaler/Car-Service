using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {



            Garage myGarage = new Garage();

            Car myCar = new Car();

            Console.WriteLine("Welcome to the car service shop!");

            bool ServiceShop = true;

            do
            {
                myCar.Tick();

                Console.WriteLine("1. Check the overall status of a vehicle.");
                Console.WriteLine("2. Paint a different color");
                Console.WriteLine("3. Add air pressure to tires");
                Console.WriteLine("4. Let out all tire pressure.");
                Console.WriteLine("5. Add oil.");
                Console.WriteLine("6. Dump Oil.");
                Console.WriteLine("7. Check how many days your car has been in the shop.");
                Console.WriteLine("8. Exit the repair shop.");
                Console.WriteLine("9. Add new car to the shop.");

                string userChoice = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (userChoice)
                {
                    case "1":
                        myCar = myGarage.SelectCar();
                        Console.WriteLine($"Oil Level: {myCar.GetOil()}");
                        Console.WriteLine($"Tire Pressure: {myCar.GetPressure()}");
                        break;

                    case "2":
                        myCar = myGarage.SelectCar();
                        Console.Clear();
                        Console.WriteLine($"Enter the new color of this {myCar.Make} {myCar.Model}");
                        string newColor = Console.ReadLine();
                        myCar.SetColor(newColor);
                        break;

                    case "3":
                        myCar = myGarage.SelectCar();
                        myCar.AddPressure();
                        if (myCar.GetPressure() > 32)
                        {
                            Console.WriteLine("WHoa there. Lets not over inflate them. Check your manual");
                        }
                        else
                            Console.WriteLine("Air has been added to your tires");
                        Console.WriteLine($"Your tire pressure is now  {myCar.GetPressure()}");
                        break;

                    case "4":
                        myCar = myGarage.SelectCar();
                        myCar.DumpPressure();
                        Console.WriteLine("All the pressure in your tires has been let out.");
                        break;

                    case "5":
                        myCar = myGarage.SelectCar();
                        myCar.ChangeOil();
                        if (myCar.GetOil() > 70)
                        {
                            Console.WriteLine("Make sure you don't add to much.");
                        }
                        else
                            Console.WriteLine("Your oil has been changed.");
                        break;

                    case "6":
                        myCar = myGarage.SelectCar();
                        Console.WriteLine("Your oil has been completely purged.");
                        myCar.DumpOil();
                        break;

                    case "7":
                        Console.WriteLine($"Your car has been here for {myCar.DaysInShop} days.");
                        break;

                    case "8":
                        ServiceShop = false;
                        Console.WriteLine("See you next time!");
                        break;
                    case "9":
                        Console.WriteLine("Enter the color of the car.");
                        string color = Console.ReadLine();
                        Console.WriteLine("Enter the make of the car.");
                        string make = Console.ReadLine();
                        Console.WriteLine("Enter the model of your car.");
                        string model = Console.ReadLine();
                        myCar = new Car(color, make, model);
                        myGarage.AddCar(myCar);
                        break;
                    case "10":



                    default:
                        Console.WriteLine("Please enter a valid selection.");
                        break;

                }
                Console.WriteLine("Return to main menu");
                Console.ReadKey();
                Console.Clear();

            }
            while (ServiceShop);










        }
    }
}
