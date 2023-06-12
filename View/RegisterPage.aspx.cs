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
            String name = nameTb.Text;
            String email = emailTb.Text;
            String gender = genderRb.SelectedValue;
            String address = addressTb.Text;
            String password = passwordTb.Text;
            errorMsg.Text = CustomerController.validateRegisterCustomer(name, email, gender, address, password);
            if(errorMsg.Text == "")
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
            
        }
    }
}