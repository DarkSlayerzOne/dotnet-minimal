

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

    private async Task<IResult> GetRooster(IRoosterService service)
    {
        var roosters = await service.GetRoosters();

        if(!roosters.Any())
        {
            return Results.Ok();
        }

        return Results.Ok(roosters);
    }

      private async Task<IResult> GetRoosterByID(IRoosterService service, int id)
    {
        var rooster = await service.GetRoosterByID(id);

        if(rooster is null)
        {
            return Results.NotFound();
        }

        return Results.Ok(rooster);
    }


}