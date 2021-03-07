using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    class Program
    {

        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();
            Shark shark = new Shark();
            Eagle eagle1 = new Eagle();
            Shark shark1 = new Shark();
            Eagle eagle2 = new Eagle();
            Shark shark2 = new Shark();
            Shark shark3 = new Shark();

            List<Animal> animals = new List<Animal>();
            animals.Add(shark);
            animals.Add(eagle);
            animals.Add(shark1);
            animals.Add(eagle1);
            animals.Add(shark2);
            animals.Add(eagle2);















            //Eagle newEagle = (Eagle)animals[1];

            //foreach (Animal animal in animals)
            //{
            //    if (animal is Eagle)
            //    {
            //        Eagle newEagle = (Eagle)animal;
            //        newEagle.Eat();
            //    }
            //    else
            //    {
            //        Shark newShark = (Shark)animal;
            //        newShark.Eat();
            //    }
            //}

            //foreach (Animal animal in animals)
            //{
            //    Shark newShark = animal as Shark;
            //    if (newShark != null)
            //    {
            //        newShark.Eat();
            //    }
            //    else
            //    {
            //        Eagle newEagle = (Eagle)animal;
            //        newEagle.Eat();

            //    }
            //}
        }
    }

    abstract class Animal
    {
        public abstract void Eat();
    }

    abstract class Bird : Animal
    {
        public abstract void Fly();
    }

    abstract class Fish : Animal
    {
        public abstract void Swim();
    }

    class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Eat As Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim As Shark");
        }
    }

    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat As Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly As Eagle");
        }
    }
}
