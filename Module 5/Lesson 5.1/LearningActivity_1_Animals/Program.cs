using Activity_Animal;
using System;

namespace Activity_Animal
{
    public class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public Animal()
        {
            Name = "Animal";
            Legs = 0;
        }
    }

    public class Dog:Animal
    {
        public Dog()
        {
            Name = "Dog";
            Legs = 4;
        }
        
        public string Sound { get; set; }
        public void Bark()
        {
            
            Console.WriteLine("Woof",Sound);
        }
    }

    public class Fish:Animal
    {
        public Fish()
        {
            Name = "Fish";
        }
        public string Swimming { get; set; }
        public void Swim()
        {

            Console.WriteLine("Just keep swimming", Swimming);
        }
    }

    public class Shark:Fish
    {
        public Shark()
        {
            Name = "Shark";
        }
        public string Eating { get; set; }
       
        public void Eat(Animal animal)
        {

            Console.WriteLine("Shark ate "+ animal.Name , Eating);
        }
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Animal lastAnimal = null;
            string input;
            while ((input = Console.ReadLine()) != "exit")
            {
                if (input == "animal")
                {
                    var animal = new Animal();
                    Console.WriteLine(animal.Name);
                    lastAnimal = animal;
                }
                else if (input == "dog")
                {
                    var dog = new Dog();
                    Console.WriteLine(dog.Name + " " + dog.Legs);
                    dog.Bark();
                    lastAnimal = dog;
                }
                else if (input == "fish")
                {
                    var fish = new Fish();
                    Console.WriteLine(fish.Name + " " + fish.Legs);
                    fish.Swim();
                    lastAnimal = fish;
                }
                else if (input == "shark")
                {
                    var shark = new Shark();
                    Console.WriteLine(shark.Name + " " + shark.Legs);
                    shark.Swim();
                    shark.Eat(lastAnimal);
                    lastAnimal = shark;
                }
            }
        }
    }

