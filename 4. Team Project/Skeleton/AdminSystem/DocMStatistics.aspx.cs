using ClassLibrary;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DocMStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsDoc clsDoctor = new clsDoc();

        // retrieve data from the databse
        DataTable dT = clsDoctor.StatisticsGroupedByLastName();

        // upload dt into gridview
        GridStatsByLastName.DataSource = dT;
        GridStatsByLastName.DataBind();

        // change the header of the first column 
        GridStatsByLastName.HeaderRow.Cells[0].Text = " Total ";

        // retrieve data from the databse
        dT = clsDoctor.StatisticsGroupedByAvailability();

        // upload dt into gridview
        GridStatsByAvailability.DataSource = dT;
        GridStatsByAvailability.DataBind();

        // change the header of the first column 
        GridStatsByAvailability.HeaderRow.Cells[0].Text = " Total ";
    }

    protected void BackButton_Click(object sender, EventArgs e)
    {
        // redirect back to list
        Response.Redirect("DocMList.aspx");
    }
}