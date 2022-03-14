using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspSecondAssignment
{
    public partial class SecondAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "Select", "Yamaha YZF R15 V4", "TVS RR310", "Ninja 300", "Pulsar RS 200", "KTM RC 390" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Pics/" + str + ".jpg";

        }
        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Yamaha YZF R15 V4")
            {
                TextBox1.Text = "Rs. 150000";
            }
            else if (DropDownList1.Text == "TVS RR310")
            {
                TextBox1.Text = "Rs. 220000";
            }
            else if (DropDownList1.Text == "Ninja 300")
            {
                TextBox1.Text = "Rs. 350000";
            }
            else if (DropDownList1.Text == "Pulsar RS 200")
            {
                TextBox1.Text = "Rs. 180000";
            }
            else  
            {
                TextBox1.Text = "Rs. 310000";
            }


        }
    }
}