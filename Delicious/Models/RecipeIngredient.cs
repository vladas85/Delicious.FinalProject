﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delicious.Models
{
    public class RecipeIngredient
    {
        public int Id { get; set; }

        public decimal Quantity { get; set; }
        public string UnitOfMeasure { get; set; }

        public virtual Recipe Recipe { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}