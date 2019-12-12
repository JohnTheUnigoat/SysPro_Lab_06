using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPro_Lab_06
{
    class Hotel
    {
        private DateTime currentDate;
        public string CurrentDate
        {
            get
            {
                return currentDate.ToShortDateString();
            }
        }

        public string CurrentSeasonEnd
        {
            get
            {
                if (!IsOpen)
                    return "Currently not a season";

                return holidayPeriods.Last().EndDate.ToShortDateString();
            }
        }

        public bool IsOpen { get; private set; }

        public string Status
        {
            get
            {
                return IsOpen ? "Open" : "Closed";
            }
        }

        private static readonly List<Room> rooms;
        public ReadOnlyCollection<Room> Rooms { get; }

        private List<HolidayPeriod> holidayPeriods;
        public ReadOnlyCollection<HolidayPeriod> HolidayPeriods
        {
            get
            {
                return new ReadOnlyCollection<HolidayPeriod>(holidayPeriods);
            }
        }

        public int RoomsOccupied { get; private set; }

        //public object locker;

        static Hotel()
        {
            rooms = new List<Room>(Program.numberOfRooms);

            for(int i = 0; i < Program.numberOfRooms; i++)
            {
                int maxNUmberOfPeople = Program.rand.Next(1, 4);

                double pricePerDay;

                switch (maxNUmberOfPeople)
                {
                    case 1:
                        pricePerDay = Program.rand.Next(3, 8) * 10;
                        break;
                    case 2:
                        pricePerDay = Program.rand.Next(5, 12) * 10;
                        break;
                    case 3:
                        pricePerDay = Program.rand.Next(7, 21) * 10;
                        break;
                    default:
                        pricePerDay = Program.rand.Next(7, 21) * 10;
                        break;
                }

                rooms.Add(new Room(maxNUmberOfPeople, pricePerDay));
            }
        }

        public Hotel(DateTime currentDate)
        {
            this.currentDate = currentDate;

            Rooms = new ReadOnlyCollection<Room>(rooms);

            RoomsOccupied = 0;

            holidayPeriods = new List<HolidayPeriod>();

            //locker = new object();
        }

        public void IncrementDate()
        {
            currentDate = currentDate.AddDays(1);

            if (!IsOpen)
                return;

            var currHolidayPeriod = holidayPeriods.Last();

            if (currentDate == currHolidayPeriod.EndDate)
                IsOpen = false;

            foreach (var client in currHolidayPeriod.Clients)
            {
                if (currentDate == client.DepartureDate)
                {
                    rooms[client.RoomIndex].IsOccupied = false;
                    RoomsOccupied--;
                }
            }
        }

        public bool TryAddClient(int daysOfStay, int numberOfPeople, double maxAcceptablePrice)
        {
            if (!IsOpen)
                return false;

            var currHolidayPeriod = holidayPeriods.Last();

            if (currentDate.AddDays(daysOfStay) >= currHolidayPeriod.EndDate)
                return false;

            int roomIndex = -1;

            for (int i = 0; i < Rooms.Count; i++)
            {
                if (Rooms[i].IsOccupied)
                    continue;

                if (Rooms[i].MaxNumberOfPeople < numberOfPeople)
                    continue;

                if (Rooms[i].PricePerDay > maxAcceptablePrice)
                    continue;

                roomIndex = i;

                if (Rooms[i].MaxNumberOfPeople == numberOfPeople)
                    break;
            }

            if (roomIndex == -1)
                return false;

            if (currHolidayPeriod.TryAddClient(currentDate, daysOfStay, roomIndex))
            {
                rooms[roomIndex].IsOccupied = true;
                RoomsOccupied++;
                return true;
            }
            else
                return false;
        }

        public void StartHolidayPeriod(int durationDays)
        {
            if (IsOpen)
            {
                holidayPeriods.Last().EndDate = currentDate.AddDays(durationDays);
                return;
            }

            holidayPeriods.Add(new HolidayPeriod(currentDate, durationDays));
            IsOpen = true;
        }
    }
}
