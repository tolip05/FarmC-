using Farm01.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farm01.animals
{
    public class Cat : Felime
    {
        private string breed;
        public Cat(string animalName, string animalType, double animalWeight, string livingRegion,string breed) 
            : base(animalName, animalType, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get => breed;
            protected set
            {
                breed = value;
            }
        }

        public override void EatFood(Food food)
        {
            base.FoodEaten = food.Quantity;


        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return $"{base.AnimalType}[{base.AnimalName},{this.Breed},{base.AnimalWeight},{this.LivingRegion},{base.FoodEaten}]";
        }
    }
}
