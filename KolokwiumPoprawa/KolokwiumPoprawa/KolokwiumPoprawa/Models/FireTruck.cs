using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.Models
{
    public class FireTruck
    {
        
        public int IdFireTruck { get; set; }
        public string OperationNumber { get; set; }
        public bool SpecialEquipment { get; set; }
    }
}
