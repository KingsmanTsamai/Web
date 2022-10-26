using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.ServiceReference1;
namespace Web
{
    public partial class Home : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

            decimal feeDonate = sr.getTotalDonation();
            zaka.InnerHtml = "<span class='number'>" + String.Format("{0:0.00}", feeDonate) + "</span>";



            if (Request.QueryString["ID"] != null)
            {
                var donation = sr.checkIfdonated(email.Value, Convert.ToString(Request.QueryString["ID"]));
                email.Value = donation.DonerEmail;
                FullName.Value = donation.DonerName;
                AmountTodonate.Value = donation.DonerName;
                myList.Value = Convert.ToString(donation.SelectedCauseId);
            }

        }

        protected void BtnDonate_Click(object sender, EventArgs e)
        {

            if (Request.QueryString["ID"] == null)
            {
                var newClient = new Donation() { 
                 DonerName=FullName.Value,
                 DonerEmail=email.Value,
                 DonationAmout=Convert.ToDecimal(AmountTodonate.Value),
                
                };

                var adding = sr.addDonation(newClient);
                if (adding.Equals(true))
                {
                    message.Text = "Donated";

                }
                else
                {
                    message.Text = "not Donated";
                }

            }
            else
            {
                message.Text = "Cannot Donate";
            }


        }
    }
} 
