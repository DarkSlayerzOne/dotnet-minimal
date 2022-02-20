using Rooster.Models;

namespace Rooster.Data;


public class RoosterData : IRoosterData
{
     public Task<bool> AddRooster(RoosterModel rooster)
     {
         var task = new TaskCompletionSource<bool>();
          task.SetResult(false);
         return task.Task;
     }

    public Task<List<RoosterModel>> ReadRosters() 
    {
        var task = new TaskCompletionSource<List<RoosterModel>>();
         task.SetResult(new List<RoosterModel>{
             new RoosterModel(ID : 1, Name: "James", Gender: "Male", new Stats(Level: 99, Attack: 99, Defense: 99, Speed:99)),
             new RoosterModel(ID : 2, Name: "Maurice", Gender: "Male", new Stats(Level: 88, Attack: 88, Defense: 88, Speed:88)),
             new RoosterModel(ID : 3, Name: "Louise", Gender: "Female", new Stats(Level: 77, Attack: 77, Defense: 77, Speed:77)),
             new RoosterModel(ID : 4, Name: "Thor", Gender: "Male", new Stats(Level: 66, Attack: 66, Defense: 66, Speed:66)),
             new RoosterModel(ID : 5, Name: "Gina", Gender: "Female", new Stats(Level: 55, Attack: 55, Defense: 55, Speed:55)),
             new RoosterModel(ID : 6, Name: "Lorenz", Gender: "Male", new Stats(Level: 44, Attack: 44, Defense: 44, Speed:44)),
             new RoosterModel(ID : 7, Name: "Laura", Gender: "Female", new Stats(Level: 33, Attack: 33, Defense: 33, Speed:33)),
             new RoosterModel(ID : 8, Name: "Jenny", Gender: "Female", new Stats(Level: 22, Attack: 22, Defense: 22, Speed:22)),
             new RoosterModel(ID : 9, Name: "James", Gender: "Male", new Stats(Level: 11, Attack: 11, Defense: 11, Speed:11)),
         });
         return task.Task;
    }

    public Task<bool> UpdateRoosters(int id, RoosterModel rooster)
    {
        var task = new TaskCompletionSource<bool>();
        task.SetResult(false);
         return task.Task;
    }

    public Task<bool> DeleteRooster(int id) 
    {
         var task = new TaskCompletionSource<bool>();

         task.SetResult(false);
         return task.Task;
     }

    



}