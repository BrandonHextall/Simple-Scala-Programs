using System;
using System.Data;

namespace ClassLibrary
{
    public class clsRoom
    {
        private Int32 mFloorNumber;
        private Int32 mRoomNumber;
        private string mWardLocation;
        private string mBedType;
        private bool mDisabilityAccessible;
        private string mHygieneStatus;
        private bool mInspected;
        private bool mMaintained;
        private DateTime mLastDateCleaned;

        public Int32 FloorNumber
        {
            get
            {
                return mFloorNumber;
            }
            set
            {
                mFloorNumber = value;
            }
        }

        public Int32 RoomNumber
        {
            get
            {
                return mRoomNumber;
            }
            set
            {
                mRoomNumber = value;
            }
        }

        public string WardLocation
        {
            get
            {
                return mWardLocation;
            }
            set
            {
                mWardLocation = value;
            }
        }

        public string BedType
        {
            get
            {
                return mBedType;
            }
            set
            {
                mBedType = value;
            }
        }

        public bool DisabilityAccessible
        {
            get
            {
                return mDisabilityAccessible;
            }
            set
            {
                mDisabilityAccessible = value;
            }
        }

        public string HygieneStatus
        {
            get
            {
                return mHygieneStatus;
            }
            set
            {
                mHygieneStatus = value;
            }
        }

        public bool Inspected
        {
            get
            {
                return mInspected;
            }
            set
            {
                mInspected = value;
            }
        }

        public bool Maintained
        {
            get
            {
                return mMaintained;
            }
            set
            {
                mMaintained = value;
            }
        }

        public DateTime LastDateCleaned
        {
            get
            {
                return mLastDateCleaned;
            }
            set
            {
                mLastDateCleaned = value;
            }
        }

        public bool Exists(int FloorNumber, int RoomNumber)
        {
            bool exists = false;
            int returned;

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@FloorNumber", FloorNumber);
            DB.AddParameter("@RoomNumber", RoomNumber);

            returned = DB.Execute("sproc_tblRoom_RoomExists");

            if (returned == 1) { exists = true; }
            else { exists = false; }

            return exists;
        }

        public bool Find(int FloorNumber, int RoomNumber)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@FloorNumber", FloorNumber);
            DB.AddParameter("@RoomNumber", RoomNumber);

            DB.Execute("sproc_tblRoom_FilterByFloorNRoomNumberId");

            if (DB.Count == 1)
            {
                mFloorNumber = Convert.ToInt32(DB.DataTable.Rows[0]["FloorNumber"]);
                mRoomNumber = Convert.ToInt32(DB.DataTable.Rows[0]["RoomNumber"]);
                mWardLocation = Convert.ToString(DB.DataTable.Rows[0]["WardLocation"]);
                mBedType = Convert.ToString(DB.DataTable.Rows[0]["BedType"]);
                mDisabilityAccessible = Convert.ToBoolean(DB.DataTable.Rows[0]["DisabilityAccess"]);
                mHygieneStatus = Convert.ToString(DB.DataTable.Rows[0]["HygieneStatus"]);
                mInspected = Convert.ToBoolean(DB.DataTable.Rows[0]["Inspected"]);
                mMaintained = Convert.ToBoolean(DB.DataTable.Rows[0]["Maintained"]);
                mLastDateCleaned = Convert.ToDateTime(DB.DataTable.Rows[0]["LastDateCleaned"]);

                return true;
            }

            else
            {
                return false;

            }
        }

        public string Valid(int FloorNumber,
                            int RoomNumber,
                            string WardLocation,
                            string BedType,
                            string HygieneStatus,
                            string LastDateCleaned)
        {
            string error = "";
            DateTime DateTemp;
            DateTime PastMinDate;

            if (FloorNumber <= 0 && RoomNumber <= 0) { error += "Woops, looks like you forgot to enter a valid room number. "; }

            switch (WardLocation)
            {
                case "General":
                    break;
                case "Pediatric":
                    break;
                case "Intensive Care Unit":
                    break;
                default:
                    error += "Ward Location is not valid. ";
                    break;
            }

            switch (BedType)
            {
                case "General":
                    break;
                case "Heavy":
                    break;
                default:
                    error += "Bed Type is not valid. ";
                    break;
            }

            switch (HygieneStatus)
            {
                case "Available":
                    break;
                case "Occupied":
                    break;
                case "Reprocessing":
                    break;
                default:
                    error += "Hygiene Status is not valid. ";
                    break;
            }

            try 
            {                
                DateTemp = Convert.ToDateTime(LastDateCleaned);
                PastMinDate = Convert.ToDateTime("01/04/2026 00:00:00");
                if (DateTemp > DateTime.Now.Date)
                {
                    error += "Last Date Cleaned cannot be in the future. ";
                }
                if (DateTemp < PastMinDate)
                {
                    error = error + "Last Date Cleaned cannot be too far in the past. ";
                }

            }
            catch 
            {
                error += "Incorrect. ";
            }

            return error;
        }

        public DataTable StatisticsGroupedByWard()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblRoom_Count_GroupByWards");

            DataTable table = new DataTable();

            table = DB.DataTable;

            return table;
        }

        public DataTable StatisticsGroupedByLastDateCleaned()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblRoom_Count_GroupByLastDateCleaned");

            DataTable table = new DataTable();

            table = DB.DataTable;

            return table;
        }
    }
}