using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.Ratings = new HashSet<Rating>();
      this.Tags = new HashSet<RecipeTag>();
    }
    public int RecipeId { get; set; }
    public string RecipeName { get; set; }
    public string RecipeIngredients { get; set; } //list ??
    public string RecipeInstructions { get; set; } //list ??
    public virtual ApplicationUser User { get; set; }
    public ICollection<RecipeTag> Tags { get; set; }

    public ICollection<Rating> Ratings { get; set; }
  }
}