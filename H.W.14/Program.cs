using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
            
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string Say();
        public virtual void ShowInfo()
        {
            Console.WriteLine("Животное "+Name+" Издает звук "+Say());
        }

    }
    class Cat:Animal
    {
        string name = "Кошка";

        public override string Name { get => name; set => name = value; }

        public override string Say()
        {
            return "Мяу";   
        }
    }
    class Dog : Animal
    {
        string name = "Собака";
        public override string Name { get => name; set => name = value; }

        public override string Say()
        {
            return "Гав";
        }
    }
}
