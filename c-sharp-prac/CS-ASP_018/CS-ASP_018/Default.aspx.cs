using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_018
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = 500.ToString();

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate.AddDays(15) >= Calendar2.SelectedDate)
            {
                TimeSpan elapsedDays = Calendar1.SelectedDate.Subtract(Calendar2.SelectedDate);
                double userValue = double.Parse(TextBox1.Text);
                double days = elapsedDays.TotalDays;
                double sum = userValue * days + 100;
                resultLabel.Text = sum.ToString();
            }
            else
            {
                resultLabel.Text = "Error. You must choose a date at least 14 days apart.";
            }
        }
    }
}