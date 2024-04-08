namespace Klinika.Animals;

public static class Configuartion
{
    public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/api/animals", () =>
        {
            
        }  
    }
}