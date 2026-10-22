using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    int FloorNumber;
    int RoomNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        FloorNumber = Convert.ToInt32(Session["FloorNumber"]);
        RoomNumber = Convert.ToInt32(Session["RoomNumber"]);
    }

    protected void ConfirmBtn_Click(object sender, EventArgs e)
    {
        clsRoomCollection room = new clsRoomCollection();
        room.ThisRoom.Find(FloorNumber, RoomNumber);

        room.Delete();

        Response.Redirect("RoomMList.aspx");
    }

    protected void CancelBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("RoomMList.aspx");
    }
}