using System;
using System.Collections.Generic;
using System.Text;

namespace LabsC_Sharp
{
    class Loops
    {
        public void Run()
        {
            //Lab1();
            //Lab2();
            //Lab3();
            //Lab4();
            //Lab5();
            //Lab6a();
            //Lab6b();
            Lab7();
        }
        public void Lab1()
        {
            // Skapa ett program som skriver ut nums 0 - 10 på skärmen. Lös detta med en for-loop.
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Lab2()
        {
            // Skapa ett program där användaren får mata in två tal. Låt sedan programmet skriva ut alla
            // tal som finns mellan dessa två tal på skärmen.Lös detta med en for-loop.
            Console.WriteLine("We'll gonna count up from the start number you'll choose, all the way up to the end number you'll input");
            Console.WriteLine("Input a start number");
            int startNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("End number:");
            int endNum = Convert.ToInt32(Console.ReadLine());
            for (int i = startNum; i <= endNum; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void Lab3()
        {
            //  Skapa ett program där användaren
            //a. Får mata in två tal.
            //b. Skriv sedan till skärmen summan av de två nums.
            //c. Skriv sedan en fråga- Vill du fortsätta(J/N)?.
            //d. Svarar användaren J återupprepas punkt a-c
            //e. Svarar användaren N avbryts programmet
            while (true)
            {
                Console.WriteLine("Input a number:");
                int Num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input a second number:");
                int Num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"The sum of {Num1} and {Num2} is {Num1 + Num2}");
                Console.WriteLine("Do you want to continue? (Y/N)?");

                string cont;
                while (true)
                {
                    cont = Console.ReadLine().ToUpper();
                    if (cont == "N" || cont == "Y")
                    {
                        break;
                    }
                    Console.WriteLine("Please input 'Y' if you want to continue or 'N' to quit.");
                }
                if (cont == "N")
                {
                    break;
                }
            }

        }
        public void Lab4()
        {
            //Be användaren mata in ett tal. Spara värdet i en variabel.Upprepa detta 10 gånger.
            //För varje gång lägg till det inmatade värdet till variabelns värde.När det är klart skriv utSumman av det du matat in är: summan.
            int Sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                Console.Write("Type a number: ");
                int Num = Convert.ToInt32(Console.ReadLine());
                Sum = Num + Sum;
                Console.WriteLine($"The sum of what you entered is: {Sum}");
            }
        }
        public void Lab5()
        {
            //Skapa ett program där användaren får mata in ett tal. Låt sedan programmet skriva ut
            //alla siffor som är mindre än det inmatade talet men större än 0.Lös detta med en loop.
            Console.Write("Type a number: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            while (Num > 0)
            {
                Console.WriteLine(Num - 1);
                Num--;
            }
        }

        // Lab 6
        public decimal Average(decimal newest, decimal middle, decimal oldest, int count)
        {
            if(count == 1)
            {
                return newest;
            }
            else if (count == 2)
            {
                return (newest + middle) / 2m;
            }
            else
                return (newest + middle + oldest) / 3m;
        }
        public void Lab6a()
        {
            //Om medelvärdet av sista tre > 25 så skriv ut ”Alarm”

            decimal newest = 0;
            decimal middle = 0;
            decimal oldest = 0;
            int count = 0;

            while (true)
            {
                Console.Write("Enter temp: ");
                decimal d = Convert.ToDecimal(Console.ReadLine());
                oldest = middle;
                middle = newest;
                newest = d;
                count++;
                decimal average = Math.Round(Average(newest, middle, oldest, count), 2);
                Console.WriteLine($"Average temperature: {average}");
                if (average > 25)
                {
                    Console.WriteLine("Alarm");
                }
            }
        }

        public void Lab6b()
        {
            List<decimal> nums = new List<decimal>();
            while (true)
            {
                Console.Write("Enter temp: ");
                decimal d = Convert.ToDecimal(Console.ReadLine());
                nums.Add(d);
                while (nums.Count > 3)
                    nums.RemoveAt(0);

                decimal sum = 0;
                foreach (var num in nums)
                    sum += num;

                decimal average = Math.Round(sum / nums.Count);
                Console.WriteLine($"Average: {average}");
                if(average > 25)
                {
                    Console.WriteLine("Alarm!");
                }
            }
        }

        public void Lab7()
        {
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine("Rolling the dices");
                Console.WriteLine("The values are");
                Console.WriteLine(rnd.Next(1, 7));
                Console.WriteLine(rnd.Next(1, 7));
                Console.Write("Roll the dices again? y/n");
                if (Console.ReadLine().ToLower() != "y") break;

            }
        }
    }
}
