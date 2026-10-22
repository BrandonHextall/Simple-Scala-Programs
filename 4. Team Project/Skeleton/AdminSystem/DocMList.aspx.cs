using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {

            // update the list box
            DisplayDoctors();
        }
    }


    void DisplayDoctors()
    {
        // create an instance of the doctor collection 
        clsDoctorCollection doctors = new clsDoctorCollection();
        // query for display of multiple data fields
        var query = from doctor in doctors.doctorList
                    select new
                    {
                        doctorString = "Dr. " + doctor.dFirstName + " " + doctor.dLastName,
                        dId = doctor.dId

                    };
        // set the data source to list of doctors in the collection
        DoctorList.DataSource = query;
        // set the name of the primary key
        DoctorList.DataValueField = "dId";
        // set the data field to display 
        DoctorList.DataTextField = "doctorString";
        // bind the data to the list
        DoctorList.DataBind();
    }

    protected void AddButton_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["dId"] = -1;
        // redirect to the data entry page
        Response.Redirect("DocMDataEntry.aspx");
    }

    protected void EditButton_Click(object sender, EventArgs e)
    {
        // variable to store the primary key  value of the record to be edit
        Int32 DoctorId;
        // if a record has been selected form the list
        if (DoctorList.SelectedIndex != -1)
        {
            // get the primary key of the value of the record to edit
            DoctorId = Convert.ToInt32(DoctorList.SelectedValue);
            // store the data in the session object 
            Session["dId"] = DoctorId;
            // redirect to the edit page
            Response.Redirect("DocMDataEntry.aspx");
        } else
        {
            // if no record has been selected
            ErrorLabel.Text = "Please select record from the list to edit";
        }
    }

    protected void DeleteButton_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be deleted
        Int32 doctorId;
        // if a record has been selected from the list
        if(DoctorList.SelectedIndex != -1)
        {
            // get the primary key value of the the record to delete
            doctorId = Convert.ToInt32(DoctorList.SelectedValue);
            // store the data in the session object 
            Session["dId"] = doctorId;
            // redirect to the delete page
            Response.Redirect("DocMConfirmDelete.aspx");

        }else // if no record has been selected
        {
            // display an error message
            ErrorLabel.Text = "Please select a record to delete";
        }
    }

    protected void ApplyFilterButton_Click(object sender, EventArgs e)
    {
        // create an instance of th address object 
        clsDoctorCollection doctorCollection = new clsDoctorCollection();
        // retrieve the value of post code from the presntationlayer
        doctorCollection.FilterByLastName(FilterTextBox.Text);
        // data source to display 
        var query = from doctor in doctorCollection.doctorList
                    select new
                    {
                        doctorString = "Dr. " + doctor.dFirstName + " " + doctor.dLastName,
                        dId = doctor.dId

                    };
        // set the dat source to the doctor in the collection
        DoctorList.DataSource = query;
        // set the primary key 
        DoctorList.DataValueField = "dId";
        // set the name of the field to display
        DoctorList.DataTextField = "doctorString";
        // bind the data to the list
        DoctorList.DataBind();
    }

  

    protected void ClearFilterButton_Click1(object sender, EventArgs e)
    {
        // create an instance of th address object 
        clsDoctorCollection doctorCollection = new clsDoctorCollection();
        // retrieve the value of post code from the presntationlayer
        doctorCollection.FilterByLastName("");
        // clear any existing string
        FilterTextBox.Text = "";
        // query for data source
        var query = from doctor in doctorCollection.doctorList
                    select new
                    {
                        doctorString = "Dr. " + doctor.dFirstName + " " + doctor.dLastName,
                        dId = doctor.dId

                    };
        // set the dat source to the doctor in the collection
        DoctorList.DataSource = query;
        // set the primary key 
        DoctorList.DataValueField = "dId";
        // set the name of the field to display
        DoctorList.DataTextField = "doctorString";
        // bind the data to the list
        DoctorList.DataBind();
    }

    protected void StatisticButton_Click(object sender, EventArgs e)
    {
        // redirect to statistics page
        Response.Redirect("DocMStatistics.aspx");

    }

    protected void MainMenuButton_Click(object sender, EventArgs e)
    {
        // redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");

    }
} 