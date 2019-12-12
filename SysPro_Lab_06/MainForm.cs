using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SysPro_Lab_06
{
    public partial class MainForm : Form
    {
        Hotel hotel;

        BindingSource bs;

        Thread generateClients;

        int delay;

        object locker;

        public MainForm()
        {
            InitializeComponent();

            locker = new object();

            hotel = new Hotel(DateTime.Today);

            bs = new BindingSource();
            bs.DataSource = hotel;

            tbCurrentDate.DataBindings.Add("Text", bs, "CurrentDate");
            tbHolidaySeasonEnd.DataBindings.Add("Text", bs, "CurrentSeasonEnd");
            tbRoomsOccupied.DataBindings.Add("Text", bs, "RoomsOccupied");
            tbHotelStatus.DataBindings.Add("Text", bs, "Status");

            //tbCurrentDate.Text = hotel.CurrentDate;
            //tbHolidaySeasonEnd.Text = hotel.CurrentSeasonEnd;
            //tbRoomsOccupied.Text = hotel.RoomsOccupied;
            //tbHotelStatus.Text = hotel.Status;

            dgvRooms.DataBindings.Add("DataSource", bs, "Rooms");

            trbDaycycleSpeed.ValueChanged += DaycycleSpeedChanged;

            btStart.Click += btStartClick;

            delay = 5000 / trbDaycycleSpeed.Value;
            tmr.Interval = delay;
            tmr.Tick += tmrTick;
            tmr.Start();

            generateClients = new Thread(GenerateClients);
            generateClients.IsBackground = true;
            generateClients.Name = "Generate clients";
            generateClients.Start();
        }

        private void btStartClick(object sender, EventArgs e)
        {
            lock (locker)
            {
                hotel.StartHolidayPeriod((int)numDuration.Value);
                bs.ResetBindings(false);
            }
        }

        private void DaycycleSpeedChanged(object sender, EventArgs e)
        {
            if (trbDaycycleSpeed.Value == 0)
            {
                tmr.Stop();
                return;
            }

            if (!tmr.Enabled)
                tmr.Start();
            lock (locker)
            {
                delay = 5000 / trbDaycycleSpeed.Value;
            }
            tmr.Interval = delay;
        }

        private void tmrTick(object sender, EventArgs e)
        {
            lock (locker)
            {
                hotel.IncrementDate();

                //tbCurrentDate.Text = hotel.CurrentDate;
                //tbHolidaySeasonEnd.Text = hotel.CurrentSeasonEnd;
                //tbHotelStatus.Text = hotel.Status;

                bs.ResetBindings(true);
                dgvRooms.Refresh();
            }
        }

        private void GenerateClients()
        {
            int delayMultiplier;
            while (true)
            {
                lock (locker)
                {
                    delayMultiplier = delay / 10;
                }
                Thread.Sleep(Program.rand.Next(1, 5) * delayMultiplier);
                lock (locker)
                {
                    if (!hotel.IsOpen)
                        continue;

                    int daysOfStay = Program.rand.Next(2, 30);

                    int numberOfPeople = Program.rand.Next(1, 4);

                    double maxPrice;

                    switch (numberOfPeople)
                    {
                        case 1:
                            maxPrice = Program.rand.Next(3, 8) * 10;
                            break;
                        case 2:
                            maxPrice = Program.rand.Next(5, 12) * 10;
                            break;
                        case 3:
                            maxPrice = Program.rand.Next(7, 21) * 10;
                            break;
                        default:
                            maxPrice = 0;
                            break;
                    }

                    hotel.TryAddClient(daysOfStay, numberOfPeople, maxPrice);
                }

                //Console.WriteLine(hotel.RoomsOccupied);
                //bs.ResetBindings(false);
            }
        }
    }
}
