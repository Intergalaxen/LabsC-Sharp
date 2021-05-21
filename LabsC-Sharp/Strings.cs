using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LabsC_Sharp
{
    class Strings
    {
        public void Run()
        {
            Lab1();
            Lab2();
            Lab3();
            Lab4();
            Lab5();
            Lab6();
            Lab7();
        }

        public void Lab1()
        {
            List<string> messages = new List<string>();
            Console.WriteLine("Write three messages");
            int i = 1;
            while (i < 4)
            {
                Console.Write($"Message {i}: ");
                string message = Console.ReadLine();
                messages.Add(message + " ");
                i++;
            }
            var addSrings = string.Concat(messages);
            Console.WriteLine(addSrings);
            //foreach(string message in messages)
            //{
            //    Console.Write($"{message} ");
            //}
            //Console.WriteLine("");
            Console.WriteLine("");
        }

        public void Lab2()
        {
            var greeting = "Hello, world";
            int w = greeting.IndexOf('w');
            Console.WriteLine($"In the text '{greeting}' the first presence of letter '{greeting[w]}' are on position {w} in the string.");
        }

        public void Lab3()
        {
            string Capitalized(string str)
            {
                int IndexOfSpace = str.IndexOf(" ") + 1;
                int length = str.Count();
                var LastName = str[IndexOfSpace].ToString().ToUpper();
                var lastName = LastName + str.Substring(IndexOfSpace + 1, length - IndexOfSpace -1);
                var FirstName = str[0].ToString().ToUpper();
                var firstName = FirstName + str.Substring(1, IndexOfSpace - 1);
                return firstName + lastName;

            }
            string name = "kurt andersson";
            string capitalized = Capitalized(name); 
            Console.WriteLine(capitalized);
        }

        public void Lab4()
        {
            //Du har en sträng med texten ”Detta är en sträng som du skall ändra”. Ersätt via kod
            //alla blanktecken i strängen med tecknet * .Räkna sedan ut via kod hur många förekomster det finns av tecknet * i strängen.
            var theString = "This is a string that you should change";
            theString = theString.Replace(" ", "*");
            Console.WriteLine($"The string '{theString}' appears the symbol '*' {theString.Count(f => f == '*')} times"); 
        }

        public void Lab5()
        {
            //Be användaren mata in en mailadress. Programmet skall kontrollera att inmatningen är
            //rätt dvs att det finns ett @ tecken och att det finns en . med 2 eller 3 tecken efter.
            //Meddela användaren om det är rätt eller felaktig adress
            Console.Write("Enter a Emailadress: ");
            while (true)
            {
                var mailAdress = Console.ReadLine();
                if (mailAdress.Contains('@') && mailAdress.Contains('.'))
                {
                    Console.WriteLine("The Emailadress is valid");
                    break;
                }
                else
                    Console.WriteLine("The Emailadress is not valid, pleas enter a valid Email: ");
            }
        }

        public void Lab6()
        {
            //Gör ett program där användaren får mata in en mening t ex ”Detta är min text
            //som jag matar in”. Programmet skall räkna ut hur många ord meningen består av
            //och meddela användaren om detta.
            Console.Write("Enter a sentence: ");
            var sentence = Console.ReadLine();
            int countWords = sentence.Split(' ').Length;
            Console.WriteLine($"There is {countWords} words in the sentence '{sentence}'");
        }

        public void Lab7()
        {
            Console.Write("Input text: ");
            string textInput = Console.ReadLine().ToLower();
            textInput = textInput.Replace(" ", "");
            string reverse = "";

            foreach(char ch in textInput)
            {
                reverse = ch + reverse;
            }

            if(reverse == textInput)
            {
                Console.WriteLine("It's a palindrome");
            }
        }
    }
}
