using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsRoom
        clsRoom Room = new clsRoom();
        Room = (clsRoom)Session["Room"];
        Response.Write("Floor Number: " + Room.FloorNumber + "<br>");
        Response.Write("Room Number: " + Room.RoomNumber + "<br>");
        Response.Write("Ward Location: " + Room.WardLocation + "<br>");
        Response.Write("Bed Type: " + Room.BedType + "<br>");
        Response.Write("Disability accessible: " + Room.DisabilityAccessible + "<br>");
        Response.Write("Hygiene status: " + Room.HygieneStatus + "<br>");
        Response.Write("Inspected: " + Room.Inspected + "<br>");
        Response.Write("Maintained: " + Room.Maintained + "<br>");
        Response.Write("Last date cleaned: " + Room.LastDateCleaned);
    }
}