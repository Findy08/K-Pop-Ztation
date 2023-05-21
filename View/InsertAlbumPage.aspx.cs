using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation_GroupB.View
{
    public partial class InsertAlbumPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["customer"] != null)
                {
                    Customer c = (Customer)Session["customer"];
                    // cuma bisa diakses admin
                    if (!c.CustomerRole.Equals("A"))
                    {
                        Response.Redirect("~/View/ErrorPage.aspx");
                    }
                }
            }
        }

        protected void insertAlbumBtn_Click(object sender, EventArgs e)
        {

        }
    }
}