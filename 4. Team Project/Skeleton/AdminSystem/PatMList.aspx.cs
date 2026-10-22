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
        //for first time page displayed
        if (!IsPostBack)
        {
            //update list box
            DisplayPatients();
        }
    }

    void DisplayPatients()
    {
        //create an instance of the Patient collection
        clsPatientCollection patients = new clsPatientCollection();
        //set the data source to list of Patients in the collection
        lstPatientList.DataSource = patients.PatientList;
        //set the name of the primary key
        lstPatientList.DataValueField = "patientId";
        //set the data field to display
        lstPatientList.DataTextField = "pName";
        //bind the data to the list
        lstPatientList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["PatientId"] = -1;
        //redirect to the data entry page
        Response.Redirect("PatMDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store pk value of the record to be edited
        int patientId;
        //if a record has been selected from the list
        if (lstPatientList.SelectedIndex != -1)
        {
            //get the pk value of the record to edit
            patientId = Convert.ToInt32(lstPatientList.SelectedValue);
            //store the data in the session object
            Session["PatientId"] = patientId;
            //redirect to the edit page 
            Response.Redirect("PatMDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int patientId;
        //if a record has been selected from the list
        if (lstPatientList.SelectedIndex != -1)
        {
            //get the pkey value of the record
            patientId = Convert.ToInt32(lstPatientList.SelectedValue);
            //store the data in the session obj
            Session["PatientId"] = patientId;
            //redirect to the delete page
            Response.Redirect("PatMConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //clsPatientCollection patientCollection = new clsPatientCollection();
        //patientCollection.ReportByName(txtFilter.Text);
        //lstPatientList.DataSource = patientCollection.PatientList;
        ////set name of the pk
        //lstPatientList.DataValueField = "PatientId";
        ////set name of field to display
        //lstPatientList.DataTextField = "PName";
        //lstPatientList.DataBind();

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsPatientCollection patientCollection = new clsPatientCollection();
        txtFilter.Text = "";
        //set data source
        lstPatientList.DataSource = patientCollection.PatientList;
        //set name of the pk
        lstPatientList.DataValueField = "PatientId";
        //set name of field to display
        lstPatientList.DataTextField = "PName";
        lstPatientList.DataBind();
    }

    protected void btnStatsPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("PatMStatistics.aspx");
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}