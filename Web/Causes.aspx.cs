using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.ServiceReference1;

namespace Web
{
    public partial class Causes : System.Web.UI.Page
    {
        Service1Client sr=new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            string display = "";
            decimal answer = 0;
            decimal percent = 0;
            dynamic populate = sr.getCauses();


            foreach (Cause p in populate) {


                display += "<div class='col-md-6 col-lg-3'>:";
                display += "<div class='causes causes-2 text-center ftco-animate'>";
                display += "<a href ='About.aspx?ID="+p.Id+"' class='img w-100' style='background-image: url("+p.CauseImg+");'></a>";
                display+="<div class='text p-'>";
                display += "<h2><a href ='About.aspx?ID="+p.Id+"' >" + p.CauseName+"</a></h2>";
               
                display += "<div class='goal mb-4'>";
                percent = (decimal)(Math.Round(p.CuaseDonations / p.CauseRequiredMoney) * 100);
                answer = p.CauseRequiredMoney - p.CuaseDonations;
                display +="<div><span>"+Math.Round(answer,2)+"</span> to go</p>";
                display += "<div class='progress' style='height:20px'>";
                display += "<div class='progress -bar progress-bar-striped' style='width:"+percent+" height:20px'>"+Math.Round(percent,2)+ "%</div>";
                display += "</div>";
                display += "</div>";
                display += "<p>";
                display += "</div>";
                display += "</div>";
                display += "</div>";
                display += "</div>";



            }

            CauseDiv.InnerHtml = display;
        }
    }
}