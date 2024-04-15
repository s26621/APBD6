using Microsoft.AspNetCore.Mvc;
using zadanie.Services;

namespace zadanie.Controllers;

public class AnimalController : ControllerBase
{
    private readonly IAnimalService _animalService;

    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }
}