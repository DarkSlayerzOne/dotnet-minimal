

using Rooster.Data;
using Rooster.Service;

namespace Rooster.API;

public class RoosterEndpoint : IRoosterEndpoint
{
    public void Register(WebApplication webApp)
    {
        webApp.MapGet("/rooster", GetRooster);
        webApp.MapGet("/rooster/{id:int}", GetRoosterByID);
    }

    private async Task<IResult> GetRooster(IRoosterService service, ILogger<RoosterEndpoint> logger)
    {
        var roosters = await service.GetRoosters();

        if(!roosters.Any())
        {
            logger.LogInformation("No content");
            return Results.Ok();
        }

        logger.LogInformation("Gathered result");
        return Results.Ok(roosters);
    }

      private async Task<IResult> GetRoosterByID(IRoosterService service, ILogger<RoosterEndpoint> logger, int id)
    {
        var rooster = await service.GetRoosterByID(id);

        if(rooster is null)
        {
            
            logger.LogInformation("No rooster found");
            return Results.NotFound();
        }

         logger.LogInformation("A rooster found");

        return Results.Ok(rooster);
    }


}