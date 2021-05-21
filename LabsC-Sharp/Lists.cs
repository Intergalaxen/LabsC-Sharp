using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LabsC_Sharp
{
    class Lists
    {
        public void Run()
        {
            Lab1();
            Lab2();
        }
        public void Lab1()
        {
            //Skapa ett program där användaren får upp fyra frågor om att mata in ett tal. Spara
            //alla talen i en lista. Loopa igenom lista och ta fram det tal som är störst.Skriv
            //tillbaka resultatet på skärmen för användaren
            List<int> numList = new List<int>();
            int i = 0;
            while(i < 4)
            {
                Console.Write("Input a number: ");
                numList.Add(Convert.ToInt32(Console.ReadLine()));
                i++;
            }
            
            Console.WriteLine($"The highest number you input was: {numList.Max()}");
        }
        public void Lab2()
        {
            //Utöka uppgift 1 med en inledande fråga där användaren får ange hur många tal den
            //vill mata in. Gör sedan samma sak för att ta fram det största talet.
            List<int> nums = new List<int>();
            int i = 0;
            Console.WriteLine("How many numbers do you want to input?");
            int amount = Convert.ToInt32(Console.ReadLine());
            while (i < amount)
            {
                Console.Write("Input a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                nums.Add(num);
                i++;
            }

            Console.WriteLine($"The highest number you input was: {nums.Max()}");
        }
    }
}
