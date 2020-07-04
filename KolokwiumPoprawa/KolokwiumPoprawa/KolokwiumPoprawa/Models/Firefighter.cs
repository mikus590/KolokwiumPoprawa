using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.Models
{
    public class FireFighter
    {
        
        public int IdFireFighter { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
