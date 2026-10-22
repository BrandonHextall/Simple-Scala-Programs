using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void AppMButton_Click(object sender, EventArgs e)
    {
        // redirect to appointment list page
        Response.Redirect("AppMList.aspx");
    }

    protected void DocMButton_Click(object sender, EventArgs e)
    {
        // redirect to Doctors list page
        Response.Redirect("DocMList.aspx");
    }

    protected void MedRecMButton_Click(object sender, EventArgs e)
    {
        // redirect to Medical records list page
        Response.Redirect("MedRecList.aspx");
    }

    protected void PatientsMButton_Click(object sender, EventArgs e)
    {
        // redirect to Patients list page
        Response.Redirect("PatMList.aspx");
    }

    protected void RoomMButtons_Click(object sender, EventArgs e)
    {
        // redirect to Rooms list page
        Response.Redirect("RoomMList.aspx");
    }
}