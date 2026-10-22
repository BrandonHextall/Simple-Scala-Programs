using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    //constructor for the class
    public class clsAppointmentsCollection
    {
        //private data member for the list
        List<clsAppointments> mAppointmentsList = new List<clsAppointments>();
        //private member data for thisAppointment
        clsAppointments mThisAppointment = new clsAppointments();
        //public property for the appointment list
        public List<clsAppointments> AppointmentsList
        {
            get
            {
                //return the private data
                return mAppointmentsList;
            }
            set
            {
                //set the private data
                mAppointmentsList = value;
            }
        }
        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return mAppointmentsList.Count;
            }
            set
            {
                //we will worry about this later
            }
        }
        //public property for thisAppointment
        public clsAppointments ThisAppointment
        {
            get
            {
                //return the private data
                return mThisAppointment;
            }
            set
            {
                //set the private data
                mThisAppointment = value;
            }
        }
        public clsAppointmentsCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAppointments_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        public int Add()
        {
            //adds a new record to the database based on the values of mThisAppointment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //connect to patient database
            clsDataConnection DBPatient = new clsDataConnection();
            //set parameters for the stored procedure to find the patient id
            DBPatient.AddParameter("@FirstName", Convert.ToString(mThisAppointment.PatientFirstName));
            DBPatient.AddParameter("@LastName", Convert.ToString(mThisAppointment.PatientLastName));
            //execute the stored procedure to find the patient id
            DBPatient.Execute("sproc_tblAppointments_GetPatientByName");
            string[] PatientName = Convert.ToString(DBPatient.DataTable.Rows[0]["PName"]).Split(' ');
            //set the parameters for the stored procedure
            DB.AddParameter("@DoctorID", mThisAppointment.DoctorID);
            DB.AddParameter("@PatientID", DBPatient.DataTable.Rows[0]["PatientID"]);
            DB.AddParameter("@AppointmentDate", mThisAppointment.DateOfAppointment);
            DB.AddParameter("@FloorNumber", mThisAppointment.FloorNumber);
            DB.AddParameter("@RoomNumber", mThisAppointment.RoomNumber);
            DB.AddParameter("@EmergencyAppointment", mThisAppointment.EmergencyAppointment);
            DB.AddParameter("@Notes", mThisAppointment.Notes);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblAppointments_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisAppointment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AppointmentID", mThisAppointment.AppointmentNumber);
            DB.AddParameter("@PatientID", mThisAppointment.PatientID);
            DB.AddParameter("@DoctorID", mThisAppointment.DoctorID);
            DB.AddParameter("@AppointmentDate", mThisAppointment.DateOfAppointment);
            DB.AddParameter("@FloorNumber", mThisAppointment.FloorNumber);
            DB.AddParameter("@RoomNumber", mThisAppointment.RoomNumber);
            DB.AddParameter("@EmergencyAppointment", mThisAppointment.EmergencyAppointment);
            DB.AddParameter("@Notes", mThisAppointment.Notes);
            //execute the stored procedure
            DB.Execute("sproc_tblAppointments_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisAppointment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AppointmentID", mThisAppointment.AppointmentNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblAppointments_Delete");
        }

        public void FilterByDate(string date)
        {
            //filters the records based on a date
            //try to convert to datetime
            DateTime nDate;
            try
            {
                nDate = Convert.ToDateTime(date);
            } catch
            {
                return;
            }
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@date", nDate);
            //execute stored procedure
            DB.Execute("sproc_tblAppointments_FilterByDate");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the amount of records
            RecordCount = DB.Count;
            //clear the private array list
            mAppointmentsList = new List<clsAppointments>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank appointment object
                clsAppointments AnAppointment = new clsAppointments();
                //read in the fields from the current record
                AnAppointment.PatientID = Convert.ToInt32(DB.DataTable.Rows[Index]["PatientID"]);
                AnAppointment.DoctorID = Convert.ToInt32(DB.DataTable.Rows[Index]["DoctorID"]);
                AnAppointment.DateOfAppointment = Convert.ToDateTime(DB.DataTable.Rows[Index]["AppointmentDate"]);
                AnAppointment.FloorNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["FloorNumber"]);
                AnAppointment.RoomNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomNumber"]);
                AnAppointment.EmergencyAppointment = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmergencyAppointment"]);
                AnAppointment.Notes = Convert.ToString(DB.DataTable.Rows[Index]["Notes"]);
                //add the record to the private data member
                mAppointmentsList.Add(AnAppointment);
                //point to the next record
                Index++;
            }
        }
    }
}