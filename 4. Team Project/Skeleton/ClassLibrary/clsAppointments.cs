using System;
using System;
using System.Data;
using System.Globalization;

namespace ClassLibrary
{
    //constructor for the class
    public class clsAppointments
    {
        //private data member for the appointment number property
        private Int32 mAppointmentNumber;
        //private data member for the doctor ID property
        private Int32 mDoctorID;
        //private data member for the patient ID property
        private int mPatientID;
        //private data member for the patient first name property
        private string mPatientFirstName;
        //private data member for the patient last name property
        private string mPatientLastName;
        //private data member for the date of appointment property
        private DateTime mDateOfAppointment;
        //private data member for the time of appointment property
        private TimeSpan mTimeOfAppointment;
        //private data member for the floor number property
        private Int32 mFloorNumber;
        //private data member for the room number property
        private Int32 mRoomNumber;
        //private data member for the emergency appointment property
        private bool mEmergencyAppointment;
        //private data member for the notes property
        private string mNotes;

        //public property for the appointment number
        public int AppointmentNumber
        {
            get
            {
                //sends data out of the property
                return mAppointmentNumber;
            }
            set
            {
                //allows data into the property
                mAppointmentNumber = value;
            }
        }
        //public property for the doctor ID
        public int DoctorID
        {
            get
            {
                //sends data out of the property
                return mDoctorID;
            }
            set
            {
                //allows data into the property
                mDoctorID = value;
            }
        }
        //public property for the patient ID
        public int PatientID
        {
            get
            {
                //sends data out of the property
                return mPatientID;
            }
            set
            {
                mPatientID = value;
            }
        }
        //public property for the patient first name
        public string PatientFirstName
        {
            get
            {
                //sends data out of the property
                return mPatientFirstName;
            }
            set
            {
                //allows data into the property
                mPatientFirstName = value;
            }
        }
        //public property for the patient last name
        public string PatientLastName
        {
            get
            {
                //sends data out of the property
                return mPatientLastName;
            }
            set
            {
                //allows data into the property
                mPatientLastName = value;
            }
        }
        //public property for the date of appointment
        public DateTime DateOfAppointment
        {
            get
            {
                //sends data out of the property
                return mDateOfAppointment;
            }
            set
            {
                //allows data into the property
                mDateOfAppointment = value;
            }
        }
        //public property for the time of appointment
        public TimeSpan TimeOfAppointment
        {
            get
            {
                //sends data out of the property
                return mTimeOfAppointment;
            }
            set
            {
                //allows data into the property
                mTimeOfAppointment = value;
            }
        }
        //public property for the floor number
        public int FloorNumber
        {
            get
            {
                //sends data out of the property
                return mFloorNumber;
            }
            set
            {
                //allows data into the property
                mFloorNumber = value;
            }
        }
        //public property for the room number
        public int RoomNumber
        {
            get
            {
                //sends data out of the property
                return mRoomNumber;
            }
            set
            {
                //allows data into the property
                mRoomNumber = value;
            }
        }
        //public property for the emergency appointment
        public bool EmergencyAppointment
        {
            get
            {
                //sends data out of the property
                return mEmergencyAppointment;
            }
            set
            {
                //allows data into the property
                mEmergencyAppointment = value;
            }
        }
        //public property for the notes
        public string Notes
        {
            get
            {
                //sends data out of the property
                return mNotes;
            }
            set
            {
                //allows data into the property
                mNotes = value;
            }
        }

        /***********************FIND METHOD***************************/
        public bool Find(int appointmentNumber)
        {
            if (appointmentNumber < 1) return false;
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the appointment number to search for
            DB.AddParameter("@AppointmentNumber", appointmentNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblAppointments_FilterByAppointmentNumber");
            //check if data has been found, if not return false
            if (DB.DataTable.Rows.Count == 0) return false;
            //create an instance of the data connection to the patient database
            clsDataConnection PatientDB = new clsDataConnection();
            //add the parameter for the patient ID to search for
            PatientDB.AddParameter("@PatientID", Convert.ToInt32(DB.DataTable.Rows[0]["PatientID"]));
            //execute the stored procedure
            PatientDB.Execute("sproc_tblAppointments_GetPatientById");
            string[] patientName = Convert.ToString(PatientDB.DataTable.Rows[0]["PName"]).Split(' ');
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mAppointmentNumber = Convert.ToInt32(DB.DataTable.Rows[0]["AppointmentNumber"]);
                mDoctorID = Convert.ToInt32(DB.DataTable.Rows[0]["DoctorID"]);
                mPatientID = Convert.ToInt32(DB.DataTable.Rows[0]["PatientID"]);
                mPatientFirstName = patientName[0];
                mPatientLastName = patientName[1];
                mDateOfAppointment = Convert.ToDateTime(DB.DataTable.Rows[0]["AppointmentDate"]).Add(mTimeOfAppointment);
                mFloorNumber = Convert.ToInt32(DB.DataTable.Rows[0]["FloorNumber"]);
                mRoomNumber = Convert.ToInt32(DB.DataTable.Rows[0]["RoomNumber"]);
                mEmergencyAppointment = Convert.ToBoolean(DB.DataTable.Rows[0]["EmergencyAppointment"]);
                mNotes = Convert.ToString(DB.DataTable.Rows[0]["Notes"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string patientFirstName, string patientLastName, string dateOfAppointment, string timeOfAppointment, string floorNumber, string roomNumber, string notes, string emergencyAppointment)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date of appointment
            DateTime DateTemp;
            /****Patient first name****/
            //if the patient first name is blank
            if (patientFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The patient first name may not be blank : ";
            }
            //if the patient first name is greater than 100 characters
            if (patientFirstName.Length > 100)
            {
                //record the error
                Error = Error + "The patient first name must be less than 100 characters : ";
            }
            //if the patient first name contains numbers or special characters
            if (System.Text.RegularExpressions.Regex.IsMatch(patientFirstName, @"[^a-zA-Z\s]"))
            {
                //record the error
                Error = Error + "The patient first name may only contain letters : ";
            }
            /****Patient last name****/
            //if the patient last name is blank
            if (patientLastName.Length == 0)
            {
                //record the error
                Error = Error + "The patient last name may not be blank : ";
            }
            //if the patient last name is greater than 100 characters
            if (patientLastName.Length > 100)
            {
                //record the error
                Error = Error + "The patient last name must be less than 100 characters : ";
            }
            //if the patient last name contains numbers or special characters
            if (System.Text.RegularExpressions.Regex.IsMatch(patientLastName, @"[^a-zA-Z\s]"))
            {
                //record the error
                Error = Error + "The patient last name may only contain letters : ";
            }
            /****Date of appointment****/
            //copy the date of appointment value to the temporary variable
            try
            {
                DateTemp = Convert.ToDateTime(dateOfAppointment);
                //if the date of appointment is in the past
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date of appointment cannot be in the past : ";
                }
                //if the date is more than a year from now
                if (DateTemp > DateTime.Now.AddYears(1))
                {
                    //record the error
                    Error = Error + "The date of appointment is not a valid date : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date of appointment is not a valid date : ";
            }
            /****Time of appointment****/
            try
            {
                string[] timeSplit = timeOfAppointment.Split(':');
                TimeSpan TimeTemp = new TimeSpan(Convert.ToInt32(timeSplit[0]), Convert.ToInt32(timeSplit[1]), 00);
                //if the time of appointment is less than 09:00:00 (open time)
                if (TimeTemp < new TimeSpan(9, 0, 0))
                {
                    //record the error
                    Error = Error + "The time of appointment cannot be before 09:00:00 : ";
                }
                //if the time of appointment is greater than 17:00:00 (close time)
                if (TimeTemp > new TimeSpan(17, 00, 0))
                {
                    //record the error
                    Error = Error + "The time of appointment cannot be after 17:00:00 : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The time of appointment is not a valid time : ";
            }
            /****Floor Number****/
            try
            {
                int FloorTemp = Convert.ToInt32(floorNumber);
                //if the floor number is less than 0
                if (FloorTemp < 0)
                {
                    //record the error
                    Error = Error + "The floor number cannot be negative : ";
                }
                //if the floor number is greater than 5
                if (FloorTemp > 5)
                {
                    //record the error
                    Error = Error + "The floor number cannot be greater than 5 : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The floor number is not a valid integer : ";
            }
            /****Room Number****/
            try
            {
                int RoomTemp = Convert.ToInt32(roomNumber);
                //if the room number is less than 0
                if (RoomTemp < 1)
                {
                    //record the error
                    Error = Error + "The room number cannot be negative : ";
                }
                //if the room number is greater than 100
                if (RoomTemp > 100)
                {
                    //record the error
                    Error = Error + "The room number cannot be greater than 100 : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The room number is not a valid integer : ";
            }
            /****Emergency Appointment****/
            //if the emergency appointment value is not "true" or "false"
            if (emergencyAppointment.ToLower() != "true" && emergencyAppointment.ToLower() != "false")
            {
                //record the error
                Error = Error + "The emergency appointment value must be either true or false : ";
            }
            /****Notes****/
            //if the notes is greater than 500 characters
            if (notes.Length > 500)
            {
                //record the error
                Error = Error + "The notes must be less than 500 characters : ";
            }
            //if notes only contain numbers and/or special characters
            if (System.Text.RegularExpressions.Regex.IsMatch(notes, @"^[^a-zA-Z]+$"))
            {
                //record the error
                Error = Error + "The notes must contain letters : ";
            }
            return Error;
        }
        /********** Statistics Grouped by Emergency Appointment FUNCTION NOT FUCKING METHOD **********/
        public DataTable StatisticsGroupedByEmergency()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAppointments_Count_GroupByEmergency");
            //there should be zero, one, or more records
            return DB.DataTable;
        }
        /********** Statistics Grouped by Doctor FUNCTION **********/
        public DataTable StatisticsGroupedByDoctor()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAppointments_Count_GroupByDoctor");
            //there should be zero, one, or more records
            return DB.DataTable;
        }
        /********** Statistics Grouped by Date FUNCTION **********/
        public DataTable StatisticsGroupedByDate()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAppointments_Count_GroupByDate");
            //there should be zero, one, or more records
            return DB.DataTable;
        }
        /*********** Statistics Grouped by FloorNumber FUNCTION **********/
        public DataTable StatisticsGroupedByFloorNumber()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAppointments_Count_GroupByFloorNumber");
            //there should be zero, one, or more records
            return DB.DataTable;
        }
        /************ Statistics Grouped by RoomNumber FUNCTION **********/
        public DataTable StatisticsGroupedByRoomNumber()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAppointments_Count_GroupByRoomNumber");
            //there should be zero, one, or more records
            return DB.DataTable;
        }
    }
}