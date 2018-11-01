using Farm01.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farm01.Factoris
{
   public class FoodFactory
    {
        public Food GetFood(string[]tokens)
        {
            string type = tokens[0];
            int quantity = int.Parse(tokens[1]);

            switch (type.ToLower())
            {
                case "vegetable":
                    return new Vegetable(quantity);
                case "meat":
                    return new Meat(quantity);
                default:
                    return null;
            }
        }
    }
}
