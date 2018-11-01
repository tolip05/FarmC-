using System;
using System.Collections.Generic;
using System.Text;

namespace Farm01.animals
{
    public abstract class Felime : Mammal
    {
        protected Felime(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }
    }
}
