using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void subButton_Click(object sender, EventArgs e)
        {
            //string result = String.Format("Thank you, {0}, for your business", TextBox1.Text);

            int ss = int.Parse(TextBox3.Text);

            int phone = int.Parse(TextBox2.Text);

            int salary = int.Parse(TextBox4.Text);

            string result = String.Format("Thank you, {0}, for your business. Your Social Security number is: {1:000-00-0000} <br /> Your phone number is: {2:000-000-0000}<br /> Your salary is: {3:C}<br />Loan Date: {4:ddd -- d, M, yyyy}", TextBox1.Text, ss, phone, salary, Calendar1.SelectedDate);


            resultLabel.Text = result;
        }
    }
}