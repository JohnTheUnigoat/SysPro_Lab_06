using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPro_Lab_06
{
    public partial class LogView : Form
    {
        private List<Room> rooms;

        private IEnumerable<HolidayPeriod> holidayPeriods;

        private DateTime selectedDate;

        private BindingSource bsRooms;
        private BindingSource bsHolidayPeriods;

        internal LogView(Hotel hotel)
        {
            InitializeComponent();

            rooms = new List<Room>(hotel.Rooms.Count);
            foreach(var room in hotel.Rooms)
            {
                rooms.Add(new Room(room));
            }

            holidayPeriods = hotel.HolidayPeriods;

            bsRooms = new BindingSource();
            bsRooms.DataSource = rooms;

            dgvRooms.DataSource = bsRooms;

            bsHolidayPeriods = new BindingSource();
            bsHolidayPeriods.DataSource = holidayPeriods;

            cbHolidayPeriods.DataSource = bsHolidayPeriods;

            bsHolidayPeriods.PositionChanged += SelectedPeriodChanged;

            bsHolidayPeriods.Position = bsHolidayPeriods.Count - 1;
            SelectedPeriodChanged(this, new EventArgs());

            trbSelectedDate.ValueChanged += SelectedDateChanged;

            btDecrementDate.Click += BtDecrementDateClick;
            btIncrementDate.Click += BtIncrementDateClick;
        }

        private void BtIncrementDateClick(object sender, EventArgs e)
        {
            if (trbSelectedDate.Value < trbSelectedDate.Maximum)
                trbSelectedDate.Value++;
        }

        private void BtDecrementDateClick(object sender, EventArgs e)
        {
            if(trbSelectedDate.Value > trbSelectedDate.Minimum)
                trbSelectedDate.Value--;
        }

        private void SelectedPeriodChanged(object sender, EventArgs e)
        {
            DateTime start = (bsHolidayPeriods.Current as HolidayPeriod).StartDate;
            DateTime end = (bsHolidayPeriods.Current as HolidayPeriod).EndDate;

            lblStartDate.Text = start.ToShortDateString();
            lblEndDate.Text = end.ToShortDateString();

            trbSelectedDate.Maximum = (end - start).Days;
            trbSelectedDate.Value = 0;
            SelectedDateChanged(this, new EventArgs());
        }

        private void SelectedDateChanged(object sender, EventArgs e)
        {
            selectedDate = (bsHolidayPeriods.Current as HolidayPeriod).StartDate.AddDays(trbSelectedDate.Value);
            tbSelectedDate.Text = selectedDate.ToShortDateString();

            UpdateRooms();
        }

        private void UpdateRooms()
        {
            var period = bsHolidayPeriods.Current as HolidayPeriod;

            int roomsOccupied = 0;

            foreach (var date in DateSpan(period.StartDate, selectedDate))
            {
                foreach (var client in period.Clients)
                {
                    if (client.ArrivalDate == date)
                    {
                        rooms[client.RoomIndex].IsOccupied = true;
                        roomsOccupied++;
                    }
                    else if (client.DepartureDate == date)
                    {
                        rooms[client.RoomIndex].IsOccupied = false;
                        roomsOccupied--;
                    }
                }
            }

            tbRoomsOccupied.Text = roomsOccupied.ToString();

            bsHolidayPeriods.ResetBindings(false);
            dgvRooms.Refresh();
        }

        private IEnumerable<DateTime> DateSpan(DateTime from, DateTime to)
        {
            for (DateTime curr = from; curr <= to; curr = curr.AddDays(1))
            {
                yield return curr;
            }
        }
    }
}
