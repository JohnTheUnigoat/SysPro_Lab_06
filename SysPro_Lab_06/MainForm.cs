using System;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

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

            dgvRooms.DataBindings.Add("DataSource", bs, "Rooms");

            trbDaycycleSpeed.ValueChanged += DaycycleSpeedChanged;

            btStart.Click += btStartClick;

            btViewLogs.Click += BtViewLogsClick;

            delay = 5000 / trbDaycycleSpeed.Value;
            tmr.Interval = delay;
            tmr.Tick += tmrTick;
            tmr.Start();

            generateClients = new Thread(GenerateClients);
            generateClients.IsBackground = true;
            generateClients.Name = "Generate clients";
            generateClients.Start();
        }

        private void BtViewLogsClick(object sender, EventArgs e)
        {
            int prevDaycycleSpeed = trbDaycycleSpeed.Value;

            trbDaycycleSpeed.Value = 0;

            (new LogView(hotel)).ShowDialog();

            trbDaycycleSpeed.Value = prevDaycycleSpeed;
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
                delay = 0;
                tmr.Stop();
                return;
            }

            if (!tmr.Enabled)
            {
                tmr.Start();
                generateClients.Interrupt();
            }

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

                // If daycycle speed was set to 0, go to sleep
                if (delayMultiplier == 0)
                    try
                    {
                        Thread.Sleep(Timeout.Infinite);
                    }
                    catch (ThreadInterruptedException)
                    {
                        // Wake sleeping thread when daycycle continues
                    }
                else
                    Thread.Sleep(Program.rand.Next(1, 5) * delayMultiplier);

                lock (locker)
                {
                    if (!hotel.IsOpen)
                        continue;

                    int holidayDuration = hotel.HolidayPeriods.Last().Duration;

                    int daysOfStay = Program.rand.Next(2, 15 < holidayDuration ? 15 : holidayDuration);

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
            }
        }
    }
}
