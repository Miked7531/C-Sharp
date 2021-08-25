using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_013
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //comparisonTypeLabel.Text = "equal to";
            //comparisonTypeLabel.Text = "not equal to";
            comparisonTypeLabel.Text = "poop";
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //resultLabel.Text = (textBox1.Text == textBox2.Text) ? "Yes" : "No";

            //resultLabel.Text = (textBox1.Text != textBox2.Text) ? "Yes" : "No";

            //resultLabel.Text = (textBox1.Text > textBox2.Text) ? "Yes" : "No";

            //int first = int.Parse(textBox1.Text);
            //int second = int.Parse(textBox2.Text);
            //resultLabel.Text = (first > second) ? "Yes" : "No";
            //resultLabel.Text = (first < second) ? "Yes" : "No";
            //resultLabel.Text = (first <= second) ? "Yes" : "No";
            //resultLabel.Text = (first >= second) ? "Yes" : "No";

            //resultLabel.Text = (!CheckBox1.Checked) ? "No" : "Yes";

            if(CheckBox1.Checked && textBox1.Text == "Bob" && textBox2.Text == "Tabor")
            {
                resultLabel.Text = "Perfect trifecta!";
            }

            if(CheckBox1.Checked || textBox1.Text == "Bob" || textBox2.Text == "Tabor")
            {
                resultLabel.Text = "One out of three aint bad";
            }

        }
    }
}