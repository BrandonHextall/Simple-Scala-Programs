using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    // variable to store the primary key with page level scope
    Int32 recordId;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the record to be processed
        recordId = Convert.ToInt32(Session["recordId"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (recordId != -1)
            {
                // display the current data for the record
                DisplayMedicalRecords();
            }
        }


    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsMedicalRecords AnMedicalRecords = new clsMedicalRecords();

        // capture user input as STRINGS
        string appNotes = txtAppNotes.Text;
        string date = txtDate.Text;
        string pendingApp = chkPending.Checked.ToString();
        string doctorID = txtDoctorID.Text;
        string patientID = txtPatientID.Text;
        string appID = txtAppID.Text;

        // call the Valid method
        string Error = AnMedicalRecords.Valid(appNotes, date, pendingApp, doctorID, patientID, appID);

        if (Error == "")
        {

            // capture the appNotes
            AnMedicalRecords.AppNotes = appNotes;
            // capture the data 
            AnMedicalRecords.Date = Convert.ToDateTime(date);
            // capture the pending app
            AnMedicalRecords.PendingApp = Convert.ToBoolean(pendingApp);
            // capture the doctorID
            AnMedicalRecords.DoctorID = Convert.ToInt32(doctorID);
            // capture the patientID
            AnMedicalRecords.patientId = Convert.ToInt32(patientID);
            // capture the appID
            AnMedicalRecords.AppID = Convert.ToInt32(appID);

            // create the collection 
            clsMedicalRecordCollection MedicalRecordList = new clsMedicalRecordCollection();

            // set the record 
            MedicalRecordList.ThisMedicalRecord = AnMedicalRecords;

            // add to the database 
            MedicalRecordList.Add();

            //store the object for the viewer page 
            Session["AnMedicalRecords"] = AnMedicalRecords;

            // redirect back to the list page
            Response.Redirect("MedRecList.aspx");

        }
        else
        {
            // show ALL validation errors
            lblError.Text = Error;
        }
    }



    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
   
        // create an instance of the class
        clsMedicalRecords AMedicalRecords = new clsMedicalRecords();

        // variable to store the primary key
        Int32 recordId;

        // get the record ID entered by the user
        recordId = Convert.ToInt32(txtRecordId.Text);

        // call the find method
        Boolean Found = AMedicalRecords.Find(recordId);

        // if found, display the values
        if (Found == true)
        {
            txtPatientID.Text = AMedicalRecords.patientId.ToString();
            txtDoctorID.Text = AMedicalRecords.DoctorID.ToString();
            txtDate.Text = AMedicalRecords.Date.ToString("yyyy-MM-dd");
            txtAppID.Text = AMedicalRecords.AppID.ToString();
            chkPending.Checked = AMedicalRecords.PendingApp;
            txtAppNotes.Text = AMedicalRecords.AppNotes;
        }
        else
        {
            // optional: show a message if not found
            lblError.Text = "Record not found.";
        }
    }

    void DisplayMedicalRecords()
    {
        // create an instance of the medical record collection
        clsMedicalRecordCollection MedicalRecords = new clsMedicalRecordCollection();
        // find the record to update
        MedicalRecords.ThisMedicalRecord.Find(recordId);
        // display the data for this record
        txtPatientID.Text = MedicalRecords.ThisMedicalRecord.patientId.ToString();
        txtDoctorID.Text = MedicalRecords.ThisMedicalRecord.DoctorID.ToString();
        txtDate.Text = MedicalRecords.ThisMedicalRecord.Date.ToString();
        txtAppID.Text = MedicalRecords.ThisMedicalRecord.AppID.ToString();
        chkPending.Checked = MedicalRecords.ThisMedicalRecord.PendingApp;
        txtAppNotes.Text = MedicalRecords.ThisMedicalRecord.AppNotes;
    }

}
