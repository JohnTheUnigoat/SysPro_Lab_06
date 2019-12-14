
namespace SysPro_Lab_06
{
    class Room
    {
        public int MaxNumberOfPeople { get; }
        public double PricePerDay { get; set; }
        public bool IsOccupied { get; set; }

        public Room(int maxNumberOfPeople, double pricePerDay)
        {
            MaxNumberOfPeople = maxNumberOfPeople;
            PricePerDay = pricePerDay;
            IsOccupied = false;
        }

        public Room(Room other)
        {
            MaxNumberOfPeople = other.MaxNumberOfPeople;
            PricePerDay = other.PricePerDay;
            IsOccupied = false;
        }
    }
}
