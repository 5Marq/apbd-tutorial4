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
        endpoints.MapGet("/api/v1/animals", () => //wyswietlenie wszystkich zwierzat
        {
            return Results.Ok(animals);
        });
        endpoints.MapGet("/api/v1/animals/{id:int}", (int id) => //wyswietlenie po id
        {
            return TypedResults.Ok();
        });
        endpoints.MapPut("/api/v1/animals", (Animal newAnimal) => //dodanie nowego
        {
            
            return TypedResults.Ok();
        });
        endpoints.MapDelete("/api/v1/animals/{id:int}", (int id) => //usuniecie po id
        {
            
            return TypedResults.Ok();
        });
        endpoints.MapPut("/api/v1/animals/{id:int}", (int id) => //update po id
        {
            
            return TypedResults.Ok();
        });
    } 
}