using zadanie.DTO;
using zadanie.Models;

namespace zadanie.Services;

public interface IAnimalService
{
    IList<Animal> GetAnimals();

    Animal? GetAnimal(int id);

    Animal AddAnimal(AnimalDTO animalDto);

    void DeleteAnimal(int id);
}