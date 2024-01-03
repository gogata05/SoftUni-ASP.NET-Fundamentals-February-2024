﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using Microsoft.AspNetCore.Identity;
using static SoftUniBazar.Data.DataConstants;
namespace SoftUniBazar.Data.Models
{
    public class Ad
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(AdNameMax)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(AdDescriptionMax)]
        public string Description { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }
		
		[Required]
        public string OwnerId { get; set; } = null!;

        [Required]
        public IdentityUser Owner { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;
		
		[Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

    }
}
//pk,fk,req,max,*

// Ad 
// Has Id – a unique integer, Primary Key 
// Has Name – a string with min length 5 and max length 25 (required) *
// Has Description – a string with min length 15 and max length 250 (required) *
// Has Price – a decimal (required) 
// Has OwnerId – a string (required) 
// Has Owner – an IdentityUser (required) 
// Has ImageUrl – a string (required) 
// Has CreatedOn – a DateTime with format "yyyy-MM-dd H:mm" (required) (the DateTime format is recommended, if you are having troubles with this one, you are free to use another one) 
// Has CategoryId – an integer, foreign key (required) 
// Has Category – a Category (required) 