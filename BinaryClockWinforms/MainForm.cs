using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryClockWinforms
{
    public partial class MainForm : Form
    {
        BinaryConverter binary;
        BinaryConverter Hours;
        BinaryConverter Minutes;
        BinaryConverter Seconds;

        public MainForm()
        {
            InitializeComponent();
            binary = new BinaryConverter(0);
            Hours = new BinaryConverter(DateTime.Now.Hour);
            Minutes = new BinaryConverter(DateTime.Now.Minute);
            Seconds = new BinaryConverter(DateTime.Now.Second);
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            updateHours();
            updateMinutes();
            updateSeconds();
        }

        private void updateHours()
        {
            Hours.SetDecimalNumber(DateTime.Now.Hour);

            if (Hours.ListBinaryNumber.Count > 4)
            {
                chkHour4.Checked = Hours.ListBinaryNumber[4];
            }
            else chkHour4.Checked = false;

            if (Hours.ListBinaryNumber.Count > 3)
            {
                chkHour3.Checked = Hours.ListBinaryNumber[3];
            }
            else chkHour3.Checked = false;

            if (Hours.ListBinaryNumber.Count > 2)
            {
                chkHour2.Checked = Hours.ListBinaryNumber[2];
            }
            else chkHour2.Checked = false;

            if (Hours.ListBinaryNumber.Count > 1)
            {
                chkHour1.Checked = Hours.ListBinaryNumber[1];
            }
            else chkHour1.Checked = false;

            if (Hours.ListBinaryNumber.Count > 0)
            {
                chkHour0.Checked = Hours.ListBinaryNumber[0];
            }
            else chkHour0.Checked = false;
        }

        private void updateMinutes()
        {
            Minutes.SetDecimalNumber(DateTime.Now.Minute);
            if (Minutes.ListBinaryNumber.Count > 5)
            {
                chkMin5.Checked = Minutes.ListBinaryNumber[5];
            }
            else chkMin5.Checked = false;

            if (Minutes.ListBinaryNumber.Count > 4)
            {
                chkMin4.Checked = Minutes.ListBinaryNumber[4];
            }
            else chkMin4.Checked = false;

            if (Minutes.ListBinaryNumber.Count > 3)
            {
                chkMin3.Checked = Minutes.ListBinaryNumber[3];
            }
            else chkMin3.Checked = false;

            if (Minutes.ListBinaryNumber.Count > 2)
            {
                chkMin2.Checked = Minutes.ListBinaryNumber[2];
            }
            else chkMin2.Checked = false;

            if (Minutes.ListBinaryNumber.Count > 1)
            {
                chkMin1.Checked = Minutes.ListBinaryNumber[1];
            }
            else chkMin1.Checked = false;

            if (Minutes.ListBinaryNumber.Count > 0)
            {
                chkMin0.Checked = Minutes.ListBinaryNumber[0];
            }
            else chkMin0.Checked = false;
        }

        private void updateSeconds()
        {
            Seconds.SetDecimalNumber(DateTime.Now.Second);
            if (Seconds.ListBinaryNumber.Count > 5)
            {
                chkSec5.Checked = Seconds.ListBinaryNumber[5];
            }
            else chkSec5.Checked = false;

            if (Seconds.ListBinaryNumber.Count > 4)
            {
                chkSec4.Checked = Seconds.ListBinaryNumber[4];
            }
            else chkSec4.Checked = false;

            if (Seconds.ListBinaryNumber.Count > 3)
            {
                chkSec3.Checked = Seconds.ListBinaryNumber[3];
            }
            else chkSec3.Checked = false;

            if (Seconds.ListBinaryNumber.Count > 2)
            {
                chkSec2.Checked = Seconds.ListBinaryNumber[2];
            }
            else chkSec2.Checked = false;

            if (Seconds.ListBinaryNumber.Count > 1)
            {
                chkSec1.Checked = Seconds.ListBinaryNumber[1];
            }
            else chkSec1.Checked = false;

            if (Seconds.ListBinaryNumber.Count > 0)
            {
                chkSec0.Checked = Seconds.ListBinaryNumber[0];
            }
            else chkSec0.Checked = false;
        }
    }
}
