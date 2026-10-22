using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsDoctorCollection
    {
        List<clsDoc> mDoctorsList = new List<clsDoc>();
        // private data member for this address
        clsDoc mThisDoctor = new clsDoc();

        public List<clsDoc> doctorList
        {
            get
            {
                return mDoctorsList;
            }
            set
            {
                mDoctorsList = value;
            }
        }
        public int count
        {
            get
            {
                return mDoctorsList.Count;
            }
            set
            {
               
            }
        }
        public clsDoc thisDoctor {

            get
            {
                return mThisDoctor;
            }
            set
            {
                mThisDoctor = value;
            }

        }

        // constructor for the class
        public clsDoctorCollection()
        {
            // object for the data connect
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblDoctors_selectAll");
            // populate array list with data table
            PopulateArray(DB);
        }

        public int Add()
        {
            // adds a record to the database based on the values of mThisDoctor
            // connect ot the databse
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@DFirstName", mThisDoctor.dFirstName);
            DB.AddParameter("@DLastName", mThisDoctor.dLastName);
            DB.AddParameter("@DAddress", mThisDoctor.dAddress);
            DB.AddParameter("@DEmail", mThisDoctor.dEmail);
            DB.AddParameter("@DPhoneNumber", mThisDoctor.dPhoneNumber);
            DB.AddParameter("@DAvailability", mThisDoctor.dAvailability);
            DB.AddParameter("@DDateAdded", mThisDoctor.DDateAdded);

            // execute the query retuning the primary key value
            return DB.Execute("sproc_tblDoctors_Insert");
        }

        public void Update()
        {
            // update an existing reecord based on the values of this doctor
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the new stored procedure
            DB.AddParameter("@DoctorId", mThisDoctor.dId);
            DB.AddParameter("@DFirstName", mThisDoctor.dFirstName);
            DB.AddParameter("@DLastName", mThisDoctor.dLastName);
            DB.AddParameter("@DAddress", mThisDoctor.dAddress);
            DB.AddParameter("@DEmail", mThisDoctor.dEmail);
            DB.AddParameter("@DPhoneNumber", mThisDoctor.dPhoneNumber);
            DB.AddParameter("@DAvailability", mThisDoctor.dAvailability);
            DB.AddParameter("@DDateAdded", mThisDoctor.DDateAdded);
            // execute the stored procedure
            DB.Execute("sproc_tblDoctors_Update");
        }

        public void Delete()
        {
            // deletes the record pointed to by this doctor
            // connect to th e database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedur
            DB.AddParameter("@DoctorId", mThisDoctor.dId);
            // execute the stored procedure
            DB.Execute("sproc_tblDoctors_Delete");
        }

        public void FilterByLastName(string lastName)
        {
            // filters the record based on afull or partial Last name
            // connect to th database 
            clsDataConnection DB = new clsDataConnection();
            // send the postcode parameter to the database
            DB.AddParameter("@DLastName", lastName);
            // execute stored procedure
            DB.Execute("sproc_tblDoctors_FilterByLastName");
            // populate array list with the data table
            PopulateArray(DB);  
        }

        void PopulateArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB
            // varoable for index
            Int32 index = 0;
            // variable to store the record count
            Int32 recordCount;
            //get the count  of records
            recordCount = DB.Count;
            // clear the private array list
            mDoctorsList = new List<clsDoc>();
            // while there are records to process
            while (index < recordCount)
            {
                // create a blank address object
                clsDoc someDoctor = new clsDoc();
                // read in the fields from the current record
                someDoctor.dId = Convert.ToInt32(DB.DataTable.Rows[index]["DoctorId"]);
                someDoctor.dFirstName = Convert.ToString(DB.DataTable.Rows[index]["DFirstName"]);
                someDoctor.dLastName = Convert.ToString(DB.DataTable.Rows[index]["DLastName"]);
                someDoctor.dAddress = Convert.ToString(DB.DataTable.Rows[index]["DAddress"]);
                someDoctor.dEmail = Convert.ToString(DB.DataTable.Rows[index]["DEmail"]);
                someDoctor.dPhoneNumber = Convert.ToString(DB.DataTable.Rows[index]["DPhoneNumber"]);
                someDoctor.dAvailability = Convert.ToBoolean(DB.DataTable.Rows[index]["DAvailability"]);
                someDoctor.DDateAdded = Convert.ToDateTime(DB.DataTable.Rows[index]["DDateAdded"]);
                // add the record to the private data member
                mDoctorsList.Add(someDoctor);
                // point at next record
                index++;
            }
        }
    }
}