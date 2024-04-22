using Microsoft.AspNetCore.Mvc;
using zadanie.DTO;
using zadanie.Models;
using zadanie.Services;

namespace zadanie.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalController : ControllerBase
{
    private readonly IAnimalService _animalService;

    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public IActionResult GetAnimals(string orderBy)
    {
        var animals = _animalService.GetAnimals(orderBy);
        return Ok(animals);
    }
    
    [HttpPost]
    public IActionResult CreateAnimal(AnimalDTO animal)
    {
        var affectedCount = _animalService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
    
    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, AnimalDTO animal)
    {
        var affectedCount = _animalService.UpdateAnimal(animal);
        return NoContent();
    }
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAninal(int id)
    {
        var affectedCount = _animalService.DeleteAnimal(id);
        return NoContent();
    }
}