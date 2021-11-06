namespace FamilyLibrary
{
  public  class Relatives {
        public int OwnedRooms { get; set; }
        public int OwnedCars { get; set; }
        public int OwnedLibraries { get; set; }
        public int OwnedSwimmingPool { get; set; }
        public int OwnedWheelChairs { get; set; }
        public int OwnedGuestrooms { get; set; }


        public Relatives()
        {
            var objGranpa = new GrandfatherAssets();
            OwnedCars = 0;
            OwnedSwimmingPool = objGranpa.SwimmingPool; // availble as this was protected internal 
            OwnedGuestrooms = objGranpa.Guestrooms; // availble as this was  internal
            OwnedLibraries = objGranpa.Library;  //Available as it was public
            OwnedRooms = 0; // Not available from GrandfatherAssets as this was private protected
            OwnedWheelChairs = 0; // Not available from GrandfatherAssets as this was private 
        }
    }


}
