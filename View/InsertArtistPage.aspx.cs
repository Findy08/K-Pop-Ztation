using KpopZtation_GroupB.Controller;
using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation_GroupB.View
{
    public partial class InsertArtistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
           /*if(!IsPostBack)
            {
                if(Session["customer"] != null || Request.Cookies["customer_cookie"] != null)
                {
                    Customer c = (Customer)Session["customer"];
                    // cuma bisa diakses admin
                    if (!c.CustomerRole.Equals("A"))
                    {
                        Response.Redirect("~/View/ErrorPage.aspx");
                    }
                    
                }
                
               
            } */
           
        }

        protected void insertArtistBtn_Click(object sender, EventArgs e)
        {
            String name = nameTb.Text;
            String imgPath = "";
            int imgSize = 0;
            String imgExt = "";
            String response = "";
            if(imageUpload.HasFile)
            {
                imgPath = Server.MapPath("~/Assets/Artists/") + imageUpload.FileName;
                imgSize = imageUpload.PostedFile.ContentLength;
                imgExt = System.IO.Path.GetExtension(imageUpload.FileName);
            }
            response = ArtistController.validateInsertArtist(name, imgPath, imageUpload.HasFile, imgSize, imgExt);
            
            errorMsg.Text = response;

            
            if (response.Equals(""))
            {
                imageUpload.SaveAs(imgPath);
                ArtistController.doInsertArtist(name, "~/Assets/Artists/" + imageUpload.FileName);
                
            }
        }
    }
}