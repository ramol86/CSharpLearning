namespace FamilyLibrary
{
    public class CloseFriend
    {
        public int OwnedRooms { get; set; }
        public int OwnedCars { get; set; }
        public int OwnedLibraries { get; set; }
        public int OwnedSwimmingPool { get; set; }
        public int OwnedWheelChairs { get; set; }
        public int OwnedGuestrooms { get; set; }

        public CloseFriend()
        {
            var ObjGranpa = new GrandfatherAssets();
            OwnedCars = 0; // Not available from GrandfatherAssets as it was protected and Closefriend does not inherit
            OwnedGuestrooms = ObjGranpa.Guestrooms; //Available from GrandfatherAssets object as it was internal and closefriend is in FamilyLibrary
            OwnedLibraries = ObjGranpa.Library;// Available from GrandfatherAssets object as it is declared public
            OwnedRooms = 0; // Not available from GrandfatherAssets as it was protected  and Closefriend does not inherit from GrandfatherAssets
            OwnedSwimmingPool = ObjGranpa.SwimmingPool; //Available from GrandfatherAssets as it is declared protected internal, this class is in FamilyLibrary
            OwnedWheelChairs = 0; //Not available  as it was declared Private 
        }

    }


}
