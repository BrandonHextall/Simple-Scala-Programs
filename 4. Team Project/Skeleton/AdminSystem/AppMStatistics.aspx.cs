using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AppMStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsAppointments clsAppointments = new clsAppointments();

        //retrieve data from the database
        DataTable dT = clsAppointments.StatisticsGroupedByDate();

        //upload dT into gridView
        GridGroupDate.DataSource = dT;
        GridGroupDate.DataBind();

        //change header of the first column
        GridGroupDate.HeaderRow.Cells[0].Text = "Total";

        //retrieve data from the database
        dT = clsAppointments.StatisticsGroupedByDoctor();

        //upload dT into gridView
        GridGroupDoctor.DataSource = dT;
        GridGroupDoctor.DataBind();

        //change header of the first column
        GridGroupDoctor.HeaderRow.Cells[0].Text = "Total";

        //retrieve data from the database
        dT = clsAppointments.StatisticsGroupedByFloorNumber();

        //upload dT into gridView
        GridGroupFloorNumber.DataSource = dT;
        GridGroupFloorNumber.DataBind();

        //change header of the first column
        GridGroupFloorNumber.HeaderRow.Cells[0].Text = "Total";

        //retrieve data from the database
        dT = clsAppointments.StatisticsGroupedByRoomNumber();

        //upload dT into gridView
        GridGroupRoomNumber.DataSource = dT;
        GridGroupRoomNumber.DataBind();

        //change header of the first column
        GridGroupRoomNumber.HeaderRow.Cells[0].Text = "Total";

        //retrieve data from the database
        dT = clsAppointments.StatisticsGroupedByEmergency();

        //upload dT into gridView
        GridGroupEmergency.DataSource = dT;
        GridGroupEmergency.DataBind();

        //change header of the first column
        GridGroupEmergency.HeaderRow.Cells[0].Text = "Total";
    }
}