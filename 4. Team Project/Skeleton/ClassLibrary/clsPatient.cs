using System;
using System.Data;

namespace ClassLibrary
{
    public class clsPatient
    {
        //private data member for the patient id property
        private Int32 mPatientId;
        private string mPName;
        private string mPEmail;
        private DateTime mPDOB;
        private string mPHomeAdd;
        private bool mPAccessReq;
        private int? mPMainDocId;
        //patientId public property
        public Int32 PatientId
        {
            get
            {
                //this line of code sends data out of the property
                return mPatientId;
            }
            set
            {
                //this line of code allows data into the property
                mPatientId = value;
            }
        }
        public string PName
        {
            get
            {
                return mPName;
            }
            set
            {
                mPName = value;
            }
        }
        public string PEmail
        {
            get
            {
                return mPEmail;
            }
            set
            {
                mPEmail = value;
            }
        }
        public DateTime PDOB
        {
            get
            {
                return mPDOB;
            }
            set
            {
                mPDOB = value;
            }
        }
        public string PHomeAdd
        {
            get
            {
                return mPHomeAdd;
            }
            set
            {
                mPHomeAdd = value;
            }
        }
        public bool PAccessReq
        {
            get
            {
                return mPAccessReq;
            }
            set
            {
                mPAccessReq = value;
            }
        }
        public int? PMainDocId
        {
            get
            {
                return mPMainDocId;
            }
            set
            {
                mPMainDocId = value;
            }
        }

        public bool Find(int patientId)
        {
            //create an instance if the data connection
            clsDataConnection dB = new clsDataConnection();
            //add the param for new patient id to search for
            dB.AddParameter("@PatientId", patientId);
            //execute stored procedure
            dB.Execute("sproc_tblPatient_FilterByPatientId");
            //if one record is found(should be 1 or 0)
            if (dB.Count == 1)
            {
                //coppy the data from the database to the private data members
                mPatientId = Convert.ToInt32(dB.DataTable.Rows[0]["PatientId"]);
                mPName = Convert.ToString(dB.DataTable.Rows[0]["PName"]);
                mPEmail = Convert.ToString(dB.DataTable.Rows[0]["PEmail"]);
                mPDOB = Convert.ToDateTime(dB.DataTable.Rows[0]["PDOB"]);
                mPHomeAdd = Convert.ToString(dB.DataTable.Rows[0]["PHomeAdd"]);
                mPAccessReq = dB.DataTable.Rows[0]["PAccessReq"] != DBNull.Value && Convert.ToBoolean(dB.DataTable.Rows[0]["PAccessReq"]);
                mPMainDocId = dB.DataTable.Rows[0]["PMainDocId"] != DBNull.Value ?
                    Convert.ToInt32(dB.DataTable.Rows[0]["PMainDocId"]) : (int?)null;
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }
        }

        public string Valid(string patientName, string email, string address, string dateOfBirthStr, string drIdStr)
        {
            //create a string variable to store the error
            String error = "";
            //if the patientName is blank
            if (patientName.Length == 0)
            {
                //record error
                error += "The patient name may not be blank : ";
            }
            if(patientName.Length > 100)
            {
                //record error
                error += "The patient name may not be more than 100 char: ";
            }
            if (email.Length > 255)
            {
                error += "The email may not be more than 255 char: ";
            }
            if (address.Length > 125)
            {
                error += "The address may not be more than 125 char: ";
            }

            try
            {
                DateTime dateOfBirth = Convert.ToDateTime(dateOfBirthStr);
                if (dateOfBirth < Convert.ToDateTime("01/01/1884"))
                {
                    error += "The dateOfBirth may not be before 01/01/1884: ";
                }

                if (dateOfBirth > DateTime.Now.Date)
                {
                    error += "The dateOfBirth may be after todays date: ";
                }

            }   
            catch 
            {
                error += "The date was not a valid date: ";
            }

            try
            {
                Int32? drId = drIdStr.Trim().Length != 0 ? Convert.ToInt32(drIdStr) : (int?)null;
                if (drId.HasValue && drId < 1)
                {
                    error += "The doctor id have to be greater than 0 or not null: ";
                }
            }
            catch 
            {
                error    += "The doctor Id is an invalid data type or greater than Int32 max: ";
            }
            //return error message
            return error;
        }

        public DataTable StatisticsGroupedByDoctorId()
        {
            clsDataConnection dB = new clsDataConnection();
            dB.Execute("sproc_tblPatients_Count_GroupByMainDocId");
            return dB.DataTable;
        }

        public DataTable StatisticsGroupedByDOB()
        {
            clsDataConnection dB = new clsDataConnection();
            dB.Execute("sproc_tblPatients_Count_GroupDOB");
            return dB.DataTable;
        }
    }
}