using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be processed
    Int32 AppointmentNumber;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the appointment to be processed
        AppointmentNumber = Convert.ToInt32(Session["AppointmentNumber"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            System.Diagnostics.Debug.WriteLine("AppNum: " + AppointmentNumber);
            //if we are not adding a new record
            if (AppointmentNumber != -1)
            {
                //display the current data for the record
                DisplayAppointments();
            }
        }
    }

    void DisplayAppointments()
    {
        //create an instance of the appointment book
        clsAppointments AnAppointment = new clsAppointments();
        //find the record to update
        AnAppointment.Find(AppointmentNumber);
        //display the data for this record
        txtAppointmentNumber.Text = AnAppointment.AppointmentNumber.ToString();
        txtFirstName.Text = AnAppointment.PatientFirstName;
        txtLastName.Text = AnAppointment.PatientLastName;
        calAppointmentDate.SelectedDate = AnAppointment.DateOfAppointment;
        txtAppointmentHour.SelectedValue = AnAppointment.TimeOfAppointment.Hours.ToString() + ":00:00";
        txtAppointmentMinute.SelectedValue = AnAppointment.TimeOfAppointment.Minutes.ToString();
        txtNotes.Text = AnAppointment.Notes;
        chkEmergency.Checked = AnAppointment.EmergencyAppointment;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAppointments
        clsAppointments AnAppointment = new clsAppointments();
        //(temporarily) set Doctor ID
        AnAppointment.DoctorID = 1;
        //capture the patient first name
        AnAppointment.PatientFirstName = txtFirstName.Text;
        //capture the patient last name
        AnAppointment.PatientLastName = txtLastName.Text;
        //capture the time of appointment
        AnAppointment.TimeOfAppointment = new TimeSpan(Convert.ToInt32(txtAppointmentHour.SelectedValue.Split(':')[0]), Convert.ToInt32(txtAppointmentMinute.SelectedValue) , 0);
        //capture the date of appointment
        AnAppointment.DateOfAppointment = Convert.ToDateTime(calAppointmentDate.SelectedDate).Add(AnAppointment.TimeOfAppointment);
        //(temporarily) set floor number
        AnAppointment.FloorNumber = 1;
        //(temprarily) set room number
        AnAppointment.RoomNumber = 1;
        //capture appointment notes
        AnAppointment.Notes = txtNotes.Text;
        //capture emergency 
        AnAppointment.EmergencyAppointment = chkEmergency.Checked;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnAppointment.Valid(AnAppointment.PatientFirstName, AnAppointment.PatientLastName, AnAppointment.DateOfAppointment.ToString(), AnAppointment.TimeOfAppointment.ToString(), "1", "1", AnAppointment.Notes, AnAppointment.EmergencyAppointment.ToString());
        //System.Diagnostics.Debug.WriteLine("Error: ");
        //if the data is valid
        if (Error == "")
        {
            //create an instance of the appointment collection
            clsAppointmentsCollection AppointmentsList = new clsAppointmentsCollection();
            //if this is a new record i.e. AppointmentNumber = -1 then add the data
            if (AppointmentNumber == -1)
            {
                //set ThisAppointment to the appointment to be added
                AppointmentsList.ThisAppointment = AnAppointment;
                //add the appointment
                AppointmentsList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                AppointmentsList.ThisAppointment.Find(AppointmentNumber);
                //set ThisAppointment to the appointment to be updated
                AppointmentsList.ThisAppointment = AnAppointment;
                //update the record
                AppointmentsList.Update();
            }
            System.Diagnostics.Debug.WriteLine("Redirected");
            //navigate to view page
            Response.Redirect("AppMList.aspx");
        } else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsAppointments AnAppointment = new clsAppointments();
        //variable to store the primary key
        Int32 AppointmentNumber;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        AppointmentNumber = Convert.ToInt32(txtAppointmentNumber.Text);
        //find the record
        Found = AnAppointment.Find(AppointmentNumber);
        //if found
        if (Found == true)
        {
            //create connection to patient DB
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the patient name
            DB.AddParameter("@FirstName", AnAppointment.PatientFirstName);
            DB.AddParameter("@LastName", AnAppointment.PatientLastName);
            //execute the stored procedure to find the patient name
            DB.Execute("sproc_tblAppointments_GetPatientByName");
            //display the values of the properties in the form
            txtFirstName.Text = Convert.ToString(DB.DataTable.Rows[0]["PName"]).Split(' ')[0];
            txtLastName.Text = Convert.ToString(DB.DataTable.Rows[0]["PName"]).Split(' ')[1];
            calAppointmentDate.SelectedDate = AnAppointment.DateOfAppointment.Date;
            System.Diagnostics.Debug.WriteLine(txtAppointmentHour.SelectedValue);
            txtAppointmentHour.SelectedValue = AnAppointment.TimeOfAppointment.Hours.ToString() + ":00:00";
        txtAppointmentMinute.SelectedValue = AnAppointment.TimeOfAppointment.Minutes.ToString();
            txtNotes.Text = AnAppointment.Notes;
            chkEmergency.Checked = AnAppointment.EmergencyAppointment;
        }
    }
}