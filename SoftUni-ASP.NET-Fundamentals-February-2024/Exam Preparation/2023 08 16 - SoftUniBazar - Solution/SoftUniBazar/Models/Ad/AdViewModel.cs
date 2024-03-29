﻿// only properties with only: int, string, decimal, double
using System.ComponentModel.DataAnnotations;
using SoftUniBazar.Models.Category;
using static SoftUniBazar.Data.DataConstants;
namespace SoftUniBazar.Models.Ad
{
    public class AdViewModel
    {
       
        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string CreatedOn { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public string Owner { get; set; } = null!;

        public int Id { get; set; }

    }

}
//copy "All","Profile" shape here:
//a.Name
//a.ImageUrl
//a.CreatedOn
//a.Category
//a.Description
//a.Price
//a.Owner
//a.Id



// copy Item description here:   and delete unused properties:
//    •	Has Id – a unique int, Primary Key
//    •	Has Name – a string with min length 5 and max length 25 (required)
//    •	Has Description – a string with min length 15 and max length 250 (required)
//    •	Has Price – a decimal (required)
//    •	Has Owner – an IdentityUser (required)
//    •	Has ImageUrl – a string (required)
//    •	Has CreatedOn – a DateTime with format "yyyy-MM-dd H:mm" (required) (the DateTime format is recommended, if you are having troubles with this one, you are free to use another one)
//    •	Has Category – a Category (required)
