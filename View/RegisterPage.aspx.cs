using KpopZtation_GroupB.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation_GroupB.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            CustomerController.doRegister(nameTb.Text, emailTb.Text, genderRb.SelectedItem.Value.ToString(), addressTb.Text, passwordTb.Text);
        }
    }
}