using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SysPro_Lab_06
{
    [DataContract]
    class ClientInfo
    {
        [DataMember(Name = "Arrival")]
        public DateTime ArrivalDate { get; private set; }

        [DataMember (Name = "Departure")]
        public DateTime DepartureDate { get; private set; }

        [DataMember]
        public int RoomIndex { get; private set; }

        public ClientInfo(DateTime arrivalDate, int daysOfStay, int roomIndex)
        {
            ArrivalDate = arrivalDate;
            DepartureDate = arrivalDate.AddDays(daysOfStay - 1);
            RoomIndex = roomIndex;
        }

        public override string ToString()
        {
            return $"Room {RoomIndex, 2}: {ArrivalDate.ToShortDateString(), 10} - {DepartureDate.ToShortDateString(), 10}";
        }
    }
}
