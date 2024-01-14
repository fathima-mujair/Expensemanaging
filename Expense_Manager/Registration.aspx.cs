using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Expense_Manager
{
    public partial class Registration : System.Web.UI.Page
    {
        Registrationclass objbll = new Registrationclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = objbll.Fn_insert(TextBox1.Text,TextBox2.Text, TextBox3.Text);
            if (i != 0)
                Label6.Text = "inserted";

        }
    }
}