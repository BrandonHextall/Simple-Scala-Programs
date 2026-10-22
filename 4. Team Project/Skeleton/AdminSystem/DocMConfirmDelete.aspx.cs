using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 doctorId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the doctor to be deleted from the session object
        doctorId = Convert.ToInt32(Session["dId"]);
    }

    protected void YesButton_Click(object sender, EventArgs e)
    {
        // createa new instance of the doctor collection class
        clsDoctorCollection doctorCollection = new clsDoctorCollection();
        // find the record to delte 
        doctorCollection.thisDoctor.Find(doctorId);
        // delete the record
        doctorCollection.Delete();
        // redirect to main page
        Response.Redirect("DMList.aspx");
    }

    protected void NoButton_Click(object sender, EventArgs e)
    {
        // redirect back to main page
        Response.Redirect("DocMList.aspx");
    }
}