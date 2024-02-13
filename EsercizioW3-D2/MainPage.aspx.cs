using System;
using System.Web;

namespace EsercizioW3_D2
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userData"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Write(Request.Cookies["userData"]["username"]);
            }
        }

        protected void Logout(object sender, EventArgs e)
        {
            HttpCookie userData = new HttpCookie("userData");
            userData.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(userData);
            Response.Redirect("Default.aspx");
        }
    }
}