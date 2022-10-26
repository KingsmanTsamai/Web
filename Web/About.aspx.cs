using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.ServiceReference1;

namespace Web
{
    public partial class About : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

            string k = "";
            decimal answer = 0;
            decimal percent = 0;
            if (Request.QueryString["ID"] != null)
            {

                var idDo = Convert.ToInt32(Request.QueryString["ID"]);
                Cause cause=sr.getSingleItem(idDo);
                k += "<div class='col-md-6 col-lg-3'>:";
                k += "<div class='causes causes-2 text-center ftco-animate'>";
                k += "<a href ='#' class='img w-100' style='background-image: url(" + cause.CauseImg + ");'></a>";
                k += "<div class='text p-'>";
                k += "<h2><a href ='#' >" + cause.CauseName + "</a></h2>";
                k += "<p>" + cause.CauseDescription + "</p>";
                k += "<div class='goal mb-4'>";
                percent = (decimal)(Math.Round(cause.CuaseDonations / cause.CauseRequiredMoney) * 100);
                answer = cause.CauseRequiredMoney - cause.CuaseDonations;
                k += "<div><span>" + Math.Round(answer, 2) + "</span> to go</p>";
                k += "<div class='progress' style='height:20px'>";
                k += "<div class='progress -bar progress-bar-striped' style='width:70%' height:20px'>'95'%</div>";
                k += "</div>";
                k += "</div>";
                k += "<p>";
                k += "</div>";
                k += "</div>";
                k += "</div>";
                k += "</div>";
            }
            //else {
            //    Response.Redirect("Home.aspx");
            //}


        }
    }
}