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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTb.Text;
            string password = passwordTb.Text;
            bool isRemember = rememberCb.Checked;
            string response = CustomerController.validateLoginCustomer(email, password);
            errorMsg.Text = response;

            if(response.Equals(""))
            {
                Customer c = CustomerController.doLogin(email, password);
                Session["customer"] = c;
                
                if(isRemember)
                {
                    HttpCookie cookie = new HttpCookie("customer_cookie");
                    cookie.Value = c.CustomerID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(10);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("~/View/HomePage.aspx");
            }
            
        }
    }
}