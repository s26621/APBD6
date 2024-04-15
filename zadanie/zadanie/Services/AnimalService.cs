using zadanie.DTO;
using zadanie.Models;

namespace zadanie.Services;

internal class AnimalService : IAnimalService
{
    public IList<Animal> GetAnimals()
    {
        
    }

    public Animal? GetAnimal(int id)
    {
        throw new NotImplementedException();
    }

    public Animal AddAnimal(AnimalDTO animalDto)
    {
        throw new NotImplementedException();
    }

    public void DeleteAnimal(int id)
    {
        throw new NotImplementedException();
    }
}