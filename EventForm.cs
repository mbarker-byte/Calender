using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MyCalendar
{
    public partial class EventForm : Form
    {
        String ConnectString = "server=localhost;user id=root;database=db_calendar;sslmode=none";
        IAppDomainSetup
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            DateBox.Text = DayControl.event_day + "/" + Form1.event_month + "/" + Form1.event_year;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EventSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConnectString);
            conn.Open();
            String sql = "INSERT INTO tbl_calendar(date,event)values(?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", DateBox);
            cmd.Parameters.AddWithValue("event", EventBox);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Event Submitted");
            cmd.Dispose();
            conn.Close();
        }
    }
}
