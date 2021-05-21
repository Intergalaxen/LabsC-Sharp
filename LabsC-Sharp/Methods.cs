using System;
using System.Collections.Generic;
using System.Linq;

namespace LabsC_Sharp
{
    class Methods
    {
        public void Run()
        {
            Lab1();
            Lab2();
            Lab3();
            Lab4();
            Lab5();
        }

        public void Lab1()
        {
            string PrintMessage()
            {
                return "Hello World!";
            }

            //string printMessage = PrintMessage();
            //Console.WriteLine(printMessage);
            Console.WriteLine(PrintMessage());
        }

        public void Lab2()
        {
            string AddingStrings(string str1, string str2)
            {
                //return str1 +" "+ str2;
                return ($"{str1} {str2}");
            }

            Console.Write("Input some text: ");
            string FirstString = Console.ReadLine();
            Console.Write("Input some more text: ");
            string SecondString = Console.ReadLine();

            string addStrings = AddingStrings(FirstString, SecondString);
            Console.WriteLine(addStrings);
        }

        public void Lab3()
        {
            int CalculateVat(int sum)
            {
                return Convert.ToInt32(sum * 0.25m);
            }

            Console.Write("Enter the sum you want to calculate the VAT for: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            int vat = CalculateVat(sum);
            Console.WriteLine($"The VAT for {sum}kr is {vat}kr");
        }

        public void Lab4()
        {
            bool IsOfAge(int age)
            {
                return age >= 18;
            }

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (IsOfAge(age))
                Console.WriteLine("You are of legal age.");
            else
                Console.WriteLine("You have not reached the Age of Majority.");
        }

        public void Lab5()
        {
            string FindLongestWord(List<string> words)
            {
                string longestSoFar = words.First();

                foreach (string word in words)
                {
                    if (word.Length > longestSoFar.Length)
                    {
                        longestSoFar = word;
                    }
                }

                return longestSoFar;
            }

            List<string> words = new List<string>();
            //words.Add("Hey");
            //words.Add("you");
            //words.Add("are");
            //words.Add("cute");
            while (true)
            {
                Console.Write("Input a word: ");
                var word = Console.ReadLine();
                words.Add(word);
                Console.WriteLine("Do you want to input another word? y/n");
                if (Console.ReadLine().ToLower() == "n")
                    break;
            }
            string longest = FindLongestWord(words);
            Console.WriteLine($"The longest word is: {longest}");
        }
    }
}
