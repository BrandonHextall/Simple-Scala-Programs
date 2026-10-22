using System;
using System.Data;
using System.Net.Http;

namespace ClassLibrary
{
    public class clsDoc
    {
        private Int32 doctorId;
        private Boolean doctorAvailability;
        private String doctorFirstName;
        private String doctorLastName;
        private String doctorAddress;
        private String doctorEmail;
        private String doctorPhoneNumber;
        private DateTime doctorDateAdded;

        public int dId
        {
            get {
                return doctorId;
            }
            set { 
                doctorId = value;
            }
        }
        public bool dAvailability
        {
            get
            {
                return doctorAvailability;
            }
            set
            {
                doctorAvailability = value;
            }
        }
        public string dPhoneNumber
        {
            get
            {
                return doctorPhoneNumber;
            }
            set
            {
                doctorPhoneNumber = value;
            }
        }
        public string dEmail
        {
            get
            {
                return doctorEmail;
            }
            set
            {
                doctorEmail = value;
            }
        }
        public string dAddress
        {
            get
            {
                return doctorAddress;
            }
            set
            {
                doctorAddress = value;
            }
        }
        public string dLastName
        {
            get
            {
                return doctorLastName;
            }
            set
            {
                doctorLastName = value;
            }
        }
        public string dFirstName
        {
            get
            {
                return doctorFirstName;
            }
            set
            {
                doctorFirstName = value;
            }
        }

        public DateTime DDateAdded
        {
            get
            {
                return doctorDateAdded;
            }
            set
            {
                doctorDateAdded = value;
            }
        }

        public bool Find(int docId)
        {

            // create an instance of a dataconnection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the address id to search for
            DB.AddParameter("@DoctorId", docId);
            // excute the stored procidure
            DB.Execute("sproc_tblDoctors_FilterByDoctorId");
            //  if one ecourd is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // coppy the data from the database to ht private data members
                doctorId = Convert.ToInt32(DB.DataTable.Rows[0]["DoctorId"]);
                doctorDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DDateAdded"]);
                doctorAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["DAvailability"]); 
                doctorFirstName = Convert.ToString(DB.DataTable.Rows[0]["DFirstName"]);
                doctorLastName = Convert.ToString(DB.DataTable.Rows[0]["DLastName"]);
                doctorAddress = Convert.ToString(DB.DataTable.Rows[0]["DAddress"]);
                doctorEmail = Convert.ToString(DB.DataTable.Rows[0]["DEmail"]);
                doctorPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["DPhoneNumber"]);
                return true;
            }
            // if no record was found
            else
            {
                // return false indicating there was a problem
                return false;
            }
           

        }

        public string isValid(string firstName, string lastName, string address, string email, string phoneNumber, string dateAdded)
        {
            // initiation of the string variable
            String message = "";
            //temp variable to store data values
            DateTime dateTemp;
            // check if ther is an entered first name
            if (firstName.Length < 1)
            {
                // ammend to the error message if there is an error
                message += "First name must not be empty : ";
            }
            if(firstName.Length > 100)
            {
                message += "Too long of a first name : ";
            }
            // lastname valid
            if (lastName.Length < 1)
            {
                message += "Last Name must not be empty : ";
            }
            if(lastName.Length > 100)
            {
                message += "Too long of a last name : ";
                
            }
            // address validation
            if (address.Length < 9)
            {
                message += "Addres must not be empty : ";
            }
            if (address.Length > 255)
            {
                message += "Too long of an address, go live somewhere else : ";

            }
            // email validation
            if (email.Length < 7 || email.Contains("@") == false)
            {
                message += "Not A valid email : ";
            }
            if(email.Length > 255)
            {
                message += "Email is too long : ";
            }
            // phone number validation
            if(phoneNumber.Length < 9)
            {
                message += "Phone number is not valid";
            }
            if(phoneNumber.Length > 50)
            {
                message += "Phone number is too long";
            }
            // date added validation
            dateTemp = Convert.ToDateTime(dateAdded);
            if(dateTemp < DateTime.Now.Date)
            {
                message += "Date cannot be in the past";
            }
            if (dateTemp > DateTime.Now.Date)
            {
                message += "Date cannot be in the future";
            }

            return message;
        }


        public DataTable StatisticsGroupedByLastName()
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // execute the stored procedure 
            DB.Execute("sproc_tblDoctors_Count_GroupByLastName");
            // there should be either zero, one, or more records

            DataTable table = new DataTable();
            table = DB.DataTable;
            return table;
        }

        public DataTable StatisticsGroupedByAvailability()
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // execute stored procedurte
            DB.Execute("sproc_tblDoctors_Count_GroupByAvailability");
            // there should be either zero, one, or more records

            DataTable table = new DataTable();
            table = DB.DataTable;
            return table;
        }
    }
}