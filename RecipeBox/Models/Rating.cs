using System.Collections.Generic;
using System;



namespace RecipeBox.Models
{
  public class Rating
  {
    public Rating()
    {
      this.Users = new HashSet<ApplicationUser>();
    }
    public int RatingId { get; set; }
    public int UserId { get; set; }
    public int RecipeId { get; set; }
    public int RecipeRating { get; set; }
    public string Review { get; set; }
    public ICollection<ApplicationUser> Users { get; set; }
    public Recipe Recipe { get; set; }
  }
}