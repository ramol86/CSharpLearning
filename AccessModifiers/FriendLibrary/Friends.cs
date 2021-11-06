using FamilyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendLibrary
{
  public  class Friends
    {
        public int OwnedRooms { get; set; }
        public int OwnedCars { get; set; }
        public int OwnedLibraries { get; set; }
        public int OwnedSwimmingPool { get; set; }
        public int OwnedWheelChairs { get; set; }
        public int OwnedGuestrooms { get; set; }
        public Friends()
        {
            var objGrandpa = new GrandfatherAssets();
            OwnedWheelChairs = 0; // Not available from GrandfatherAssets as it was private
            OwnedSwimmingPool = 0;// Not available from GrandfatherAssets as it was declared protected internal and this class is outside its FamilyLibrary
            OwnedRooms = 0; // Not available from GrandfatherAssets as it was private protected and Friends class is not inheriting from GrandfatherAssets
            OwnedLibraries = objGrandpa.Library; //Available as it is public 
            OwnedGuestrooms = 0; // Not available as it was declared internal and this class is outside of FamilyLibrary
            OwnedCars = 0; // Not available as it was declared protected and this class doesn't inherit from GrandfatherAssets 


        }
    }
}
