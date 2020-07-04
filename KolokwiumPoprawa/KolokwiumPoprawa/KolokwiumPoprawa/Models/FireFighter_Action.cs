using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.Models
{
    public class FireFighter_Action
    {
        
        public int IdFireFighter { get; set; }
        public int IdAction { get; set; }


        public virtual FireFighter IdFireFighterNavigation { get; set; }

        public virtual Action IdActionNavigation { get; set; }
    }
}
