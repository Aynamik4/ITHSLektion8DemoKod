using System;
using System.Collections.Generic;

namespace Inheritence1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Owl owl = new Owl(1, true, 100);
            //string s = owl.ToString();
            //Console.WriteLine(s);

            List<Animal> zoo = new List<Animal>();

            Owl owl = new Owl(1, true, 100);
            zoo.Add(owl);

            Dolphin dolphin = new Dolphin(50, false, 200);
            zoo.Add(dolphin);

            Horse horse = new Horse(600, false, 20);
            zoo.Add(horse);

            foreach (Animal anAnimal in zoo)
            {
                Console.WriteLine($"Weight: {anAnimal.Weight}");
                Console.WriteLine($"Nocturnal: {anAnimal.Nocturnal}");
                anAnimal.Move();

                string msg = anAnimal switch
                {
                    Owl extraOwl => $"Wingspan: {extraOwl.Wingspan}",
                    Dolphin extraDolphin => $"Fish per day: {extraDolphin.FishPerDay}",
                    Horse extraHorse => $"Hay per day: {extraHorse.HayPerDay}",
                    _ => "N/A"
                };

                Console.WriteLine(msg);

                //if(anAnimal is Owl)
                //{
                //    Console.WriteLine($"Wingspan: {((Owl)anAnimal).Wingspan}");
                //}

                //if (anAnimal is Dolphin)
                //{
                //    Console.WriteLine($"Fish per day: {((Dolphin)anAnimal).FishPerDay}");
                //}

                //if (anAnimal is Horse)
                //{
                //    Console.WriteLine($"Hay per day: {((Horse)anAnimal).HayPerDay}");
                //}

                Console.WriteLine();
            }
        }
    }

    // Animal is our base class.
    class Animal
    {
        public int Weight { get; set; }
        public bool Nocturnal { get; set; }
        public virtual void Move()
        {
            Console.WriteLine("blablabla...");
        }
    }

    class Owl : Animal
    {
        public int Wingspan { get; set; }

        public Owl(int weight, bool isNocturnal, int wingspan)
        {
            Weight = weight;
            Nocturnal = isNocturnal;
            Wingspan = wingspan;
        }

        public override void Move()
        {
            Console.WriteLine("The own flies around in the sky...");
        }

        public override string ToString()
        {
            return $"Weight: {Weight} Nocturnal: {(Nocturnal ? "Yes" : "No")} Wingspan: {Wingspan}";
        }
    }

    class Dolphin : Animal
    {
        public int FishPerDay { get; set; }

        public Dolphin(int weight, bool isNocturnal, int fishPerDay)
        {
            Weight = weight;
            Nocturnal = isNocturnal;
            FishPerDay = fishPerDay;
        }

        public override void Move()
        {
            Console.WriteLine("The dolphin swims around in the wast ocean.");
        }
    }

    class Horse : Animal
    {
        public int HayPerDay { get; set; }

        public Horse(int weight, bool isNocturnal, int hayPerday)
        {
            Weight = weight;
            Nocturnal = isNocturnal;
            HayPerDay = hayPerday;
        }

        public override void Move()
        {
            Console.WriteLine("The horse walks around in the park.");
        }
    }
}
