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
        //create new instance of clsAppointments
        clsAppointments AnAppointment = new clsAppointments();
        //get the data from the session object
        AnAppointment = (clsAppointments)Session["AnAppointment"];
        //display the patient name for this entry
        Response.Write(AnAppointment.PatientFirstName);
    }
}