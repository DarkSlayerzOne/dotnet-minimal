using Rooster.Models;

namespace Rooster.Data;


public interface IRoosterData
{
    Task<bool> AddRooster(RoosterModel rooster); 

    Task<List<RoosterModel>> ReadRosters();

    Task<bool> UpdateRoosters(int id, RoosterModel rooster);

    Task<bool> DeleteRooster(int id);

}