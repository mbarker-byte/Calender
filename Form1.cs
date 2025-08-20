using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalendar
{
    public partial class Form1 : Form
    {
        int month, year;
        public static int event_month, event_year; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showDays();
        }
        private void showDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthText = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthLabel.Text = monthText + " " + year;

            event_month = month;
            event_year = year;

            DateTime monthStart = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int weekday = Convert.ToInt32(monthStart.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < weekday; i++)
            {
                UserControl1 uc1 = new UserControl1();
                flowLayoutPanel1.Controls.Add(uc1);

            }
            for (int i = 1; i <= days; i++)
            {
                DayControl controlDays = new DayControl();
                controlDays.days(i);
                flowLayoutPanel1.Controls.Add(controlDays);
            }
           
        }

        private void prevb_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            month--;
            event_month = month;
            event_year = year;
            String monthText = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthLabel.Text = monthText + " " + year;
            DateTime now = DateTime.Now;
            DateTime monthStart = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int weekday = Convert.ToInt32(monthStart.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < weekday; i++)
            {
                UserControl1 uc1 = new UserControl1();
                flowLayoutPanel1.Controls.Add(uc1);

            }
            for (int i = 1; i <= days; i++)
            {
                DayControl controlDays = new DayControl();
                controlDays.days(i);
                flowLayoutPanel1.Controls.Add(controlDays);
            }
        }

        private void nextb_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            month++;
            event_month = month;
            event_year = year;
            String monthText = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthLabel.Text = monthText + " " + year;
            DateTime now = DateTime.Now;
            DateTime monthStart = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int weekday = Convert.ToInt32(monthStart.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < weekday; i++)
            {
                UserControl1 uc1 = new UserControl1();
                flowLayoutPanel1.Controls.Add(uc1);

            }
            for (int i = 1; i <= days; i++)
            {
                DayControl controlDays = new DayControl();
                controlDays.days(i);
                flowLayoutPanel1.Controls.Add(controlDays);
            }

        }
    }
}
