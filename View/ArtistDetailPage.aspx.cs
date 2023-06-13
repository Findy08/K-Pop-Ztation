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
    public partial class ArtistDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["ID"].ToString());
                Artist artist = ArtistController.GetArtistById(id);
                nameLb.Text = artist.ArtistName;
                String imgPath = artist.ArtistImage;
                if(!string.IsNullOrEmpty(imgPath))
                {
                    artistImg.ImageUrl = ResolveUrl(imgPath);
                }


            }
        }

        protected void gvAlbum_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvAlbum_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void insertAlbumLink_Click(object sender, EventArgs e)
        {
            int artistId = int.Parse(Request["ID"].ToString());
            Response.Redirect("~/View/InsertAlbumPage.aspx?ID="+artistId);
        }
    }
}