using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLibrary
{
    public class GrandfatherAssets
    {
        public int Library { get; set; }
        protected int Cars { get; set; }

        internal int Guestrooms { get; set; }
        private int WheelChair { get; set; }


        //Combinations
        protected internal int SwimmingPool { get; set; }
        private protected int Rooms { get; set; }

        //private internal int OtherAssets { get; set; } // Doesn't make sense 

        // public internal int OtherAssets { get; set; } // Doesn't make sense 

        public GrandfatherAssets()
        {
            Library = 1;
            Cars = 10;
            Guestrooms = 5;
            WheelChair = 1;
            Rooms = 20;
        }
        

    }


}
