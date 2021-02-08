using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Car
    {

        public Car()
        {
            Random random = new Random();

            Pressure = random.Next(14, 26);
            OilLevel = random.Next(14, 30);
        }


        public int Pressure { get; set; }
        public int OilLevel { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        //public int DaysInShop { get; set; }




        public string SetModel(string model)
        {
            Model = model;
            return Model;
        }

        public string SetMake(string make)
        {
            Make = make;
            return Make;
        }


        public int GetPressure()
        {
            return Pressure;
        }

        public int GetOil()
        {
            return OilLevel;
        }

        public string GetColor()
        {
            return Color;
        }

        public void ChangeOil()
        {
            OilLevel += 25;
            if (OilLevel > 100)
            {
                OilLevel = 100;
            }
        }

        public void DumpOil()
        {
            OilLevel = 0;
        }

        public void DumpPressure()
        {
            Pressure = 0;
        }



        public void AddPressure()
        {
            Pressure += 6;
        }

        public string SetColor(string color)
        {
            Color = color;
            return Color;
        }


        


















    }
}
