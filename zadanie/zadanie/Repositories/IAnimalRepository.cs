using zadanie.DTO;
using zadanie.Models;

namespace zadanie.Repositories;

public interface IAnimalRepository
{
    IList<Animal> GetAnimals(AnimalOrderBy? orderBy);
    int CreateAnimal(AnimalDTO animal);
    int UpdateAnimal(AnimalDTO animal);
    int DeleteAnimal(int idAnimal);
}