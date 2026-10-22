using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 doctorId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the address to be processed
        doctorId = Convert.ToInt32(Session["dId"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (doctorId != -1)
            {
                // display the current data for the record
                DisplayDoctor();
            }
        }
    }

    void DisplayDoctor()
    {
        // create an instance of the doctors list
        clsDoctorCollection doctorCollection = new clsDoctorCollection();
        // find the record to update
        doctorCollection.thisDoctor.Find(doctorId);
        // display the data for the record
        tbFirstName.Text = doctorCollection.thisDoctor.dFirstName;
        tbLastName.Text = doctorCollection.thisDoctor.dLastName;
        tbAddress.Text = doctorCollection.thisDoctor.dAddress;
        tbEmail.Text = doctorCollection.thisDoctor.dEmail;
        tbPHoneNumber.Text = doctorCollection.thisDoctor.dPhoneNumber;
        cbAvailability.Checked = doctorCollection.thisDoctor.dAvailability;
        cDateAdded.SelectedDate = doctorCollection.thisDoctor.DDateAdded;
    }

    protected void btnOK_Click(object sender, EventArgs e) 
    {
        // create new instance of  clsDoctor
        clsDoc aDoc = new clsDoc();
        // capture first name
        String firstName = tbFirstName.Text;
        // capture lastName
        String lastName = tbLastName.Text;
        // capture address 
        String address = tbAddress.Text;
        // capture emaial
        String email = tbEmail.Text;
        // capture phone number
        String phoneNumber = tbPHoneNumber.Text;
        // capture active check box
        String available = cbAvailability.Text;
        // capture selcected date
        String dateAdded = cDateAdded.SelectedDate.ToString(); 
        // initialise error messages
        String error = "";
        error = aDoc.isValid(firstName, lastName, address, email, phoneNumber, dateAdded);

        if ( error == "" )
        {
            // capture doctor id
            aDoc.dId = doctorId;
            // capture the First Name
            aDoc.dFirstName = tbFirstName.Text;
            // capture the last Name
            aDoc.dLastName = tbLastName.Text;
            // capture the address
            aDoc.dAddress = tbAddress.Text;
            // capture the email
            aDoc.dEmail = tbEmail.Text;
            // capture the phone number
            aDoc.dPhoneNumber = tbPHoneNumber.Text;
            // capture the check box
            aDoc.dAvailability = cbAvailability.Checked;
            // capture date picker/ calender
            aDoc.DDateAdded = cDateAdded.SelectedDate;
            // create new instance of Doctor collection
            clsDoctorCollection doctorList = new clsDoctorCollection();

            if (doctorId == -1)
            {
                // set the this doctor property
                doctorList.thisDoctor = aDoc;
                // add the new record
                doctorList.Add();
            }
            else
            {
                // find the record to update
                doctorList.thisDoctor.Find(doctorId);
                // set the this doctor property
                doctorList.thisDoctor = aDoc;
                // update the record
                doctorList.Update();
            }

               
            // button handler when the button is clicked redirect back to page
            Response.Redirect("DocMList.aspx");
        }
        else
        {
            // display error message
            lbError.Text = error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // create an instance of the address class
        clsDoc aDoc = new clsDoc();
        // create a variable to store the primary key
        Int32 doctorId;
        Boolean found = false;
        // get the primary key entered by the user
        doctorId = Convert.ToInt32(tbDoctorId.Text);
        // find the record id
        found = aDoc.Find(doctorId);

        if (found == true)
        {
            // display the values of the properties in form
            lbError.Text = "";
            tbFirstName.Text = aDoc.dFirstName;
            tbLastName.Text = aDoc.dLastName;
            tbAddress.Text = aDoc.dAddress;
            tbEmail.Text = aDoc.dEmail;
            tbPHoneNumber.Text = aDoc.dPhoneNumber;
            cbAvailability.Checked = aDoc.dAvailability;
            cDateAdded.SelectedDate = aDoc.DDateAdded;
        }
        else
        {
            // set error message, and then reset all other boxes to differetn values.
            lbError.Text = "No doctor with an ID of: " + tbDoctorId.Text + " was found";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbPHoneNumber.Text = "";
            cbAvailability.Checked = false;
            cDateAdded.SelectedDate = DateTime.Now;
        }
    }

    protected void MainMenuButton_Click(object sender, EventArgs e)
    {
        // redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // redirect to Doc list
        Response.Redirect("DocMList.aspx");
    }

}