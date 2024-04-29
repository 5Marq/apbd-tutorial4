using Klinika.Animals;

namespace Klinika.Visits;

public static class Configuration
{
    public static List<Animal> animals = new List<Animal>();
    public static List<Visit> visits;

    public static void setAnimalListForVisit(List<Animal> _animals)
    {
        animals = _animals;

        visits = new List<Visit>
        {
            new Visit(1, new DateTime(2003, 5, 10), animals.FirstOrDefault(a => a.id == 1),
                "health diagnostics", 120),
            new Visit(2, new DateTime(2004, 5, 25), animals.FirstOrDefault(a => a.id == 2),
                "health diagnostics", 125),
            new Visit(3, new DateTime(2007, 9, 28), animals.FirstOrDefault(a => a.id == 3),
                "health diagnostics", 120),
            new Visit(4, new DateTime(2008, 9, 16), animals.FirstOrDefault(a => a.id == 3),
                "health diagnostics", 120)
        };
    }

    public static void RegisterEndpointsForVisits(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/v1/visits{id:int}", (int id) =>//wszystkie wizyty dla danego zwierzaka
            {
                if (visits.FirstOrDefault(a => a.animal.id == id) == null)
                {
                    return Results.NotFound($"Animal with id {id} was not found");
                }
                return TypedResults.Ok(visits.Where(v => v.animal.id == id).ToList());
            });
            endpoints.MapPut("/api/v1/visits/{id:int}", (Visit newVisit) =>
            {
                if (animals.FirstOrDefault(a => a.id == newVisit.animal.id) == null)
                {
                    return Results.NotFound($"Animal with id {newVisit.animal.id} was not found");
                }
                visits.Add(newVisit);
                return TypedResults.Ok();
            });
        } 
}