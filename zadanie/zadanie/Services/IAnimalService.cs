﻿using zadanie.DTO;
using zadanie.Models;

namespace zadanie.Services;

public interface IAnimalService
{
    IList<Animal> GetAnimals(string orderBy);
    
    int CreateAnimal(AnimalDTO animal);

    int UpdateAnimal(AnimalDTO animal);
    int DeleteAnimal(int id);
}