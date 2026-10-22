using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    [TestClass]
    public class tstRoomCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsRoomCollection room = new clsRoomCollection();
            Assert.IsNotNull(room);
        }

        [TestMethod]
        public void RoomListOK()
        {
            clsRoomCollection room = new clsRoomCollection();
            List<clsRoom> TestList = new List<clsRoom>();
            clsRoom TestItem = new clsRoom();
            TestItem.FloorNumber = 2;
            TestItem.RoomNumber = 4;
            TestItem.WardLocation = "Intensive Care Unit";
            TestItem.BedType = "Heavy";
            TestItem.DisabilityAccessible = true;
            TestItem.HygieneStatus = "Available";
            TestItem.Inspected = true;
            TestItem.Maintained = true;
            TestItem.LastDateCleaned = DateTime.Now;

            TestList.Add(TestItem);

            room.RoomList = TestList;

            Assert.AreEqual(room.RoomList, TestList);
        }

        [TestMethod]
        public void ThisRoomOK()
        {
            clsRoomCollection rooms = new clsRoomCollection();
            clsRoom TestRoom = new clsRoom();

            TestRoom.FloorNumber = 1;
            TestRoom.RoomNumber = 1;
            TestRoom.WardLocation = "General";
            TestRoom.BedType = "General";
            TestRoom.DisabilityAccessible = true;
            TestRoom.HygieneStatus = "Available";
            TestRoom.Inspected = true;
            TestRoom.Maintained = true;
            TestRoom.LastDateCleaned = Convert.ToDateTime("29/04/2026 00:00:00");

            rooms.ThisRoom = TestRoom;
            Assert.AreEqual(rooms.ThisRoom, TestRoom);
        
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsRoomCollection rooms = new clsRoomCollection();
            List<clsRoom> TestList = new List<clsRoom>();
            clsRoom TestItem = new clsRoom();
            TestItem.FloorNumber = 2;
            TestItem.RoomNumber = 4;
            TestItem.WardLocation = "Intensive Care Unit";
            TestItem.BedType = "Heavy";
            TestItem.DisabilityAccessible = true;
            TestItem.HygieneStatus = "Available";
            TestItem.Inspected = true;
            TestItem.Maintained = true;
            TestItem.LastDateCleaned = DateTime.Now;
            TestList.Add(TestItem);

            rooms.RoomList = TestList;

            Assert.AreEqual(rooms.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsRoomCollection AllRooms = new clsRoomCollection();
            clsRoom TestItem = new clsRoom();

            Int32 PrimaryKeyFloor = 8;
            Int32 SecondaryKeyRoom = 9;

            TestItem.FloorNumber = 8;
            TestItem.RoomNumber = 9;
            TestItem.WardLocation = "General";
            TestItem.BedType = "General";
            TestItem.DisabilityAccessible = true;
            TestItem.HygieneStatus = "Available";
            TestItem.Inspected = true;
            TestItem.Maintained = true;
            TestItem.LastDateCleaned = Convert.ToDateTime("29/04/2026 00:00:00");
        
            AllRooms.ThisRoom = TestItem;

            AllRooms.Add();

            TestItem.FloorNumber = PrimaryKeyFloor;
            TestItem.RoomNumber = SecondaryKeyRoom;

            AllRooms.ThisRoom.Find(PrimaryKeyFloor, SecondaryKeyRoom);

            Assert.AreEqual(AllRooms.ThisRoom, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsRoomCollection allRooms = new clsRoomCollection();
            clsRoom TestItem = new clsRoom();

            // ADD THESE ATTRIBUTES

            Int32 PrimaryKey = 3;
            Int32 SecondaryKey = 1;
            
            TestItem.FloorNumber = PrimaryKey;
            TestItem.RoomNumber = SecondaryKey;

            TestItem.WardLocation = "Pediatric";
            TestItem.BedType = "Heavy";
            TestItem.DisabilityAccessible = true;
            TestItem.HygieneStatus = "Occupied";
            TestItem.Inspected = true;
            TestItem.Maintained = true;
            TestItem.LastDateCleaned = Convert.ToDateTime("01/05/2026 00:00:00");

            allRooms.ThisRoom = TestItem;

            // CHECK TO SEE IF THIS IS ALREADY IN DB
         
            if (!TestItem.Find(PrimaryKey, SecondaryKey))
            { 
                allRooms.Add(); 
            }
            else
            {
                allRooms.Update();
            }

            // UPDATE THE SAME ROW

            TestItem.WardLocation = "General";
            TestItem.BedType = "General";
            TestItem.DisabilityAccessible = true;
            TestItem.HygieneStatus = "Available";
            TestItem.Inspected = true;
            TestItem.Maintained = true;
            TestItem.LastDateCleaned = Convert.ToDateTime("02/05/2026 00:00:00");

            allRooms.ThisRoom = TestItem;

            allRooms.Update();

            allRooms.ThisRoom.Find(PrimaryKey, SecondaryKey);

            Assert.AreEqual(allRooms.ThisRoom, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsRoomCollection allRooms = new clsRoomCollection();
            clsRoom TestItem = new clsRoom();

            Int32 primaryKey = 5;
            Int32 SecondaryKey = 1;

            TestItem.WardLocation = "General";
            TestItem.BedType = "General";
            TestItem.DisabilityAccessible = true;
            TestItem.HygieneStatus = "Available";
            TestItem.Inspected = true;
            TestItem.Maintained = true;
            TestItem.LastDateCleaned = Convert.ToDateTime("02/05/2026 00:00:00");

            allRooms.ThisRoom = TestItem;

            allRooms.Add();

            allRooms.ThisRoom.Find(primaryKey, SecondaryKey);

            allRooms.Delete();

            Boolean Found = allRooms.ThisRoom.Find(primaryKey, SecondaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void FilterByWardMethodOK()
        {
            clsRoomCollection allRooms = new clsRoomCollection();

            clsRoomCollection FilteredRooms = new clsRoomCollection();

            FilteredRooms.FilterByWard("");

            Assert.AreEqual(allRooms.Count, FilteredRooms.Count);
        }

        [TestMethod]
        public void FilterByWardMethodNotFound()
        {
            clsRoomCollection FilteredRooms = new clsRoomCollection();
            FilteredRooms.FilterByWard("XXXXX");
            Assert.AreEqual(0, FilteredRooms.Count);
        }

        [TestMethod]
        public void FilterByWardTestDataFound()
        {
            clsRoomCollection FilteredRooms = new clsRoomCollection();

            Boolean OK = true;

            // 15 in general
            // 4 in ICU
            FilteredRooms.FilterByWard("General");

            if (FilteredRooms.Count == 15)
            {
                OK = true;
            }
            else 
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
