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
    public partial class InsertAlbumPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                /*if (Session["customer"] != null)
                {
                    Customer c = (Customer)Session["customer"];
                    // cuma bisa diakses admin
                    if (!c.CustomerRole.Equals("A"))
                    {
                        Response.Redirect("~/View/ErrorPage.aspx");
                    }
                }*/
            }
        }

        protected void insertAlbumBtn_Click(object sender, EventArgs e)
        {
            int artistId = int.Parse(Request["ID"].ToString());

            String name = nameTb.Text;
            String desc = descriptionTb.Text;
            String priceText = priceTb.Text;
            String stockText = stockTb.Text;
            int price = 0, stock = 0;
            if (!priceText.Equals("")) price = int.Parse(priceText);
            if (!stockText.Equals("")) stock = int.Parse(stockText);

            String imgPath = "";
            int imgSize = 0;
            String imgExt = "";
            String response = "";
            if (imageUpload.HasFile)
            {
                imgPath = Server.MapPath("~/Assets/Albums/") + imageUpload.FileName;
                imgSize = imageUpload.PostedFile.ContentLength;
                imgExt = System.IO.Path.GetExtension(imageUpload.FileName);
            }
            response = AlbumController.validateAlbum(name, desc, price, stock, imgPath, imageUpload.HasFile, imgSize, imgExt);

            errorMsg.Text = response;


            if (response.Equals(""))
            {
                imageUpload.SaveAs(imgPath);
                AlbumController.doInsertAlbum(artistId, name, desc, price, stock, "~/Assets/Albums/" + imageUpload.FileName);
                Response.Redirect("~/View/ArtistDetailPage.aspx?ID=" + artistId);
            }
        }
    }
}