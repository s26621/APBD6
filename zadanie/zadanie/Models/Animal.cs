using System.ComponentModel.DataAnnotations;

namespace zadanie.Models;

public class Animal
{
    [Required]
    public int IdAnimal { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    public string? Description { get; set; }
    
    [Required]
    public string Category { get; set; }
    
    [Required]
    public string Area { get; set; }

    public void Deconstruct(out int idAnimal, out string name, out string? description, out string category, out string area)
    {
        idAnimal = IdAnimal;
        name = Name;
        description = Description;
        category = Category;
        area = Area;
    }
}