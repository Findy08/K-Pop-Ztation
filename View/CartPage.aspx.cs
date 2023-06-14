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
    public partial class CartPage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Customer cust = new Customer();
                List<object> carts = new List<object>();
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
                carts = CartController.GetAllCartByCustomerId(cust.CustomerID);
                gvCart.DataSource = carts;
                gvCart.DataBind();
            }
        }

        protected void gvCart_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        

        protected void checkoutBtn_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
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
            CartController.CheckOut(cust.CustomerID);
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void gvCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Customer cust = new Customer();
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
            GridViewRow row = gvCart.Rows[e.RowIndex];
            int albumId = int.Parse(row.Cells[0].Text);
            
            CartController.RemoveOneCart(cust.CustomerID, albumId);
            
            Response.Redirect("~/View/CartPage.aspx");
            
        }
    }
}