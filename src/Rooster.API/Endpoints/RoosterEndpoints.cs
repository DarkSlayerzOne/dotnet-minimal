

using Rooster.Data;
using Rooster.Service;

namespace Rooster.API;

public class RoosterEndpoint : IRoosterEndpoint
{
    public void Register(WebApplication webApp)
    {
        webApp.MapGet("/rooster", GetRooster);
    }

    private async Task<IResult> GetRooster(IRoosterService service)
    {
        var rooster = await service.GetRoosters();

        if(!rooster.Any())
        {
            return Results.Ok();
        }

        return Results.Ok(rooster);
    }


}