using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Welcome to the car repair shop.\nPlease enter some info about your car and we can get started.");
            //Console.WriteLine("Enter the make of the car.");
            //car.SetMake(Console.ReadLine());
            //Console.WriteLine("Enter the model of the car.");
            //car.SetModel(Console.ReadLine());
            //Console.WriteLine("Enter the color of your car.");
            //car.SetColor(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine($"Your {car.Color} {car.Make} {car.Model} is now in the shop");
            //Console.WriteLine("Press enter to view service options");
            //Console.ReadKey();
            //Console.Clear();

            //Service Menu

            Garage myGarage = new Garage();

            Car myCar = new Car();

            Console.WriteLine("Welcome to the car service shop!");

            bool ServiceShop = true;

            do
            {
                myCar.Tick();

                Console.WriteLine("1. See the overall status of your cars.");
                Console.WriteLine("2. Paint a different color");
                Console.WriteLine("3. Add air pressure to tires");
                Console.WriteLine("4. Let out all tire pressure.");
                Console.WriteLine("5. Change oil.");
                Console.WriteLine("6. Dump Oil.");
                Console.WriteLine("7. Check how many days your car has been in the shop.");
                Console.WriteLine("8. Exit the repair shop.");
                Console.WriteLine("9. Add your car's information.");

                string userChoice = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (userChoice)
                {
                    case "1":
                        //Console.WriteLine($"{car.GetColor()} {car.GetMake()} {car.GetModel()}\n" +
                        //    $"Oil Life:{car.GetOil()}\nTire Pressure:{car.GetPressure()}");
                        foreach (var item in myGarage.ListofCars)
                        {
                            Console.WriteLine($"{myCar.GetColor()} {myCar.GetMake()} {myCar.GetModel()}");
                        }
                        break;

                    //case "2":
                    //    Console.WriteLine($"What color would you like to paint your car?");
                    //    myCar.SetColor(Console.ReadLine());
                    //    Console.WriteLine($"Your car is now {car.Color}");
                    //    break;

                    //case "3":
                    //    car.AddPressure();
                    //    if (car.GetPressure() > 50)
                    //    {
                    //        Console.WriteLine("WHoa there. Lets not over inflate them. Check your manual");
                    //    }
                    //    else
                    //    Console.WriteLine("Air has been added to your tires");
                    //    Console.WriteLine($"Your tire pressure is now  {car.GetPressure()}");
                    //    break;

                    //case "4":
                    //    Console.WriteLine("All the pressure in your tires has been let out.");
                    //    car.DumpPressure();
                    //    break;

                    //case "5":
                    //    car.ChangeOil();
                    //    if (car.GetOil() > 70)
                    //    {
                    //        Console.WriteLine("Make sure you don't add to much.");
                    //    }
                    //    else
                    //    Console.WriteLine("Your oil has been changed.");
                    //    break;

                    //case "6":
                    //    Console.WriteLine("Your oil has been completely purged.");
                    //    car.DumpOil();
                    //    break;

                    //case "7":
                    //    Console.WriteLine($"Your car has been here for {car.DaysInShop} days.");
                    //    break;

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
