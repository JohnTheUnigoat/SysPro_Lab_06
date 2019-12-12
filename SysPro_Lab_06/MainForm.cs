using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Windows.Forms;

namespace SysPro_Lab_06
{
    public partial class MainForm : Form
    {
        Hotel hotel;

        BindingSource bs;

        object locker;

        public MainForm()
        {
            InitializeComponent();

            locker = new object();

            hotel = new Hotel(DateTime.Today);

            bs = new BindingSource();
            bs.DataSource = hotel;

            tbCurrentDate.DataBindings.Add("Text", bs, "CurrentDate");

            dgvRooms.DataBindings.Add("DataSource", bs, "Rooms");

            tmr.Interval = 5000 / trbDaycycleSpeed.Value;
            tmr.Tick += tmrTick;
            tmr.Start();

            trbDaycycleSpeed.ValueChanged += DaycycleSpeedChanged;
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

            tmr.Interval = 5000 / trbDaycycleSpeed.Value;
        }

        private void tmrTick(object sender, EventArgs e)
        {
            lock (locker)
            {
                hotel.IncrementDate();
                bs.ResetBindings(false);
                dgvRooms.Refresh();
            }
        }
    }
}
