using System.Collections.Generic;
using RecipeBox.Models;


namespace RecipeBox.ViewModels
{
  public class RecipeRatingViewModel
  {
    public IEnumerable<Recipe> Recipes { get; set; } //public Recipe Recipes { get; set; }
    public IEnumerable<Rating> Ratings { get; set; }
  }
}