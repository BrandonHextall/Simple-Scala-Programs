using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsPatientCollection
    {
        List<clsPatient> mPatientList = new List<clsPatient>();
        clsPatient mThisPatient = new clsPatient();

        public List<clsPatient> PatientList
        {
            get
            {
                return mPatientList;
            }
            set
            {
                mPatientList = value;
            }
        }

        public int Count
        {
            get
            {
                return mPatientList.Count;
            }
            set
            {
                //worry about this later
            }
        }

        public clsPatient ThisPatient 
        { 
            get
            {
                return mThisPatient;
            }
            set
            {
                mThisPatient = value;
            } 
        }
        //constructor
        public clsPatientCollection()
        {
            //object for the new data connect
            clsDataConnection dB = new clsDataConnection();
            //execute stored procedure
            dB.Execute("sproc_tblPatients_SelectAll");
            //populate the array list with the data table
            PopulateArray(dB);
        }

        public int Add()
        {
            clsDataConnection dB = new clsDataConnection();
            //set the parameters for the stored procedure
            dB.AddParameter("@PName", mThisPatient.PName);
            dB.AddParameter("@PEmail", mThisPatient.PEmail);
            dB.AddParameter("@PDOB", mThisPatient.PDOB);
            dB.AddParameter("@PHomeAdd", mThisPatient.PHomeAdd);
            dB.AddParameter("@PAccessReq",  mThisPatient.PAccessReq);
            dB.AddParameter("@PMainDocId", mThisPatient.PMainDocId != null ?
                (object)mThisPatient.PMainDocId : DBNull.Value);

            return dB.Execute("sproc_tblPatient_Insert");
        }

        public void Update()
        {
            clsDataConnection dB = new clsDataConnection();
            //set the parameters for the stored procedure
            dB.AddParameter("@PatientId", mThisPatient.PatientId);
            dB.AddParameter("@PName", mThisPatient.PName);
            dB.AddParameter("@PEmail", mThisPatient.PEmail);
            dB.AddParameter("@PDOB", mThisPatient.PDOB);
            dB.AddParameter("@PHomeAdd", mThisPatient.PHomeAdd);
            dB.AddParameter("@PAccessReq", mThisPatient.PAccessReq);
            dB.AddParameter("@PMainDocId", mThisPatient.PMainDocId != null ?
                (object)mThisPatient.PMainDocId : DBNull.Value);

            dB.Execute("sproc_tblPatient_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisPatient
            //connect to the database
            clsDataConnection dB = new clsDataConnection();
            //set params for the stored procedure
            dB.AddParameter("@PatientId", mThisPatient.PatientId);
            //execute the stored procedure
            dB.Execute("sproc_tblPatients_Delete");
        }

        public void ReportByName(string pName)
        {
            //filters the records based on a full or partial name
            clsDataConnection dB = new clsDataConnection();
            dB.AddParameter("@PName", pName);
            dB.Execute("sproc_tblPatients_FilterByName");
            //populate the array list the data table
            PopulateArray(dB);
        }

        void PopulateArray(clsDataConnection dB)
        {
            //variable for the index
            int Index = 0;
            //variable to store the record 
            int RecordCount = dB.Count;
            //While there are records to process
            mPatientList = new List<clsPatient>();
            while (Index < RecordCount)
            {
                //create blank address
                clsPatient aPatient = new clsPatient
                {
                    PatientId = Convert.ToInt32(dB.DataTable.Rows[Index]["PatientId"]),
                    PName = Convert.ToString(dB.DataTable.Rows[Index]["PName"]),
                    PEmail = Convert.ToString(dB.DataTable.Rows[Index]["PEmail"]),
                    PDOB = Convert.ToDateTime(dB.DataTable.Rows[Index]["PDOB"]),
                    PHomeAdd = Convert.ToString(dB.DataTable.Rows[Index]["PHomeAdd"]),
                    PAccessReq = dB.DataTable.Rows[Index]["PAccessReq"] != DBNull.Value && Convert.ToBoolean(dB.DataTable.Rows[Index]["PAccessReq"]),
                    PMainDocId = dB.DataTable.Rows[Index]["PMainDocId"] != DBNull.Value ?
                        Convert.ToInt32(dB.DataTable.Rows[Index]["PMainDocId"]) : (int?)null
                };
                //add the record to the private data member
                mPatientList.Add(aPatient);
                //point at the next record
                Index++;
            }
        }
    }
}