using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_13_pizza_challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double total;

            if (sizebutton1.Checked)
                total = 10.0;
            else if (sizebutton2.Checked)
                total = 13.0;
            else
                total = 16.0;

            if (deepButton.Checked)
                total += 2.0;

            total = (CheckBox1.Checked) ? total + 1.5 : total; //pepperoni
            total = (CheckBox2.Checked) ? total + .75 : total; // onions
            total = (CheckBox3.Checked) ? total + .5 : total; // green peppers
            total = (CheckBox4.Checked) ? total + .75 : total; // red peppers

            if (CheckBox5.Checked) // anchovies
            {
                total += 2.0;
            }
            if ((CheckBox1.Checked
                && CheckBox3.Checked
                && CheckBox5.Checked)
                || CheckBox1.Checked
                && CheckBox4.Checked
                && CheckBox2.Checked)
            {
                total -= 2.0;
            }

            resultLabel.Text = "$" + total.ToString();
        }
    }
}