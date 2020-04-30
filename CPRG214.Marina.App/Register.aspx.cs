using CPRG214.Marina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214.Marina.App
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //Pass credentials to authentication manager
            var customer = AuthenticationManager.Authenticate(txtFirstName.Text, txtLastName.Text, txtCity.Text, txtPhone.Text);

            //add customer id to the session
            Session.Add("CustomerID", customer.ID);

            //Redirect to Available Slips page
            
            FormsAuthentication.RedirectFromLoginPage(customer.FirstName + " " + customer.LastName, false);
            Response.Redirect("~/AvailableSlips.aspx");
        }
    }
}