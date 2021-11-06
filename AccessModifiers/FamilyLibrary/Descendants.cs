namespace FamilyLibrary
{
   public class Descendants : GrandfatherAssets {
        public int OwnedRooms { get; set; }
        public int OwnedCars { get; set; }
        public int OwnedLibraries { get; set; }
        public int OwnedSwimmingPool { get; set; }
        public int OwnedWheelChairs { get; set; }
        public int OwnedGuestrooms { get; set; }

        public Descendants()
        {
            OwnedCars = Cars; // protected in GrandfatherAssets class
            OwnedGuestrooms = Guestrooms; //internal in GrandfatherAssets Class
            OwnedLibraries = Library; //public in GrandfatherAssets Class
            OwnedRooms = Rooms;// private protected in GrandfatherAssets Class
            OwnedSwimmingPool = SwimmingPool;// protected internal in GrandfatherAssets Class
           // OwnedWheelChairs = WheelChairs; // Not allowed as GrandfatherAssets Class kept it private . So can be used only by GrandfatherAssets class

        }
    }

}
