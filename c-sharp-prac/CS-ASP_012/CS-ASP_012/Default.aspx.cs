using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_012
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //resultLabel.Text = (TextBox1.Text == TextBox2.Text) ? "Yes" : "No";
            //resultLabel.Text = (oldCheckBox.Checked)
            //    ? "I'm teaching an old dog new tricks!"
            //    : "Young whippersnappers! Get off my lawn!";

            int result = (TextBox1.Text == TextBox2.Text) ? 100 : 50;

            resultLabel.Text = result.ToString();
        }
    }
}