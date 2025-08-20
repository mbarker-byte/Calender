using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalendar
{
    public partial class DayControl : UserControl
    {
        String ConnectString = "server=localhost;user id=root;database=db_calendar;sslmode=none";
        public static string event_day;
        public DayControl()
        {
            InitializeComponent();
        }

        private void DayControl_Load(object sender, EventArgs e)
        {

        }
        public void days(int numdays)
        {
            DayLabel.Text = numdays + "";
        }

        private void DayControl_Click(object sender, EventArgs e)
        {
            event_day = DayLabel.Text;
            timer1.Start();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        private void displayEvents()
        {
            MySqlConnection conn = new MySqlConnection(ConnectString);
            conn.Open();
            String sql = "SELECT * FROM tbl_calendar where date = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", DayLabel.Text + "/" + Form1.event_month + "/" + Form1.event_year);
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                ShowEvent.Text = reader["event"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvents();
        }
    }
}
