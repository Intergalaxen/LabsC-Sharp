using System;
using System.Collections.Generic;
using System.Text;

namespace LabsC_Sharp.OOP
{
    class OOP_Labs
    {
        public void Run()
        {
            Lab1();
            Lab2();
        }

        public void Lab1()
        {
            var dishes = new List<OOP_Dish>();

            var m = new OOP_Dish("Pannkakor", 100, FoodType.Vegetarisk, 101);
            dishes.Add(m);

            m = new OOP_Dish("Köttbullar", 98, FoodType.Kott, 100);
            dishes.Add(m);

            m = new OOP_Dish("Hamburgare", 95, FoodType.Kott, 30);
            dishes.Add(m);


            Console.WriteLine("*** DAGENS LUNCH ***");

            Console.WriteLine("*** Vegetariska ***");
            foreach (var food in dishes)
            {
                if (food.Typ == FoodType.Vegetarisk)
                {
                    Console.WriteLine($"{food.Name} {food.GetPrice()} {food.CaloriesAmount}");
                }
            }

            Console.WriteLine("*** Kött ***");
            foreach (var food in dishes)
            {
                if (food.Typ == FoodType.Kott)
                {
                    Console.WriteLine($"{food.Name} {food.GetPrice()} {food.CaloriesAmount}");
                }
            }
        }

        public void Lab2()
        {
            var allie = new OOP_Person(new DateTime(1997, 9, 5), "Allie");
            allie.Name = "Alfrida Westberg";
            allie.ChangeAddress("Teststreet 12", 12345, "Testcity");
        }

        public void Lab3()
        {

        }
    }
}
