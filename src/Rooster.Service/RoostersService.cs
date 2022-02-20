using Rooster.Data;
using Rooster.Models;

namespace Rooster.Service;

public class RoosterService : IRoosterService
{
    private readonly IRoosterData _roosterData;

    public RoosterService(IRoosterData roosterData)
    {
        _roosterData = roosterData;
    }

    public async Task<IEnumerable<RoosterModel>> GetRoosters()
    {   
        var roosters = await _roosterData.ReadRosters();
        return roosters;
    }
}