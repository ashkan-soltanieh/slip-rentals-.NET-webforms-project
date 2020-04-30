﻿using CPRG214.Marina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214.Marina.App.Secure
{
    public partial class Lease : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int customer = (int)Session["CustomerID"];
            var leaseForACustomer = LeaseManager.GetAllLease(customer);
            gvLeases.DataSource = leaseForACustomer;
            DataBind();
        }
    }
}
