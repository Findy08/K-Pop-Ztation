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
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["customer"] != null || Request.Cookies["customer_cookie"] != null)
                {
                    Customer c = (Customer)Session["customer"];
                    // cuma bisa diakses customer
                    if (!c.CustomerRole.Equals("C"))
                    {
                        Response.Redirect("~/View/ErrorPage.aspx");
                    }

                }
                else
                {
                    Response.Redirect("~/View/ErrorPage.aspx");
                }

                Customer cust;
                if (Session["customer"] == null)
                {
                    int id = int.Parse(Request.Cookies["customer_cookie"].Value);
                    cust = CustomerController.GetCustomerById(id);
                    Session["customer"] = cust;
                }
                else
                {
                    cust = (Customer)Session["customer"];
                }
                gvTransaction.DataSource = TransactionController.GetTransactionByCustomer(cust.CustomerID);
                gvTransaction.DataBind();
            }
        }
    }
}