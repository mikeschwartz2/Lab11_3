using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Registration
    {
        private static string[] drink = { "Coffee", "Tea", "Ice Coffee" };
        private static string[] location = { "Detroit", "Livonia", "Waterford", "Westland", "Canton" };

        public static string[] Drink { get => drink; }
        public static string[] Location { get => location; }
    }
}
