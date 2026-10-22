using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 FloorNumber;
    Int32 RoomNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        FloorNumber = Convert.ToInt32(Session["FloorNumber"]);
        RoomNumber = Convert.ToInt32(Session["RoomNumber"]);
        if (IsPostBack == false)
        {
            if (FloorNumber != -1 && RoomNumber != -1)
            {
                DisplayRoom();
            }
        }
    }

    void DisplayRoom()
    {
        clsRoomCollection RoomList = new clsRoomCollection();
        RoomList.ThisRoom.Find(FloorNumber, RoomNumber);

        txtFloorNumber.Text = RoomList.ThisRoom.FloorNumber.ToString();
        txtRoomNumber.Text = RoomList.ThisRoom.RoomNumber.ToString();
        listWardLocation.SelectedValue = RoomList.ThisRoom.WardLocation.ToString();
        listBedType.SelectedValue = RoomList.ThisRoom.BedType.ToString();
        chckbxDisabilityAccessible.Checked = RoomList.ThisRoom.DisabilityAccessible;
        listHygieneStatus.SelectedValue = RoomList.ThisRoom.HygieneStatus.ToString();
        chckbxInspected.Checked = RoomList.ThisRoom.Inspected;
        chckbxMaintained.Checked = RoomList.ThisRoom.Maintained;
        calLastDateCleaned.SelectedDate = RoomList.ThisRoom.LastDateCleaned;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsRoomNumber
        clsRoom Room = new clsRoom();

        string error = "";

        //int FloorNumber = Convert.ToInt32(txtFloorNumber.Text);

        //int RoomNumber = Convert.ToInt32(txtRoomNumber.Text);

        int FloorNumber;
        int RoomNumber;

        try 
        {
            FloorNumber = Convert.ToInt32(txtFloorNumber.Text);

            RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
        }
        catch 
        {
            FloorNumber = -1;
            RoomNumber = -1;
        }

        string WardLocation = listWardLocation.SelectedValue;

        string BedType = listBedType.SelectedValue;

        Boolean DisabilityAccess = chckbxDisabilityAccessible.Checked;

        string HygieneStatus = listHygieneStatus.SelectedValue;

        Boolean Inspected = chckbxInspected.Checked;

        Boolean Maintained = chckbxMaintained.Checked;
  
        string LastDateCleaned = calLastDateCleaned.SelectedDate.ToString();

        error = Room.Valid(FloorNumber, RoomNumber, WardLocation, BedType, HygieneStatus, LastDateCleaned);
        if (error == "")
        {
            //Capture the data
            Room.FloorNumber = FloorNumber;
            Room.RoomNumber = RoomNumber;
            Room.WardLocation = WardLocation;
            Room.BedType = BedType;
            Room.DisabilityAccessible = DisabilityAccess;
            Room.HygieneStatus = HygieneStatus;
            Room.Inspected = Inspected;
            Room.Maintained = Maintained;
            Room.LastDateCleaned = Convert.ToDateTime(LastDateCleaned);

            clsRoomCollection roomList = new clsRoomCollection();

            // If room doesnt exist, add it. else update it
            if (!Room.Exists(FloorNumber, RoomNumber))
            {
                roomList.ThisRoom = Room;
                roomList.Add();
            }
            else
            {
                roomList.ThisRoom.Find(FloorNumber, RoomNumber);
                roomList.ThisRoom = Room;

                roomList.Update();
            }

            //naivgate to the viewer page
            Response.Redirect("RoomMList.aspx");
        }
        else
        {
            lblError.Text = error;
        }

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsRoom room = new clsRoom();
        Int32 FloorNumber;
        Int32 RoomNumber;

        Boolean Found = false;

        FloorNumber = Convert.ToInt32(txtFloorNumber.Text);
        RoomNumber = Convert.ToInt32(txtRoomNumber.Text);

        Found = room.Find(FloorNumber, RoomNumber);

        if (Found == true)
        {
            lblError.Text = "";

            listWardLocation.SelectedValue = room.WardLocation;
            listBedType.SelectedValue = room.BedType;
            chckbxDisabilityAccessible.Checked = room.DisabilityAccessible;
            listHygieneStatus.SelectedValue = room.HygieneStatus;
            chckbxInspected.Checked = room.Inspected;
            chckbxMaintained.Checked = room.Maintained;
            calLastDateCleaned.SelectedDate = room.LastDateCleaned;
        }
        else
        {
            //Need to make sure the other values get set to empty when this happens
            lblError.Text = "Incorrect";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("RoomMList.aspx");
    }
}