using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //get data from session object
        clsPatient aPatient = (clsPatient)Session["aPatient"];
        //display the patient name for this entry
        Response.Write("Name: " + aPatient.PName);
        Response.Write("<br/>Email: " + aPatient.PEmail);
        Response.Write("<br/>DOB: " + aPatient.PDOB);
        Response.Write("<br/>Home Address" + aPatient.PHomeAdd);
        Response.Write("<br/>Main Doctor ID: " + aPatient.PMainDocId);
        Response.Write("<br/>Access Requirments: " + aPatient.PAccessReq);
    }
}