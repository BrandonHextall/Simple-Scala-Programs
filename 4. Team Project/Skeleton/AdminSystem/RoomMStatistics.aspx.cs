using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RoomMStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsRoom room = new clsRoom();

        DataTable dT = room.StatisticsGroupedByWard();

        GridWard.DataSource = dT;  
        GridWard.DataBind();

        GridWard.HeaderRow.Cells[1].Text = " Total ";

    }

    protected void BackBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("RoomMList.aspx");
    }
}