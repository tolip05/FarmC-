using Farm01.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farm01.animals
{
    public abstract class Animal
    {
        private string animalName;

        private string animalType;

        private double animalWeight;

        private int foodEaten;

        protected Animal(string animalName, string animalType, double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.AnimalWeight = animalWeight;
            this.FoodEaten = 0;
        }

        public string AnimalName { get => animalName; set => animalName = value; }
        public string AnimalType { get => animalType; set => animalType = value; }
        public double AnimalWeight { get => animalWeight; set => animalWeight = value; }
        public virtual int FoodEaten
        {
            get => foodEaten;
            set
            {
                foodEaten = value;
            }
        }

        public abstract void MakeSound();
        public abstract void EatFood(Food food);
    }
}
