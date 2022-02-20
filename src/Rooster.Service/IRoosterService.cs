
using Rooster.Models;

namespace Rooster.Service;

public interface IRoosterService
{
    Task<IEnumerable<RoosterModel>> GetRoosters();
}