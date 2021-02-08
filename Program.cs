using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine("Welcome to the car repair shop.\nPlease enter some info about your car and we can get started.");
            Console.WriteLine("Enter the make of the car.");
            car.SetMake(Console.ReadLine());
            Console.WriteLine("Enter the model of the car.");
            car.SetModel(Console.ReadLine());
            Console.WriteLine("Enter the color of your car.");
            car.SetColor(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Your {car.Color} {car.Make} {car.Model} is now in the shop");
            Console.WriteLine("Press enter to view service options");
            Console.ReadKey();
            Console.Clear();

            //Service Menu

            bool ServiceShop = true;

            do
            {

                Console.WriteLine("1. See the overall status of your car.");
                Console.WriteLine("2. Paint a different color");
                Console.WriteLine("3. Add air pressure to tires");
                Console.WriteLine("4. Let out all tire pressure.");
                Console.WriteLine("5. Change oil.");
                Console.WriteLine("6. Dump Oil.");
                Console.WriteLine("7. Exit the repair shop.");

                string userChoice = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine($"{car.Color} {car.Make} {car.Model}\n" +
                            $"Oil Life:{car.GetOil()}\nTire Pressure:{car.GetPressure()}");
                        break;

                    case "2":
                        Console.WriteLine($"What color would you like to paint your car?");
                        car.SetColor(Console.ReadLine());
                        Console.WriteLine($"Your car is now {car.Color}");
                        break;

                    case "3":
                        car.AddPressure();
                        if (car.GetPressure() > 50)
                        {
                            Console.WriteLine("WHoa there. Lets not over inflate them. Check your manual");
                        }
                        else
                        Console.WriteLine("Air has been added to your tires");
                        Console.WriteLine($"Your tire pressure is now  {car.GetPressure()}");
                        break;

                    case "4":
                        Console.WriteLine("All the pressure in your tires has been let out.");
                        car.DumpPressure();
                        break;

                    case "5":
                        car.ChangeOil();
                        if (car.GetOil() > 70)
                        {
                            Console.WriteLine("Make sure you don't add to much.");
                        }
                        else
                        Console.WriteLine("Your oil has been changed.");
                        break;

                    case "6":
                        Console.WriteLine("Your oil has been completely purged.");
                        car.DumpOil();
                        break;

                    case "7":
                        ServiceShop = false;
                        Console.WriteLine("See you next time!");
                        break;

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
