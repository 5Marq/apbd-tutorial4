namespace Klinika.Animals;

public static class Configuartion
{
    public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/api/v1/animals", () =>
        {
            return Results.Ok("All animals");
        });
        } 
        
    }
