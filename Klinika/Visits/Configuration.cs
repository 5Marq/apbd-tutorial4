namespace Klinika.Visits;

public static class Configuration
{
    public static void RegisterEndpointsForVisits(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/v1/visits", () =>
            {
                return TypedResults.Ok();
            });
            endpoints.MapGet("/api/v1/visits/{id:int}", (int id) =>
            {
                return TypedResults.Ok();
            });
            endpoints.MapPost("/api/v1/visits", (Visit newVisit) =>
            {
                
                return TypedResults.Ok();
            });
        } 
}