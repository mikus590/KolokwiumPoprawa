using KolokwiumPoprawa.DTOs.Response;
using KolokwiumPoprawa.Exceptions;
using KolokwiumPoprawa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.Services
{
    public class SqlServerFIreFighterDbService : IFireFighterDbService
    {
        public readonly FireFightersDbContext _context;
        public SqlServerFIreFighterDbService(FireFightersDbContext context)
        {
            _context = context;
        }

        public List<GetListActionResponse> GetActions(int id)
        {

            List<GetListActionResponse> actions = new List<GetListActionResponse>();
            actions = (
                List<GetListActionResponse>)_context.FireFighter_Action.Join(
                    _context.Action, f => f.IdAction, a => a.IdAction,
                (f, a) => new { f_action = f, action = a }
                )
                .Where(e => e.f_action.IdFireFighter == id && e.action.EndTime != null)
                .Select(e => new GetListActionResponse { IdAction = e.action.IdAction, StartTime = e.action.StartTime, EndTime = e.action.EndTime })
                .ToList().OrderByDescending(e => e.EndTime);
            Console.Write(actions);
            return actions;
        }

        public void AssignTruck(AssignTruckRequest request)
        {
            if (_context.Action.Where(a => a.IdAction == request.IdAction).Count() == 0)
            {
                throw new NoSuchActionEx();
            }
            else
            {
                bool needEquipment = _context.Action.Where(a => a.IdAction == request.IdAction).Select(a => a.NeedSpecialEquipment).FirstOrDefault();
                if (_context.FireTruck.Where(f => f.IdFireTruck == request.IdFireTruck && f.SpecialEquipment == needEquipment).Count() == 0)
                {
                    throw new NoSuchTruckEx();
                }
            }

            using (var tra = _context.Database.BeginTransaction())
            {
                FireTruck_Action fireTruck_Action = new FireTruck_Action()
                {
                    IdFireTruck = request.IdFireTruck,
                    IdAction = request.IdAction,
                    AssignmentDate = DateTime.Now
                };

                _context.Add<FireTruck_Action>(fireTruck_Action);
                _context.SaveChanges();
                tra.Commit();
            }
        }


    }
}
