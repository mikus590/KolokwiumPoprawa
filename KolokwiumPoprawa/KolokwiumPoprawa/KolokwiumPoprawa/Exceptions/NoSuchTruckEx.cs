using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawa.Exceptions
{
    public class NoSuchTruckEx : Exception
    {

        public NoSuchTruckEx()
        {

        }
        public NoSuchTruckEx(String warning) : base(warning)
        {


        }
    }
}
