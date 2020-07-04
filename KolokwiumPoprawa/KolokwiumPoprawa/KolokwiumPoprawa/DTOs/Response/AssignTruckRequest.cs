using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.DTOs.Response
{
    public class AssignTruckRequest
    {
        public int IdAction { get; set; }
        public int IdFireTruck { get; set; }
    }
}
