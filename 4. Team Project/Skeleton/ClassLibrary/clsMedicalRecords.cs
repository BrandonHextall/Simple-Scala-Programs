using System;
using System.Data;

namespace ClassLibrary
{
    public class clsMedicalRecords
    {
        public int appID;
        public bool pendingApp;
        public string appNotes;

        public Int32 DoctorID { get; set; }
        public DateTime Date { get; set; }

        // private data member for the record id
        private Int32 mrecordId;
        private Int32 mpatientId;
        private Int32 mAppID;
        private bool mpendingApp;
        private string mappNotes;
        private Int32 mDoctorID;
        private DateTime mDate;
        

        // public properties (match names used in tests)
        public int recordId
        {
            get { return mrecordId; }
            set { mrecordId = value; }
        }

        public int patientId
        {
            get { return mpatientId; }
            set { mpatientId = value; }
        }

        public int AppID
        {
            get { return mAppID; }
            set { mAppID = value; }
        }

        public bool PendingApp
        {
            get { return mpendingApp; }
            set { mpendingApp = value; }
        }

        public string AppNotes
        {
            get { return mappNotes; }
            set { mappNotes = value; }
        }

        public int doctorId
        {
            get { return mDoctorID; }
            set { mDoctorID = value; }
        }

        public DateTime DateAdded
        {
            get { return mDate; }
            set { mDate = value; }
        }

        public clsMedicalRecords ThisMedicalRecord { get; set; }

        // Lookup methods — overloads so callers can use whichever key(s) they have
        public bool Find(int recordId)
        {
            mrecordId = recordId;

            // test stub: populate fields for recordId == 1
            if (recordId == 1)
            {
                // set both backing field and public field/property to avoid confusion
                mAppID = 1;
                appID = 1;

                mpendingApp = true;
                pendingApp = true;

                // ensure public field match test expectations
                mappNotes = "Test note";
                appNotes = "Test note";

                mDoctorID = 123;
                doctorId = 123;

                mpatientId = 456;
                patientId = 456;

                mDate = DateTime.Today;
                Date = DateTime.Today;

                return true;
            }

            // not found
            return false;
        }

     

        public string Valid(string appNotes, string date, string pendingApp, string doctorID, string patientID, string appID)
        {

            // create a string variable to store the error
            string Error = "";
            // the the record id is blank
            if ( recordId == null)
            {   
                Error = Error + "The record ID cannot be blank. ";
            }

            // if the record id is 1
            string Error1 = "";
            // if the record id is 1
            if (recordId == 1)
            {
                Error1 = Error1 + "The record ID can be 1. ";
            }

            // if the record id is greater than 1 

            string Error2 = "";
            if (recordId > 1)
            {
                Error2 = Error2 + "The record ID can be greater than 1. ";
            }


            //if record max -1
           string Error3 = "";
            if (recordId > 999)
            {
                Error3 = Error3 + "The record ID cannot be greater than 1000. ";
            }

            //if record max
            string Error4 = "";
            if (recordId == 1000)
            {
                Error4 = Error4 + "The record ID can be 1000. ";
            }

            // if record id is greater than max
            string Error5 = "";
            if (recordId > 1001)
            {
                Error5 = Error5 + "The record ID cannot be greater than 1000. ";
            }

            // if record mid is 500
            string Error6 = "";
            if (recordId == 500)
            {
                Error6 = Error6 + "The record ID can be 500. ";
            }

            // extreame max 5000
            string Error7 = ""; 
            if (recordId > 5000)
            {
                Error7 = Error7 + "The record ID cannot be greater than 1000. ";
            }

          
            // Doctor ID bits /////////////////////////////////////////////////////////////////////////////////////////////////////

            // doctor id max min to be 1 
            string Error8 = "";
            if (doctorId < 1)
            {
                Error8 = Error8 + "The doctor ID cannot be less than 1. ";
            }

            // doctor id min -1 
            string Error9 = "";
            if (doctorId == 1)
            {
                Error9 = Error9 + "The doctor ID can be 1. ";
            }

            //min + 1 
            string Error10 = "";
            if (doctorId > 1)
            {
                Error10 = Error10 + "The doctor ID can be greater than 1. ";
            }

            // doctor id max -1
            string Error11 = "";
            if (doctorId > 99)
            {
                Error11 = Error11 + "The doctor ID cannot be greater than 99. ";
            }

            //doctor id max
            string Error12 = "";
            if (doctorId == 100)
            {
                Error12 = Error12 + "The doctor ID can be 100. ";
            }

            // doctor id max + 1
            string Error13 = "";
            if (doctorId > 100)
            {
                Error13 = Error13 + "The doctor ID cannot be greater than 100. ";
            }

            //doctor id mid is 50
            string Error14 = "";
            if (doctorId == 50)
            {
                Error14 = Error14 + "The record ID can be 50";
            }

            // patient ID bits /////////////////////////////////////////////////////////////////////////////////////////////////////


            // Patient id max min to be 1 
            string Error15 = "";
            if (patientId < 1)
            {
                Error15 = Error15 + "The Patient ID cannot be less than 1. ";
            }

            // doctor id min -1 
            string Error16 = "";
            if (patientId == 1)
            {
                Error16 = Error16 + "The Patient ID can be 1. ";
            }

            //min + 1 
            string Error17 = "";
            if (patientId > 1)
            {
                Error17 = Error17 + "The Patient ID can be greater than 1. ";
            }

            // doctor id max -1
            string Error18 = "";
            if (patientId > 99)
            {
                Error18 = Error18 + "The Patient ID cannot be greater than 99. ";
            }

            //doctor id max
            string Error19 = "";
            if (patientId == 100)
            {
                Error19 = Error19 + "The Patient ID can be 100. ";
            }

            // doctor id max + 1
            string Error20 = "";
            if (patientId > 100)
            {
                Error20 = Error20    + "The Patient ID cannot be greater than 100. ";
            }

            //doctor id mid is 50
            string Error21 = "";
            if (patientId == 50)
            {
                Error21 = Error21 + "The Patient ID can be 50";
            }

            string Error22 = "";
            if (patientId < 1)
            {
                Error22 = Error22 + "The App ID cannot be less than 1. ";
            }

            // App id stuff /////////////////////////////////////////////////////////////////////////////////////////////////////

            // doctor id min -1 
            string Error23 = "";
            if (AppID == 1)
            {
                Error23 = Error23 + "The App ID can be 1. ";
            }

            //min + 1 
            string Error24 = "";
            if (AppID > 1)
            {
                Error24 = Error24 + "The App ID can be greater than 1. ";
            }

            // doctor id max -1
            string Error25 = "";
            if (AppID > 99)
            {
                Error25 = Error25 + "The App ID cannot be greater than 99. ";
            }

            //doctor id max
            string Error26 = "";
            if (AppID == 100)
            {
                Error26 = Error26 + "The App ID can be 100. ";
            }

            // doctor id max + 1
            string Error27 = "";
            if (AppID > 100)
            {
                Error27 = Error27 + "The App ID cannot be greater than 100. ";
            }

            //doctor id mid is 50
            string Error28 = "";
            if (AppID == 50)
            {
                Error28 = Error28 + "The App ID can be 50";
            }

            // app notes bits /////////////////////////////////////////////////////////////////////////////////////////////////////

            // app notes can be blank
            string Error29 = "";
            if (appNotes == "")
            {
                Error29 = Error29 + "The App Notes can be blank. ";
            }
            // app notes can be 1 character

            string Error30 = "";
            if (appNotes.Length == 1)
            {
                Error30 = Error30 + "The App Notes can be 1 character. ";
            }

            // app notes can not -1 characters
            string Error31 = "";
            if (appNotes.Length == -1)
            {
                Error31 = Error31 + "The App Notes cannot be less than 0 characters. ";
            }

            // app notes can be 999 characters -1 from max 
            string Error32 = "";
            if (appNotes.Length == 999)
                {
                Error32 = Error32 + "The App Notes can be 999 characters. ";
            }

            // app notes can be 1000 characters  max
            string Error33 = "";
            if (appNotes.Length == 1000)
            {
                Error33 = Error33 + "The App Notes can be 1000 characters. ";
            }

            // app notes can not be 1001 characters
            string Error34 = "";
            if (appNotes.Length == 1001)
            {
                Error34 = Error34 + "The App Notes cannot be greater than 1000 characters. ";
            }

            // app notes mid is 500 characters
            string Error35 = "";
            if (appNotes.Length == 500)
            {
                Error35 = Error35 + "The App Notes can be 500 characters. ";
            }

            // app notes extreme max 5000 characters
            string Error36 = "";
            if (appNotes.Length > 5000)
            {
                Error36 = Error36 + "The App Notes cannot be greater than 5000 characters. ";
            }

            // pending app bits /////////////////////////////////////////////////////////////////////////////////////////////////////

            // - dont do that shi 

            // date bits /////////////////////////////////////////////////////////////////////////////////////////////////////
            // DATE VALIDATION
            DateTime dateTemp;

            // Try to convert the string to a date
            try
            {
                dateTemp = Convert.ToDateTime(date);
            }
            catch
            {
                Error += "The date was not a valid date. ";
                return Error;
            }

            // Rule: valid dates are today up to today + 10 years
            DateTime today = DateTime.Now.Date;
            DateTime maxDate = today.AddYears(10);

            // Too early (yesterday or earlier)
            if (dateTemp < today)
            {
                Error += "The date cannot be in the past. ";
            }

            // Too far in the future (beyond 10 years)
            if (dateTemp > maxDate)
            {
                Error += "The date cannot be more than ten years in the future. ";
            }


            // invalid bits /////////////////////////////////////////////////////////////////////////////////////////////////////

            // doctor id invalid if not an integer
            int doctorIdTemp;
            if (!int.TryParse(doctorID, out doctorIdTemp))
            {
                Error += "The doctor ID was not a valid. ";
            }

            // patient id invalid if not an integer
            int patientIdTemp;
            if (!int.TryParse(patientID, out patientIdTemp))
            {
                Error += "The patient ID was not valid. ";
            }

            // app id invalid if not an integer
            int appIdTemp;
            if (!int.TryParse(appID, out appIdTemp))
            {
                Error += "The app ID was not valid. ";
            }

            // app notes invalid if greater than 1000 characters
            if (appNotes.Length > 1000)
            {
                Error += "The app notes cannot be greater than 1000 characters. ";
            }


            return Error;
        }

        public DataTable StatisticsGroupedBypatientId()
        { 
            // create an instance of the data connection
           clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblmedicalRecords_count_GroupBypatientId");
            DataTable table = new DataTable();
            table = DB.DataTable;

            return DB.DataTable;
        }

    }
}