using System;
using System.Web;
using System.Web.UI;

namespace EsercizioW3_D2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userData"] != null)
            {
                Response.Redirect("MainPage.aspx");
            }
        }
        protected void Login(object sender, EventArgs e)
        {
            HttpCookie userData = new HttpCookie("userData");
            userData.Values["username"] = username.Value;
            userData.Values["password"] = password.Value;
            userData.Expires = DateTime.Now.AddDays(5);
            Response.Cookies.Add(userData);
            Response.Redirect("MainPage.aspx");
        }
    }
}