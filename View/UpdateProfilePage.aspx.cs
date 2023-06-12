using KpopZtation_GroupB.Controller;
using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation_GroupB.View
{
    public partial class UpdateProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void updateProfileBtn_Click(object sender, EventArgs e)
        {
            String name = nameTb.Text;
            String email = emailTb.Text;
            String gender = genderRb.SelectedValue;
            String address = addressTb.Text;
            String password = passwordTb.Text;
            Customer c = (Customer)Session["customer"];
            errorMsg.Text = CustomerController.doUpdateProfile(c.CustomerID, name, email, gender, address, password);
        }
    }
}