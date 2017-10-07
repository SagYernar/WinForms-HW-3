using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_WF_3
{
    public partial class DayOfTheWeekForm : Form
    {
        public DayOfTheWeekForm()
        {
            InitializeComponent();
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            dayOfTheWeekLabel.Text = calendar.SelectionEnd.DayOfWeek.ToString();
        }
    }
}
