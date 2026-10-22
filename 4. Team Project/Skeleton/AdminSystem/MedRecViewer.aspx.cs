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

        // check if the session object exists
        if (Session["AnMedicalRecords"] == null)
        {
            // if it doesn't exist then redirect back to the list page
            Response.Redirect("MedRecList.aspx");
        }


        // retreave the object from the session object
        clsMedicalRecords AnMedicalRecords = (clsMedicalRecords)Session["AnMedicalRecords"];


       
      // display the data for this record
        
        Response.Write("Record ID: " + AnMedicalRecords.recordId + "<br />");
        Response.Write("Patient ID: " + AnMedicalRecords.patientId + "<br />");
        Response.Write("Doctor ID: " + AnMedicalRecords.DoctorID + "<br />");
        Response.Write("Date: " + AnMedicalRecords.Date + "<br />");
        Response.Write("Appointment ID: " + AnMedicalRecords.appID + "<br />");
        Response.Write("Pending Appointment: " + AnMedicalRecords.pendingApp + "<br />");
        Response.Write("Appointment Notes: " + AnMedicalRecords.appNotes);
    }
}