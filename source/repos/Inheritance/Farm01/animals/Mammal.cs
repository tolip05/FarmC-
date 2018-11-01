using System;
using System.Collections.Generic;
using System.Text;

namespace Farm01.animals
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;
        protected Mammal(string animalName, string animalType, double animalWeight,string livingRegion) 
            : base(animalName, animalType, animalWeight)
          
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get => livingRegion; set => livingRegion = value; }

        public override string ToString()
        {
            return $"{base.AnimalType}[{base.AnimalName},{base.AnimalWeight},{this.LivingRegion},{base.FoodEaten}]";
        }
    }
}
