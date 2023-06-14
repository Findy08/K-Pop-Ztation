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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                /*guest bisa akses, jd dicomment*/
                /*if (Session["customer"] == null && Request.Cookies["customer_cookie"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }
                else
                {*/
                    Customer cust;
                    if(Session["customer"] == null)
                    {
                        int id = int.Parse(Request.Cookies["customer_cookie"].Value);
                        cust = CustomerController.GetCustomerById(id);
                        Session["customer"] = cust;
                    }
                    else
                    {
                        cust = (Customer)Session["customer"];
                    }
                    userNameLb.Text = cust.CustomerName;
                /*}*/
                gvArtist.DataSource = ArtistController.GetAllArtist();
                gvArtist.DataBind();
            }
        }

        protected void gvArtist_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = gvArtist.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text);
            Response.Redirect("~/View/UpdateArtistPage.aspx?ID=" + id);
        }

        protected void gvArtist_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvArtist.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text);
            ArtistController.RemoveArtist(id);
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void gvArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gvArtist.SelectedIndex;
            int id = int.Parse(gvArtist.Rows[index].Cells[0].Text);
            Response.Redirect("~/View/ArtistDetailPage.aspx?ID=" + id);
        }
    }
}