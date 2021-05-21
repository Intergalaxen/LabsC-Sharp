using System;
using System.Collections.Generic;
using System.Text;

namespace LabsC_Sharp
{
    class Variables
    {
        public void Run()
        {
            HelloWorld();
            MyName();
            stringANDint();
            firstANDlastname();
            inputANDsum();
            yearOFbirth();
            calculations();
            hours_minutes();
        }
        public void HelloWorld()
        {
            //Skriv en C# Console-applikation som skriver Hello World! på skärmen.
            Console.WriteLine("Hello World!");
        }
        public void MyName()
        {
            var name = "Allie";
            Console.WriteLine($"Hello {name}");
        }
        public void stringANDint()
        {
            //a.Skapa en variabel string name med ditt namn
            //b.Skapa en int age med din ålder.
            //c.Skriv sedan ut Jag heter Kalle(innehållet i name) och är 27(innehållet i age) år.
            string name = "Allie";
            int age = 23;
            Console.WriteLine($"Hi, my friends call me {name} and I'm {age} years old.");
        }
        public void firstANDlastname()
        {
            Console.Write("Input your firstname: ");
            var firstnamn = Console.ReadLine();
            Console.Write("Input your lastname: ");
            var lastnamn = Console.ReadLine();

            Console.WriteLine($"Your full name is: {lastnamn}, {firstnamn}");
        }
        public void inputANDsum()
        {
            Console.WriteLine("Mata in ett tal");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mata in ett till tal");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);
        }
        public void yearOFbirth()
        {
            Console.WriteLine("Vilket år är du född?(4 siffror)");
            int year = Convert.ToInt32(Console.ReadLine());
            var age = 2021 - year;
            Console.WriteLine($"Din ålder är: {age}");
        }
        public void calculations()
        {
            Console.WriteLine("Mata in ett tal:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mata in ett till tal:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Medelvärdet av talen är: {(num1 + num2) / 2}, summan av talen är: {num1 + num2} och differensen mellan talen är: {num1 / num2}");
        }
        public void MOREcalculations()
        {
            Console.WriteLine("Mata in ett pris");
            string s = Console.ReadLine();
            decimal d = Convert.ToDecimal(s);

            decimal moms = d * 0.25m;
            //decimal total = moms + d;
            Console.WriteLine($"Momsen är {moms} kr och totalsumman är {moms + d} kr");
        }
        public void hours_minutes()
        {
            Console.WriteLine("Mata in antal minuter(över 60):");
            int minuter = Convert.ToInt32(Console.ReadLine());
            var timmar = Convert.ToInt32(minuter / 60);
            Console.WriteLine($"Detta är {timmar} timmar och {minuter - (timmar * 60)} minuter");
        }
    }
}
