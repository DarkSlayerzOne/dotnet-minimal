using Rooster.Data;
using Rooster.Models;
using System.Linq;

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

    public async  Task<RoosterModel> GetRoosterByID(int id)
    {
         var rooster = await _roosterData.ReadRosters();
        return rooster.Single(x => x.ID == id);
    }


}