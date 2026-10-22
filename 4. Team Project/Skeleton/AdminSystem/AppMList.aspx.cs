using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayAppointments();
        }
    }
    void DisplayAppointments()
    {
        //create an instance of the Appointments collection
        clsAppointmentsCollection Appointments = new clsAppointmentsCollection();
        //set the data source to the list of Appointments in the collection
        lstAppointments.DataSource = Appointments.AppointmentsList;
        //set the name of the primary key
        lstAppointments.DataValueField = "AppointmentNumber";
        //set the data field to display
        lstAppointments.DataTextField = "DateOfAppointment";
        //bind the data to the list
        lstAppointments.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["AppointmentNumber"] = -1;
        //redirect to the data entry page
        Response.Redirect("AppMDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 AppointmentNumber;
        //if a record has been selected from the list
        if (lstAppointments.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            AppointmentNumber = Convert.ToInt32(lstAppointments.SelectedValue);
            //store the data in the session object
            Session["AppointmentNumber"] = AppointmentNumber;
            //redirect to the edit page
            Response.Redirect("AppMDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 AppointmentNumber;
        //if a record has been selected from the list
        if (lstAppointments.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            AppointmentNumber = Convert.ToInt32(lstAppointments.SelectedValue);
            //store the data in the session object
            Session["AppointmentNumber"] = AppointmentNumber;
            //redirect to the delete page
            Response.Redirect("AppMConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the appointment object
        clsAppointmentsCollection AnAppointment = new clsAppointmentsCollection();
        //retrieve the value of the date from the presentation layer
        AnAppointment.FilterByDate(txtFilter.Text);
        //set the data source to the list of appointments in the collection
        lstAppointments.DataSource = AnAppointment.AppointmentsList;
        //set the name of the field to display
        lstAppointments.DataTextField = "Date";
        //bind the data to the list
        lstAppointments.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the appointment object
        clsAppointmentsCollection AnAppointment = new clsAppointmentsCollection();
        //set an empty string
        AnAppointment.FilterByDate("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of appointments in the collection
        lstAppointments.DataSource = AnAppointment.AppointmentsList;
        //set the name of the primary key
        lstAppointments.DataValueField = "AppointmentNumber";
        //bind the data to the list
        lstAppointments.DataBind();
    }

    protected void btnStats_Click(object sender, EventArgs e)
    {
        //redirect to the data entry page
        Response.Redirect("AppMStatistics.aspx");
    }
}