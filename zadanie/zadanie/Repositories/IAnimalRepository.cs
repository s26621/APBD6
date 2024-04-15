using zadanie.Models;

namespace zadanie.Repositories;

public interface IAnimalRepository
{
    IList<Animal> GetAnimals(String orderBy);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int idAnimal);
}