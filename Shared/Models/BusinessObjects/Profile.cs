namespace BlazorApp.Shared.Models
{
    public class Profile 
    {
        public string ProfileName { get; set; }
        public int ProfileId { get; set; }
        public string Id { get; set; }
        public ExpansionPacks ExpansionPacks { get; set; }
        public GamePacks GamePacks { get; set; }
        public StuffPacks StuffPacks { get; set; }
        public Kits Kits { get; set; }
        public int Jokers { get; set; }
    }

    public class ExpansionPacks
    {
        public bool GetToWork { get; set; }
        public bool GetTogether { get; set; }
        public bool CityLiving { get; set; }
        public bool CatsAndDogs { get; set; }
        public bool Seasons { get; set; }
        public bool GetFamous { get; set; }
        public bool IslandLiving { get; set; }
        public bool DiscoverUniversity { get; set; }
        public bool EcoLifestyle { get; set; }
        public bool SnowyEscape { get; set; }
        public bool CottageLiving { get; set; }
        public bool HighSchoolYears { get; set; }
        public bool GrowingTogether { get; set; }
        public bool HorseRanch { get; set; }
    }

    public class GamePacks
    {
        public bool _OutdoorRetreat { get; set; }
        public bool _SpaDay { get; set; }
        public bool _DineOut { get; set; }
        public bool _Vampires { get; set; }
        public bool _Parenthood { get; set; }
        public bool _JungleAdventure { get; set; }
        public bool _Strangerville { get; set; }
        public bool _RealmOfMagic { get; set; }
        public bool _StarWars { get; set; }
        public bool _DreamHomeDecorator { get; set; }
        public bool _MyWeddingStories { get; set; }
        public bool _Werewolves { get; set; }
    }

    public class StuffPacks
    {
        public bool LuxuryPartyStuff { get; set; }
        public bool PerfectPatioStuff { get; set; }
        public bool CoolKitchenStuff { get; set; }
        public bool SpookyStuff { get; set; }
        public bool MovieHangoutStuff { get; set; }
        public bool RomanticGardenStuff { get; set; }
        public bool KidsRoomStuff { get; set; }
        public bool BackyardStuff { get; set; }
        public bool VintageGlamourStuff { get; set; }
        public bool BowlingNightStuff { get; set; }
        public bool FitnessStuff { get; set; }
        public bool ToddlerStuff { get; set; }
        public bool LaundryDayStuff { get; set; }
        public bool MyFirstPetStuff { get; set; }
        public bool MoschinoStuff { get; set; }
        public bool TinyLivingStuff { get; set; }
        public bool NiftyKnittingStuff { get; set; }
        public bool ParanormalStuff { get; set; }
    }

    public class Kits
    {
        public bool Throwback { get; set; }
        public bool CountryKitchen { get; set; }
        public bool BustTheDust { get; set; }
        public bool CourtyardOasis { get; set; }
    }
}