namespace ContosoPizza.Models;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;


public class Topping
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    public decimal Calories { get; set; }

    [JsonIgnore]
    public ICollection<Pizza>? Pizzas { get; set; }
}