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
            DisplayMedicalRecords();
        }
    }

    void DisplayMedicalRecords()
    {
        // create an instance of the medical record collection
        clsMedicalRecordCollection MedicalRecords = new clsMedicalRecordCollection();
        // set the data source to list of medical records in the collection
        lstMedicalRecordList.DataSource = MedicalRecords.MedicalRecordList;
        // set the name of the primary key
        lstMedicalRecordList.DataValueField = "recordId";
        // set the data field to display
        lstMedicalRecordList.DataTextField = "AppNotes";
        // bind the data to the list
        lstMedicalRecordList.DataBind();

        //clsAppointments someAppointents = new clsAppointments();
        //someAppointents.Find(3);
    }

    protected void lstMedicalRecordList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store - 1 into the session object to indicate this is a new record 
        Session["recordId"] = -1;

        // redirecr to the data entry page 
        Response.Redirect("MedRecDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited
        Int32 recordId;
        // if the record has been selected from the list
        if (lstMedicalRecordList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            recordId = Convert.ToInt32(lstMedicalRecordList.SelectedValue);
            // store the data in the session object
            Session["recordId"] = recordId;
            // redirecr to the edit page
            Response.Redirect("MedRecDataEntry.aspx");
        }
        else // if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be deleted
        Int32 recordId;
        // if a record has been selected from the list
        if (lstMedicalRecordList.SelectedIndex != -1)
        {
            // get the primary key value of the record delete
            recordId = Convert.ToInt32(lstMedicalRecordList.SelectedValue);
            // store the data in the session object
            Session["recordId"] = recordId;
            // redirecr to the delete page
            Response.Redirect("MedRecConfirmDelete.aspx");
        }
        else // if no record has been selected 
        {
            // display an error message
            lblError.Text = "Please select a record to delete from the list";
        }


    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the medical record collection
        clsMedicalRecordCollection MedicalRecords = new clsMedicalRecordCollection();
        // retrieve all medical records
        MedicalRecords.ReportByPendingApp("");
        // set the data source to list of medical records in the collection
        lstMedicalRecordList.DataSource = MedicalRecords.MedicalRecordList;
        // set the name of the primary key
        lstMedicalRecordList.DataValueField = "recordId";
        // set the data field to display
        lstMedicalRecordList.DataTextField = "AppNotes";
        // bind the data to the list
        lstMedicalRecordList.DataBind();
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the medical record collection
        clsMedicalRecordCollection MedicalRecords = new clsMedicalRecordCollection();
        // retrieve the value of the pending app entered by the user
        MedicalRecords.ReportByPendingApp(txtPendingApp.Text);
        // set the data source to list of medical records in the collection
        lstMedicalRecordList.DataSource = MedicalRecords.MedicalRecordList;
        // set the name of the primary key
        lstMedicalRecordList.DataValueField = "recordId";
        // set the data field to display
        lstMedicalRecordList.DataTextField = "AppNotes";
        // bind the data to the list
        lstMedicalRecordList.DataBind();
    }

    protected void txtPendingApp_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnStatisticsPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("MedicalRecordsStatisticsaspx.aspx");
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
                Response.Redirect("TeamMainMenu.aspx");
    }
}
