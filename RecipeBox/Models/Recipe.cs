using System.Collections.Generic;
using System;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.Tags = new HashSet<RecipeTag>();
    }
    public int RecipeId { get; set; }
    public string RecipeName { get; set; }
    public string RecipeIngredients { get; set; } //list ??
    public string RecipeInstructions { get; set; } //list ??

    public ICollection<RecipeTag> Tags { get; set; }


  }
}