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
        public String role = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Customer cust = (Customer)Session["customer"];

                if (cust != null)
                {
                    role = cust.CustomerRole;
                }

                int id = int.Parse(Request["ID"].ToString());
                Artist artist = ArtistController.GetArtistById(id);
                nameLb.Text = artist.ArtistName;
                String imgPath = artist.ArtistImage;
                if(!string.IsNullOrEmpty(imgPath))
                {
                    artistImg.ImageUrl = ResolveUrl(imgPath);
                }

                gvAlbum.DataSource = AlbumController.GetAlbumByArtistId(id);
                gvAlbum.DataBind();
                gvAlbum2.DataSource = AlbumController.GetAlbumByArtistId(id);
                gvAlbum2.DataBind();
            }
        }

        protected void gvAlbum_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvAlbum.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text);
            AlbumController.RemoveAlbum(id);
            int artistId = int.Parse(Request["ID"].ToString());
            Response.Redirect("~/View/ArtistDetailPage.aspx?ID=" + artistId);
        }

        protected void gvAlbum_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = gvAlbum.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text);
            Response.Redirect("~/View/UpdateAlbumPage.aspx?ID=" + id);
        }

        protected void gvAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int index = gvAlbum.SelectedIndex;
            int id = int.Parse(gvAlbum.Rows[index].Cells[0].Text);
            Response.Redirect("~/View/AlbumDetailPage.aspx?ID=" + id);
        }

        protected void insertAlbumLink_Click(object sender, EventArgs e)
        {
            int artistId = int.Parse(Request["ID"].ToString());
            Response.Redirect("~/View/InsertAlbumPage.aspx?ID="+artistId);
        }

        protected void gvAlbum2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gvAlbum2.SelectedIndex;
            int id = int.Parse(gvAlbum2.Rows[index].Cells[0].Text);
            Response.Redirect("~/View/AlbumDetailPage.aspx?ID=" + id);
        }
    }
}