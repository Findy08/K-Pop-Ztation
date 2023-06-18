using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation_GroupB.View
{
    public partial class NavBar : System.Web.UI.MasterPage
    {
        public String role = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer cust = (Customer)Session["customer"];
            
            if(cust != null)
            {
                role = cust.CustomerRole;
                if (role.Equals("A"))
                {
                    currentRole.Text = "Admin";
                }
                else if (role.Equals("C"))
                {
                    currentRole.Text = "Customer";
                }
            }
            else
            {
                currentRole.Text = "Guest";
            }
        }

        

        protected void logoutpageLink_Click(object sender, EventArgs e)
        {
            // logout
            String[] cookies = Request.Cookies.AllKeys;
            foreach(String cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }
            Session.Remove("customer");
            Response.Redirect("~/View/LoginPage.aspx");
            // destroy all cookies variable
        }

        protected void homepageLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void transactionLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionReportPage.aspx");
        }

        protected void updateProfileLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/UpdateProfilePage.aspx");
        }

        protected void cartLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/CartPage.aspx");
        }

        protected void transactionLink2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionHistoryPage.aspx");
        }

        protected void loginpageLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void registerpageLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/RegisterPage.aspx");
        }
    }
}