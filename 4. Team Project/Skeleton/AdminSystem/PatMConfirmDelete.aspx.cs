using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    int PatientId;
    protected void Page_Load(object sender, EventArgs e)
    {
        PatientId = Convert.ToInt32(Session["PatientId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //new cls collection instance
        clsPatientCollection aPatientList = new clsPatientCollection();
        //find record
        aPatientList.ThisPatient.Find(PatientId);
        //delete record
        aPatientList.Delete();
        //redirect back to the main page
        Response.Redirect("PatMList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("PatMList.aspx");
    }
}