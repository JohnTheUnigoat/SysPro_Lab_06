using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace SysPro_Lab_06
{
    [DataContract]
    class HolidayPeriod
    {
        [DataMember]
        public DateTime StartDate { get; private set; }

        [DataMember]
        public DateTime EndDate { get; set; }

        public int Duration
        {
            get
            {
                return (EndDate - StartDate).Days;
            }
        }

        [DataMember(Name = "Clients")]
        public List<ClientInfo> clients;
        public ReadOnlyCollection<ClientInfo> Clients
        {
            get
            {
                return new ReadOnlyCollection<ClientInfo>(clients);
            }
        }

        public HolidayPeriod(DateTime startDate, int durationDays)
        {
            StartDate = startDate;
            EndDate = startDate.AddDays(durationDays - 1);

            clients = new List<ClientInfo>();
        }

        public bool TryAddClient(DateTime arrivalDate, int daysOfStay, int roomIndex)
        {
            if(arrivalDate < StartDate || arrivalDate > EndDate)
                return false;

            if (arrivalDate.AddDays(daysOfStay - 1) > EndDate)
                return false;

            clients.Add(new ClientInfo(arrivalDate, daysOfStay, roomIndex));

            return true;
        }

        public override string ToString()
        {
            return $"{StartDate.ToShortDateString()} - {EndDate.ToShortDateString()}";
        }
    }
}
