using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_022
{
    public partial class Default : System.Web.UI.Page
    {
        double[,] priceGrid;

        protected void Page_Load(object sender, EventArgs e)
        {
            //double[,] priceGrid = new double[3, 3];
            // 0 - chicago
            // 1 - new york
            // 2 - london
            priceGrid = new double[3, 3];
            priceGrid[0, 1] = 350.0;
            priceGrid[0, 2] = 750.0;
            priceGrid[1, 0] = 400.0;
            priceGrid[1, 2] = 700d;
            priceGrid[2, 0] = 800d;
            priceGrid[2, 1] = 805d;

            //resultLabel.Text = priceGrid[1, 2].ToString(); 
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int fromCity;
            if (RadioButton1.Checked)
                fromCity = 0;
            else if (RadioButton2.Checked)
                fromCity = 1;
            else
                fromCity = 2;

            int toCity;
            if (RadioButton4.Checked) toCity = 0;
            else if (RadioButton5.Checked) toCity = 1;
            else toCity = 2;

            

            if (fromCity == toCity)
            {
                resultLabel.Text = "";
                return;
            }

            resultLabel.Text = priceGrid[fromCity, toCity].ToString();

        }
    }
}