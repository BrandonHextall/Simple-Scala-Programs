using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class PatMStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsPatient aPatient = new clsPatient();
        DataTable dT = aPatient.StatisticsGroupedByDoctorId();
        //upload dT into GridView
        GridViewStGroupByDoc.DataSource = dT;
        GridViewStGroupByDoc.DataBind();
        //add column title
        GridViewStGroupByDoc.HeaderRow.Cells[0].Text = "Total";
        GridViewStGroupByDoc.HeaderRow.Cells[1].Text = "First Name";
        GridViewStGroupByDoc.HeaderRow.Cells[2].Text = "Last Name";

        //repeat for second table
        dT = aPatient.StatisticsGroupedByDOB();
        //upload dT into GridView
        GridViewStGroupByDOB.DataSource = dT;
        GridViewStGroupByDOB.DataBind();
        //add column title
        GridViewStGroupByDOB.HeaderRow.Cells[0].Text = "Total";
        GridViewStGroupByDOB.HeaderRow.Cells[1].Text = "DOB";
    }   
}