﻿using System;
using System.Collections.Generic;
using System.Text;
using Farm01.Foods;

namespace Farm01.animals
{
    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, string livingRegion) 
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void EatFood(Food food)
        {
            if ("Vegetable" == food.GetType().Name)
            {
                base.FoodEaten = food.Quantity;
            }
            else
            {
                throw new Exception("Zebra are not eating that type of food!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Zs");
        }
    }
}
