using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalendatPatience
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lstTimes.Items.Clear();

            switch (Calendar1.SelectedDate.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    lstTimes.Items.Add("7:30 am");
                    lstTimes.Items.Add("8:30 am");
                    lstTimes.Items.Add("9:00 am");
                    break;
                case DayOfWeek.Saturday:
                    lstTimes.Items.Add("7:30 am");
                    break;
                default:
                    lstTimes.Items.Add("7:30 am");
                    lstTimes.Items.Add("8:30 am");
                    lstTimes.Items.Add("9:00 am");
                    lstTimes.Items.Add("7:30 pm");
                    lstTimes.Items.Add("8:30 pm");
                    lstTimes.Items.Add("9:00 pm");
                    break;
            }
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsWeekend)
            {
                e.Day.IsSelectable = false; 
            }
            /*
            if (e.Day.Date.Day == 15 && e.Day.Date.Month == 3)
            {
                e.Cell.BackColor = System.Drawing.Color.Yellow;

                //oop label
                Label lbl = new Label();

                lbl.Text = "<br/> My Birthday";
                e.Cell.Controls.Add(lbl);
            }
            */

            if (e.Day.Date.Day == 04)
            {
                e.Cell.BackColor = System.Drawing.Color.Yellow;

                //oop label
                Label lbl = new Label();

                lbl.Text = "<br/> Monthsary";
                e.Cell.Controls.Add(lbl);
            }
        }
    }
}