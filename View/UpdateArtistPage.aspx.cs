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
    public partial class UpdateArtistPage : System.Web.UI.Page
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

                int id = int.Parse(Request["ID"].ToString());
                Artist artist = ArtistController.GetArtistById(id);
                nameTb.Text = artist.ArtistName;
                
            }
        }

        protected void updateArtistBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["ID"].ToString());
            String name = nameTb.Text;
            String imgPath = "";
            int imgSize = 0;
            String imgExt = "";
            String response = "";
            if (imageUpload.HasFile)
            {
                imgPath = Server.MapPath("~/Assets/Artists/") + imageUpload.FileName;
                imgSize = imageUpload.PostedFile.ContentLength;
                imgExt = System.IO.Path.GetExtension(imageUpload.FileName);
            }
            response = ArtistController.validateArtist(name, imgPath, imageUpload.HasFile, imgSize, imgExt);

            errorMsg.Text = response;


            if (response.Equals(""))
            {
                imageUpload.SaveAs(imgPath);
                ArtistController.doUpdateArtist(id, name, "~/Assets/Artists/" + imageUpload.FileName);
            }
            Response.Redirect("~/View/HomePage.aspx");
        }
    }
}