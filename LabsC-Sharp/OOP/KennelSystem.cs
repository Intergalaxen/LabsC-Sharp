using System;
using System.Collections.Generic;
using System.Text;

namespace LabsC_Sharp.OOP
{
    class KennelSystem
    {
        public void Run()
        {
            void Menu()
            {
                Console.WriteLine("1.Register");
                Console.WriteLine("2.List dogs");
                Console.WriteLine("3.Remove");
                Console.WriteLine("4.Exit");
                Console.Write("Choose -->");
            }
            while (true)
            {
                Menu();
                var dogs = new List<Dog>();
                var sel = Convert.ToInt32(Console.ReadLine());
                if(sel == 1)
                {
                    Dog dog = CreateDog();
                    dogs.Add(dog);
                }
                else if(sel == 2)
                {
                    ListDogs(dogs);
                }
            }
        }

        private void ListDogs(List<Dog> dogs)
        {
            throw new NotImplementedException();
        }

        public Dog CreateDog()
        {
            var dog = new Dog();
            Console.Clear();

            return dog;
        }

    }

    class Dog
    {
        public string Ras { get; set; }
        public int Age { get; set; }
        public int Vikt { get; set; }

        
    }
}
