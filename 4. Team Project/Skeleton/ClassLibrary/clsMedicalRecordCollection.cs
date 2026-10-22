using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsMedicalRecordCollection
    {



        // backing fields
        private List<clsMedicalRecords> mMedicalRecordList = new List<clsMedicalRecords>();
        private clsMedicalRecords mThisMedicalRecord = new clsMedicalRecords();

      
        
            // construction for the class
            public clsMedicalRecordCollection()
            {
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblmedicalRecords_SelectAll");
            // populate the array list with the data table
            PopulateArray(DB);
            }
     

        public List<clsMedicalRecords> MedicalRecordList
        {
            get => mMedicalRecordList;
            set => mMedicalRecordList = value ?? new List<clsMedicalRecords>(); // need to re look into this 
        }

        public int Count
        {
            get => mMedicalRecordList.Count;
            set { /* setter intentionally left blank or can be removed */ }
        }

        public clsMedicalRecords ThisMedicalRecord
        {
            get => mThisMedicalRecord;
            set => mThisMedicalRecord = value;
        }

        public int Add()
        {
            
         // adds the record to the database on the values of mThisMedicalRecord
         //connect to the db
         clsDataConnection DB = new clsDataConnection();
         //set the primary key value of the new record
         DB.AddParameter("@patientId", mThisMedicalRecord.patientId);
         DB.AddParameter("@AppID", mThisMedicalRecord.AppID);
         DB.AddParameter("@PendingApp", mThisMedicalRecord.PendingApp);
         DB.AddParameter("@AppNotes", mThisMedicalRecord.AppNotes);
         DB.AddParameter("@doctorId", mThisMedicalRecord.doctorId);
         DB.AddParameter("@Date", mThisMedicalRecord.Date);
            // execute the query returning the primart key valuse
            return DB.Execute("sproc_tblmedicalRecords_Insert");
            
        }

        public void Delete()
        {
            // deletes the record pointed to by ThisMedicalRecord
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the primary key value of the record to delete
            DB.AddParameter("@recordId", mThisMedicalRecord.recordId);
            // execute the query
            DB.Execute("sproc_tblmedicalRecords_Delete");


        }

        public void ReportByPendingApp(string PendingApp)
        {
            // pending appointment filter for the records
            clsDataConnection DB = new clsDataConnection();

            // no filter -> return all records
            if (string.IsNullOrWhiteSpace(PendingApp))
            {
                DB.Execute("sproc_tblmedicalRecords_SelectAll");
                PopulateArray(DB);
                return;
            }

            // try to interpret the incoming value as a boolean
            if (!bool.TryParse(PendingApp, out bool pendingValue))
            {
                // invalid filter value (e.g. "xxx") -> return an empty list (test expects 0 results)
                mMedicalRecordList = new List<clsMedicalRecords>();
                return;
            }

            // valid boolean: run the filtered stored procedure and populate the collection
            DB.AddParameter("@PendingApp", pendingValue);
            DB.Execute("sproc_tblmedicalRecords_FilterByPendingApp");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB
            // var to store the index for the loop
            Int32 Index = 0;
            // var to store the record count
            Int32 RecordCount = DB.Count;
            // clear the private array list
            mMedicalRecordList = new List<clsMedicalRecords>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank medical record
                clsMedicalRecords AnMedicalRecord = new clsMedicalRecords();
                // read in the fields from the current record
                AnMedicalRecord.recordId = Convert.ToInt32(DB.DataTable.Rows[Index]["recordId"]);
                AnMedicalRecord.patientId = Convert.ToInt32(DB.DataTable.Rows[Index]["patientId"]);
                AnMedicalRecord.AppID = Convert.ToInt32(DB.DataTable.Rows[Index]["AppID"]);
                AnMedicalRecord.PendingApp = Convert.ToBoolean(DB.DataTable.Rows[Index]["PendingApp"]);
                AnMedicalRecord.AppNotes = Convert.ToString(DB.DataTable.Rows[Index]["AppNotes"]);
                AnMedicalRecord.doctorId = Convert.ToInt32(DB.DataTable.Rows[Index]["doctorId"]);
                AnMedicalRecord.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                // add the record to the private array list
                mMedicalRecordList.Add(AnMedicalRecord);
                // point to the next record
                Index++;
            }
        }

        public void Update()
        {
            // update an existing record based on the values of ThisMedicalRecord
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@recordId", mThisMedicalRecord.recordId);
            DB.AddParameter("@patientId", mThisMedicalRecord.patientId);
            DB.AddParameter("@AppID", mThisMedicalRecord.AppID);
            DB.AddParameter("@PendingApp", mThisMedicalRecord.PendingApp);
            DB.AddParameter("@AppNotes", mThisMedicalRecord.AppNotes);
            DB.AddParameter("@doctorId", mThisMedicalRecord.doctorId);
            DB.AddParameter("@Date", mThisMedicalRecord.Date);
            // execute the stored procedure
            DB.Execute("sproc_tblmedicalRecords_Update");
        }
    }
}