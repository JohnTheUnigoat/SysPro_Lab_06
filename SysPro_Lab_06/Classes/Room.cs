using System.IO;
using System.Xml;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System;

namespace SysPro_Lab_06
{

    [DataContract]
    public class Room
    {
        [DataMember(Name = "MaxPeople")]
        public int MaxNumberOfPeople { get; set; }

        [DataMember(Name = "Price")]
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
