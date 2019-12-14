using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using System.Xml;

namespace SysPro_Lab_06
{
    [DataContract]
    class Hotel
    {
        [DataMember(Name = "CurrentDate")]
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

        [DataMember]
        public bool IsOpen { get; set; }

        public string Status
        {
            get
            {
                return IsOpen ? "Open" : "Closed";
            }
        }

        [DataMember(Name = "Rooms")]
        private List<Room> rooms;
        public ReadOnlyCollection<Room> Rooms
        {
            get
            {
                return new ReadOnlyCollection<Room>(rooms);
            }
        }

        [DataMember (Name = "holidayPeriods")]
        private List<HolidayPeriod> holidayPeriods;
        public ReadOnlyCollection<HolidayPeriod> HolidayPeriods
        {
            get
            {
                return new ReadOnlyCollection<HolidayPeriod>(holidayPeriods);
            }
        }

        [DataMember(Name = "RoomsOccupied")]
        private int roomsOccupied;
        public string RoomsOccupied
        {
            get
            {
                return roomsOccupied.ToString();
            }
        }

        public Hotel(DateTime currentDate)
        {
            this.currentDate = currentDate;

            rooms = new List<Room>(Program.numberOfRooms);

            for (int i = 0; i < Program.numberOfRooms; i++)
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

            roomsOccupied = 0;

            holidayPeriods = new List<HolidayPeriod>();
        }

        public void IncrementDate()
        {
            currentDate = currentDate.AddDays(1);

            if (!IsOpen)
                return;

            var currHolidayPeriod = holidayPeriods.Last();

            if (currentDate == currHolidayPeriod.EndDate)
            {
                IsOpen = false;
                Save(Program.saveFile);
            }

            foreach (var client in currHolidayPeriod.Clients)
            {
                if (currentDate == client.DepartureDate)
                {
                    rooms[client.RoomIndex].IsOccupied = false;
                    roomsOccupied--;
                }
            }
        }

        public bool TryAddClient(int daysOfStay, int numberOfPeople, double maxAcceptablePrice)
        {
            if (!IsOpen)
                return false;

            var currHolidayPeriod = holidayPeriods.Last();

            int roomIndex = -1;

            for (int i = 0; i < Rooms.Count; i++)
            {
                if (rooms[i].IsOccupied)
                    continue;

                if (rooms[i].MaxNumberOfPeople < numberOfPeople)
                    continue;

                if (rooms[i].PricePerDay > maxAcceptablePrice)
                    continue;

                roomIndex = i;

                if (rooms[i].MaxNumberOfPeople == numberOfPeople)
                    break;
            }

            if (roomIndex == -1)
                return false;

            if (currHolidayPeriod.TryAddClient(currentDate, daysOfStay, roomIndex))
            {
                rooms[roomIndex].IsOccupied = true;
                roomsOccupied++;
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

        public void Save(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Create))
            {
                var writer = JsonReaderWriterFactory.CreateJsonWriter(fs, Encoding.UTF8, true, true);
                var settings = new DataContractJsonSerializerSettings
                {
                    DateTimeFormat = new DateTimeFormat("MM/dd/yyyy")
                };
                var serializer = new DataContractJsonSerializer(typeof(Hotel), settings);
                serializer.WriteObject(writer, this);
                writer.Flush();
            }
        }

        public static Hotel Load(string fileName)
        {
            Hotel res;
            using (var fs = new FileStream(fileName, FileMode.Open))
            {
                //var writer = JsonReaderWriterFactory.CreateJsonWriter(fs, Encoding.UTF8, true, true);
                //var reader = JsonReaderWriterFactory.CreateJsonReader(fs,)
                var settings = new DataContractJsonSerializerSettings
                {
                    DateTimeFormat = new DateTimeFormat("MM/dd/yyyy")
                };
                var serializer = new DataContractJsonSerializer(typeof(Hotel), settings);
                res = (Hotel)serializer.ReadObject(fs);
            }

            var a = res.Rooms;

            return res;
        }
    }
}
