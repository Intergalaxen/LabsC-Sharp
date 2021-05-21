using System;
using System.Collections.Generic;
using System.Text;

namespace LabsC_Sharp.OOP
{
    class OOP_Dish
    {
        public string Name { get; set; }
        public decimal Price { private get; set; }
        public FoodType Typ { get; set; }
        public int CaloriesAmount { get; set; }

        public OOP_Dish(string name, decimal price, FoodType typ, int caloriesAmount)
        {
            Name = name;
            Price = price;
            Typ = typ;
            CaloriesAmount = caloriesAmount;
        }

        public decimal GetPrice()
        {
            if (Typ == FoodType.Vegetarisk && DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                return Price * 0.8m;
            }

            return Price;
        }
    }

    public enum FoodType
    {
        None,
        Kott,
        Vegan,
        Vegetarisk
    }
}
