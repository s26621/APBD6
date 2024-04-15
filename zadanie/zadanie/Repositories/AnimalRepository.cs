using System.Data.SqlClient;
using zadanie.Models;

namespace zadanie.Repositories;

public class AnimalRepository : IAnimalRepository
{
    private IConfiguration _configuration;

    public AnimalRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }


    public IList<Animal> GetAnimals(String orderBy = "name")
    {
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT IdAnimal, Name, Description, Category, Area FROM Animal ORDER BY @OrderBy";
        cmd.Parameters.AddWithValue("@OrderBy", orderBy);
        
        var dr = cmd.ExecuteReader();
        var animals = new List<Animal>();
        while (dr.Read())
        {
            var grade = new Animal
            {
                IdAnimal = (int)dr["IdAnimal"],
                Name = dr["Name"].ToString(),
                Description = dr["Description"].ToString(),
                Category = dr["Category"].ToString(),
                Area = dr["Area"].ToString(),
            };
            animals.Add(grade);
        }
        
        return animals;    }

    public int CreateAnimal(Animal animal)
    {
        (int id, string name, string description, string category, string area) = animal;
        
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "INSERT INTO Animal(IdAnimal, Name, Description, Category, Area) VALUES(@IdAnimal, @Name, @Description, @Category, @Area)";
        cmd.Parameters.AddWithValue("@IdAnimal", id);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Description", description);
        cmd.Parameters.AddWithValue("@Category", category);
        cmd.Parameters.AddWithValue("@Area", area);
        
        var affectedCount = cmd.ExecuteNonQuery();
        return affectedCount;    }

    public int UpdateAnimal(Animal animal)
    {
        (int id, string name, string description, string category, string area) = animal;
        
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "UPDATE Animal SET Name=@Name, Description = @Description, Category = @Category, Area = @Area WHERE IdAnimal = @IdAnimal";
        cmd.Parameters.AddWithValue("@IdAnimal", id);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Description", description);
        cmd.Parameters.AddWithValue("@Category", category);
        cmd.Parameters.AddWithValue("@Area", area);
        
        var affectedCount = cmd.ExecuteNonQuery();
        return affectedCount;
    }

    public int DeleteAnimal(int idAnimal)
    {
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "DELETE FROM Animal WHERE IdStudent = @IdAnimal";
        cmd.Parameters.AddWithValue("@IdAnimal", idAnimal);
        
        var affectedCount = cmd.ExecuteNonQuery();
        return affectedCount;    }
}