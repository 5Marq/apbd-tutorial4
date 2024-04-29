namespace Klinika.Animals;

public static class Configuartion
{

    private static List<Animal> animals = new List<Animal>
    {
        new Animal(1, "Burek", "Dog", 12.5, "Brown"),
        new Animal(2, "Mruczek", "Cat", 4.5, "Black"),
        new Animal(3, "Puszek", "Cat", 5.5, "White"),
    };
    
    public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/api/v1/animals/show_all", () => //wyswietlenie wszystkich zwierzat
        {
            if (animals.Count == 0)
            {
                return Results.NotFound("No animals found");
            }
            return Results.Ok(animals);
        });
        endpoints.MapGet("/api/v1/animals/show_from_id/{id:int}", (int id) => //wyswietlenie po id
        {
            if (animals.FirstOrDefault(a => a.id == id) == null)
            {
                return Results.NotFound($"Animal with id {id} was not found");
            }
            return TypedResults.Ok(animals.FirstOrDefault(a => a.id == id));
        });
        endpoints.MapPut("/api/v1/animals/add", (Animal newAnimal) => //dodanie nowego
        {
            animals.Add(newAnimal);
            return TypedResults.Ok();
        });
        endpoints.MapDelete("/api/v1/animals/delete/{id:int}", (int id) => //usuniecie po id
        {
            if (animals.FirstOrDefault(a => a.id == id) == null)
            {
                return Results.NotFound($"Animal with id {id} was not found");
            }

            animals.Remove(animals.FirstOrDefault(a => a.id == id));
            return TypedResults.Ok();
        });
        
        endpoints.MapPut("/api/v1/animals/update/{id:int}", (int id, Animal newAnimal) => //update po id
        {
            if (animals.FirstOrDefault(a => a.id == id) == null)
            {
                return Results.NotFound($"Animal with id {id} was not found");
            }
            var animal = animals.FirstOrDefault(a => a.id == id);
            animals.Remove(animal);
            animals.Add(newAnimal);
            return TypedResults.Ok();
        });
    } 
}