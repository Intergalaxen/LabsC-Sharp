using System;
using System.Collections.Generic;
using System.Text;

namespace LabsC_Sharp
{
    class If_Statements
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
            Lab8();
        }
        public void Lab1()
        {
            Console.WriteLine("Mata in ett tal");
            int talet = Convert.ToInt32(Console.ReadLine());
            if (talet > 10)
            {
                Console.WriteLine("Talet är större än 10.");
            }
            else if (talet < 10)
            {
                Console.WriteLine("Talet är mindre än 10.");
            }
            else
                Console.WriteLine("Talet är 10.");
        }
        public void Lab2()
        {
            Console.WriteLine("Hur många mjölkpaket finns kvar?");
            int paket = Convert.ToInt32(Console.ReadLine());
            if (paket < 10)
            {
                Console.WriteLine("Beställ 30 paket");
            }
            else if (paket >= 10 && paket <= 20)
            {
                Console.WriteLine("Beställ 20 paket");
            }
            else
                Console.WriteLine("Du behöver inte beställa någon mjölk.");
        }
        public void Lab3()
        {
            Console.WriteLine("Vilken temperatur visar febertermonetern: (Skriv ',' som decimaltecken.)");
            var temp = Convert.ToDouble(Console.ReadLine());
            if (temp > 39.5)
            {
                Console.WriteLine("Du bör uppsöka läkare");
            }
            else if (temp > 37.8)
            {
                Console.WriteLine("Du har feber");
            }
            else
                Console.WriteLine("Du har inte feber");
        }
        public void Lab4()
        {
            Console.WriteLine("Mata in din ålder:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 65)
            {
                Console.WriteLine("Din ålder visar att du är pensionär");
            }
            else if (age < 18)
            {
                Console.WriteLine("Du är inte myndig");
            }
            else
                Console.WriteLine("Du är mynding men inte pensionär");
        }
        public void Lab5()
        {
            Console.WriteLine("Ange vilken kategori du tillhör (student, vuxen alt pensionär):");
            var kategori = Console.ReadLine();
            if (kategori == "vuxen")
            {
                Console.WriteLine("Biljeten kostar 30kr");
            }
            else if (kategori == "student" || kategori == "pensionär")
            {
                Console.WriteLine("Resan kostar 20kr för dig");
            }
            else
                Console.WriteLine("Du har angivit en felaktig kategori");
        }
        public void Lab6()
        {
            Console.WriteLine("Mata in ditt födelseår:");
            var födelseår = Convert.ToInt32(Console.ReadLine());
            if (födelseår >= 1980 && födelseår < 1990)
            {
                Console.WriteLine("Du är född på 80-talet");
            }
            else if (födelseår < 2000 && födelseår >= 1990)
            {
                Console.WriteLine("Du är född på 90-talet");
            }
            else
                Console.WriteLine("Du är inte född på 1990 eller 1980-talen.");
        }
        public void Lab7()
        {
            Console.WriteLine("Mata in ditt land");
            var land = Console.ReadLine().ToLower();
            if (land == "sverige" || land == "danmark" || land == "norge")
            {
                Console.WriteLine("Du bor i Skandinavien");
            }
            else
                Console.WriteLine("Du bor INTE i Skandinavien");
        }
        public void Lab8()
        {
         /* Be användaren mata in en summa på hur mycket pengar den har. Be sedan
            användaren att ange om den har rabatt.
            a. Om summan är mellan 15 och 25 och användaren inte har rabatt skriv – Du kan köpa en liten
            hamburgare.
            b. Om summan är mellan 15 och 25 och användaren har rabatt skriv – Du kan köpa en liten
            hamburgare och en pommes frites.
            c. Om summan är större än 25 och mindre än eller lika med 50 och användaren inte har rabatt skriv
            – Du kan köpa en stor hamburgare.
            d. Om summan är större än 25 och mindre än eller lika med 50 och användaren har rabatt skriv –
            Du kan köpa en stor hamburgare och pommes frites.
            e. Om summan är större än 60 eller om den är 50 och 60 och användaren har rabatt skriv – Du kan
            köpa ett meal med dryck. */
            Console.WriteLine("Enter the amount of money you have:");
            var sumOFmoney = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you have any discount? yes/no");
            var discount = Console.ReadLine().ToLower();
            if(sumOFmoney >=15 && sumOFmoney <= 25 && discount == "no")
            {
                Console.WriteLine("You can buy a small burger");
            }
            else if(sumOFmoney >= 15 && sumOFmoney <= 25 && discount == "yes")
            {
                Console.WriteLine("You can buy a small burger and fries");
            }
            else if (sumOFmoney > 25 && sumOFmoney <= 50 && discount == "no")
            {
                Console.WriteLine("You can buy a large burger");
            }
            else if (sumOFmoney > 25 && sumOFmoney <= 50 && discount == "yes")
            {
                Console.WriteLine("You can buy a large burger and fries");
            }
            else if (sumOFmoney > 60 || sumOFmoney == 50 && discount == "yes" || sumOFmoney == 60 && discount == "yes")
            {
                Console.WriteLine("You can buy a meal with soda");
            }
        }
    }
}
