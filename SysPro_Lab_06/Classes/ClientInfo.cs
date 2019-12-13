using System;

namespace SysPro_Lab_06
{
    class ClientInfo
    {
        public DateTime ArrivalDate { get; }
        public DateTime DepartureDate { get; }
        public int RoomIndex { get; }

        public ClientInfo(DateTime arrivalDate, int daysOfStay, int roomIndex)
        {
            ArrivalDate = arrivalDate;
            DepartureDate = arrivalDate.AddDays(daysOfStay);
            RoomIndex = roomIndex;
        }
    }
}
