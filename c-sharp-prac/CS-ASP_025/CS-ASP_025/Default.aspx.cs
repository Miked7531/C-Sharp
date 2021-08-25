using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_025
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            //nested and looks bad
            /*
            if (CheckBox1.Checked)
            {
                if (CheckBox2.Checked)
                {
                    if (CheckBox3.Checked)
                    {
                        resultLabel.Text = "They're all checked!";
                    }
                }
            }
            */

            // seperated using return and parenthesis.
            if (!CheckBox1.Checked) return;
            if (!CheckBox2.Checked) return;
            if (!CheckBox3.Checked) return;
            resultLabel.Text = "They're all checked!";

            // single line using &&
            if (CheckBox1.Checked &&
                CheckBox2.Checked &&
                CheckBox3.Checked)
                resultLabel.Text = "They're all checked!";
        }
    }
}