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
        if (IsPostBack == false)
        {
            DisplayRooms();
        }

    }

    void DisplayRooms()
    {
        clsRoomCollection allRooms = new clsRoomCollection();
        var query = from rooms in allRooms.RoomList select new
        {
                CombinedNo = "Room" + " " + rooms.FloorNumber + rooms.RoomNumber.ToString("D2") + " " + "Currently " + rooms.HygieneStatus,
                RoomNo = rooms.FloorNumber + rooms.RoomNumber.ToString("D2")
        };

        lstRoomsList.DataSource = query;

        lstRoomsList.DataValueField = "RoomNo";
        lstRoomsList.DataTextField = "CombinedNo";

        lstRoomsList.DataBind();
    }

    protected void AddBtn_Click(object sender, EventArgs e)
    {
        Session["FloorNumber"] = -1;
        Session["RoomNumber"] = -1;

        Response.Redirect("RoomMDataEntry.aspx");
    }

    protected void EditBtn_Click(object sender, EventArgs e)
    {
        int FloorNumber = GetKeys(1);
        int RoomNumber = GetKeys(2);

        //System.Diagnostics.Debug.WriteLine("Floor:" + FloorNumber, "\nRoom:" + RoomNumber);

        if (FloorNumber != -1 &&  RoomNumber != -1) 
        {
            Session["FloorNumber"] = FloorNumber;
            Session["RoomNumber"] = RoomNumber;

            Response.Redirect("RoomMDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please Select a record from the list to edit";
        }
    }

    protected void DeleteBtn_Click(object sender, EventArgs e)
    {
        int FloorNumber = GetKeys(1);
        int RoomNumber = GetKeys(2);

        if (FloorNumber != -1 && RoomNumber != -1)
        {
            Session["FloorNumber"] = FloorNumber;
            Session["RoomNumber"] = RoomNumber;

            Response.Redirect("RoomMConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "please Select a record from the list to delete";
        }
    }

    // This will return the primary keys for the selected value
    public int GetKeys(int Value) 
    {
        string Keys;
        string SelectedRoom = "";
 
        Keys = lstRoomsList.SelectedValue;

        System.Diagnostics.Debug.WriteLine("room: " + Keys);

        try
        {
            if (Value == 1) { return Convert.ToInt32(char.GetNumericValue(Keys[0])); }
            else if (Value == 2)
            {
                var RoomNumber = Keys.Substring(1, 2);
                return Convert.ToInt32(RoomNumber); 
            }
        }
        catch 
        {
            lblError.Text = "Please Select a record from the list to edit";
            return -1;
        }

        return -1;
    }

    protected void ApplyBtn_Click(object sender, EventArgs e)
    {
        clsRoomCollection room = new clsRoomCollection();
        room.FilterByWard(WardList.SelectedValue);

        var query = from rooms in room.RoomList
                    select new
                    {
                        CombinedNo = "Room" + " " + rooms.FloorNumber + rooms.RoomNumber.ToString("D2") + " " + "Currently " + rooms.HygieneStatus,
                        RoomNo = rooms.FloorNumber + rooms.RoomNumber.ToString("D2")
                    };

        lstRoomsList.DataSource = query;

        lstRoomsList.DataValueField = "RoomNo";
        lstRoomsList.DataTextField = "CombinedNo";

        lstRoomsList.DataBind();
    }

    protected void RstFltrBtn_Click(object sender, EventArgs e)
    {
        clsRoomCollection room = new clsRoomCollection();

        room.FilterByWard("");

        WardList.SelectedIndex = 0;

        lstRoomsList.DataSource = room.RoomList;

        var query = from rooms in room.RoomList
                    select new
                    {
                        CombinedNo = "Room" + " " + rooms.FloorNumber + rooms.RoomNumber.ToString("D2") + " " + " Ward " + "Currently " + rooms.HygieneStatus,
                        RoomNo = rooms.FloorNumber + rooms.RoomNumber.ToString("D2")
                    };

        lstRoomsList.DataSource = query;

        lstRoomsList.DataValueField = "RoomNo";
        lstRoomsList.DataTextField = "CombinedNo";

        lstRoomsList.DataBind();

    }

    protected void StatistsBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("RoomMStatistics.aspx");
    }

    protected void MenuBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}