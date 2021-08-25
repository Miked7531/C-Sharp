using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_028
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cupsRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(1.0, "cups");
        }

        protected void pintRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(2.0, "pints");
        }

        protected void quartsRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(4.0, "quarts");
        }

        protected void gallonRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(16.0, "gallons");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateCups(double measureToCupRatio, string measureName)
        {
            if (TextBox1.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(TextBox1.Text, out quantity))
                return;

            double cups = quantity * measureToCupRatio;



            resultLabel.Text = String.Format("{0:N2} {1} is equal to {2:N2} cups", quantity, measureName, cups);
        }
    }
}