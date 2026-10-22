using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MedicalRecordsStatisticsaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        clsMedicalRecords clsMedicalRecords = new clsMedicalRecords();

        // retrieve data from the datbase 
        DataTable dT = clsMedicalRecords.StatisticsGroupedBypatientId();

        //upload dT into GridView
        GridViewStGroupBypatientId.DataSource = dT;
        GridViewStGroupBypatientId.DataBind();

        // change the header of the first column
        GridViewStGroupBypatientId.HeaderRow.Cells[0].Text = " Entry Number";
        GridViewStGroupBypatientId.HeaderRow.Cells[1].Text = " Patient ID ";

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("MedRecList.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}