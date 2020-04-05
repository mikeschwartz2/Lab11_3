using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class UserReg
    {
        private string drink;
        private string location;

        [Required]
        public string Drink { get => drink; set => drink = value; }

        [DisplayName("Preferred Location")]
        [Required]
        public string Location { get => location; set => location = value; }
    }
}
