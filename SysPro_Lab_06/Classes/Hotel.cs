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
        public DateTime CurrentDate { get; private set; }

        public bool IsOpen { get; private set; }

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

        public object locker;

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
            CurrentDate = currentDate;

            Rooms = new ReadOnlyCollection<Room>(rooms);

            RoomsOccupied = 0;

            holidayPeriods = new List<HolidayPeriod>();

            locker = new object();
        }

        public void IncrementDate()
        {
            lock (locker)
            {
                CurrentDate = CurrentDate.AddDays(1);

                var currHolidayPeriod = holidayPeriods.Last();

                if (CurrentDate == currHolidayPeriod.EndDate)
                    IsOpen = false;

                foreach (var client in currHolidayPeriod.Clients)
                {
                    if (CurrentDate == client.DepartureDate)
                    {
                        rooms[client.RoomIndex].IsOccupied = false;
                        RoomsOccupied--;
                    }
                }
            }
        }

        public bool TryAddClient(int daysOfStay, int numberOfPeople, double maxAcceptablePrice)
        {
            lock (locker)
            {
                var currHolidayPeriod = holidayPeriods.Last();

                if (CurrentDate.AddDays(daysOfStay) >= currHolidayPeriod.EndDate)
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

                if (currHolidayPeriod.TryAddClient(CurrentDate, daysOfStay, roomIndex))
                {
                    rooms[roomIndex].IsOccupied = true;
                    RoomsOccupied++;
                    return true;
                }
                else
                    return false;
            }
        }

        public void StartHolidayPeriod(int durationDays)
        {
            lock (locker)
            {
                if (IsOpen)
                {
                    holidayPeriods.Last().EndDate = CurrentDate.AddDays(durationDays);
                    return;
                }

                holidayPeriods.Add(new HolidayPeriod(CurrentDate, durationDays));
                IsOpen = true;
            }
        }
    }
}
