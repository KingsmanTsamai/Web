using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Web.ServiceReference1;

namespace Web
{
    public partial class Register : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
           // Response.Redirect("Home.aspx");

        }

        protected void BtbVolunteer_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] == null)
            {


                var book = sr.registerVolunteer(namez.Value, srname.Value, emailz.Value);
                if (book.Equals(true))
                {

                    regMessage.Text = "now a Volunteer Now Hit the Home page";
                  
                }
                



            }
            else {
            }
        }
    }
}