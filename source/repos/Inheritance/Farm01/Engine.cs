using Farm01.animals;
using Farm01.Factoris;
using Farm01.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farm01
{
   public class Engine
    {
        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                AnimalFactory animalFactory = new AnimalFactory();
                FoodFactory foodFactory = new FoodFactory();
                string[] animalTokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string[] foodTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Animal animal = animalFactory.GetAnimal(animalTokens);
                Food food = foodFactory.GetFood(foodTokens);
                animal.MakeSound();
                try
                {
                    animal.EatFood(food);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(animal);
                input = Console.ReadLine();

            }
            
        }
    }
}
