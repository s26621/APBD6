using zadanie.DTO;
using zadanie.Models;
using zadanie.Repositories;

namespace zadanie.Services;

internal class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;

    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    public IList<Animal> GetAnimals(AnimalOrderBy? orderBy)
    {
        return _animalRepository.GetAnimals(orderBy);
    }

    public int CreateAnimal(AnimalDTO animal)
    {
        return _animalRepository.CreateAnimal(animal);
    }

    public int UpdateAnimal(AnimalDTO animal)
    {
        return _animalRepository.UpdateAnimal(animal);
    }

    public int DeleteAnimal(int id)
    {
        return _animalRepository.DeleteAnimal(id);
    }
}