using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace page_load_and_page.ispostback
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            myTextBox.Text = "poop";
            Calendar1.SelectedDate = DateTime.Now.Date.AddDays(2);
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = myTextBox.Text + " - "
                + Calendar1.SelectedDate.ToShortDateString();
        }
    }
}