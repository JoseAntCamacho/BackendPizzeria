﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using BackendPizzeria.Dtos;

namespace BackendPizzeria.Domain
{
    public class Pizza
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public byte[] Picture { get; set; }
               

        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Commentary> Commentaries { get; set; }

        public Pizza(string name, byte[] picture, ICollection<Ingredient> ingredients)
        {
            Name = name;
            Picture = picture;
            Ingredients = ingredients;
        }

        public decimal Price()
        {
            decimal profit = Decimal.Parse(ConfigurationManager.AppSettings["Profit"]);
            return this.Ingredients.Sum(c=>c.Price) + profit;
        }

        public DtoPizzaExit ConvertToDtoPizzaExit()
        {
            return new DtoPizzaExit(this.Name, this.Picture, this.Ingredients, this.Commentaries);
        }

    }
}