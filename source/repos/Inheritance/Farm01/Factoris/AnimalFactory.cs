using Farm01.animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farm01.Factoris
{
   public class AnimalFactory
    {
        public Animal GetAnimal(string[] tokens)
        {
            string type = tokens[0];
            string name = tokens[1];
            double wight = double.Parse(tokens[2]);
            string livingRegion = tokens[3];

            switch (type.ToLower())
            {
                case "cat":
                    string greed = tokens[4];
                    return new Cat(name,type,wight,livingRegion,greed);
                case "tiger":
                    return new Tiger(name, type, wight, livingRegion);
                case "mouse":
                    return new Mouse(name, type, wight, livingRegion);
                case "zebra":
                    return new Zebra(name, type, wight, livingRegion);
                default:
                    return null;
            }
        }
    }
}
