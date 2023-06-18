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
    public partial class AlbumDetailPage : System.Web.UI.Page
    {
        public String role = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Customer cust = (Customer)Session["customer"];

                if (cust != null)
                {
                    role = cust.CustomerRole;
                }

                int albumId = int.Parse(Request["ID"].ToString());
                Album album = AlbumController.GetAlbumById(albumId);
                nameLb.Text = album.AlbumName;
                String imgPath = album.AlbumImage;
                if (!string.IsNullOrEmpty(imgPath))
                {
                    albumImg.ImageUrl = ResolveUrl(imgPath);
                }
                descLb.Text = album.AlbumDescription;
                priceLb.Text = album.AlbumPrice.ToString();
                stockLb.Text = album.AlbumStock.ToString();
            }
        }

        protected void addCartBtn_Click(object sender, EventArgs e)
        {
            int albumId = int.Parse(Request["ID"].ToString());
            Album album = AlbumController.GetAlbumById(albumId);
            int albumStock = album.AlbumStock;

            String qtyText = qtyTb.Text;
            int qty = -1;
            if(string.IsNullOrEmpty(qtyText))
            {
                qty = -1;
            }
            else
            {
                qty = int.Parse(qtyText);
            }
            String response = CartController.validateCart(qty, albumStock);

            errorMsg.Text = response;

            if(response.Equals(""))
            {
                // add to cart
                // cari customer yg sedang log in
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
                
                CartController.AddItemToCart(cust, album, qty);
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
            }
        }
    }
}