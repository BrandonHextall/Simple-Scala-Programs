using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 AppointmentNumber;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the record to be deleted from the session object
        AppointmentNumber = Convert.ToInt32(Session["AppointmentNumber"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the Appointments collection
        clsAppointmentsCollection Appointments = new clsAppointmentsCollection();
        //find the record to delete
        Appointments.ThisAppointment.Find(AppointmentNumber);
        //delete the record
        Appointments.Delete();
        //redirect back to the main page
        Response.Redirect("AppMList.aspx"); 
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("AppMList.aspx");
    }
}