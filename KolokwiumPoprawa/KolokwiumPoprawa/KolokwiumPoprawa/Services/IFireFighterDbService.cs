using KolokwiumPoprawa.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.Services
{
    public interface IFireFighterDbService
    {
         List<GetListActionResponse> GetActions(int id);
        void AssignTruck(AssignTruckRequest request);
    }
}
