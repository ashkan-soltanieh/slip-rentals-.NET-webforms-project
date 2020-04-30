using CPRG214.Marina.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214.Marina.App
{
    public partial class AvailableSlips : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MarinaEntities db = new MarinaEntities();
                var docks = db.Docks.ToList();
                gvDocks.DataSource = docks;
                DataBind();

                DockManager mgr = new DockManager();
                ddlDocks.DataSource = mgr.GetAllDocks();
                ddlDocks.DataTextField = "Name";
                ddlDocks.DataValueField = "ID";
                DataBind();

                int selectedDockID = int.Parse(ddlDocks.SelectedValue);
                var slips = SlipManager.GetAvailableSlipsbyDockID(selectedDockID);
                
                gvSlips.DataSource = slips;
                gvSlips.DataBind();
            }
        }

        protected void ddlDocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedDockID = int.Parse(ddlDocks.SelectedValue);
            var slips = SlipManager.GetAvailableSlipsbyDockID(selectedDockID);
            gvSlips.DataSource = slips;
            gvSlips.DataBind();
        }

        protected void btnLeaseSelected_Click(object sender, EventArgs e)
        {
            
            if (Session["CustomerID"] != null)
            {
                int customer = (int)Session["CustomerID"];
                foreach (GridViewRow row in gvSlips.Rows)
                {
                    var chk = (CheckBox)(row.FindControl("cbSelectSlip"));
                    if (chk.Checked)
                    {
                        LeaseManager.MakeAndAddLease(int.Parse(row.Cells[1].Text), customer);
                    }
                }
                Response.Redirect("~/Secure/Lease");
            }
            else
            {
                Response.Redirect("~/Register");
            }
        }
    }
}