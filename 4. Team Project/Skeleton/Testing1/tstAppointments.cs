using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Testing1
{
    [TestClass]
    public class TstAppointments
    {
        //good test data
        //create some test data to pass to the method
        string PatientFirstName = "John";
        string PatientLastName = "Doe";
        string DateOfAppointment = DateTime.Now.Date.ToString();
        string TimeOfAppointment = new TimeSpan(13, 0, 0).ToString();
        string FloorNumber = "2";
        string RoomNumber = "2";
        string EmergencyAppointment = "true";
        string Notes = "This is a test note.";
        /*********************INSTANCE OF THE CLASS TEST*********************/
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //test to see that it exists
            Assert.IsNotNull(AnAppointment);
        }
        /***********************PROPERTY OK TESTS***********************/
        [TestMethod]
        public void AppointmentNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnAppointment.AppointmentNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.AppointmentNumber, TestData);
        }
        [TestMethod]
        public void DoctorIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnAppointment.DoctorID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.DoctorID, TestData);
        }
        [TestMethod]
        public void PatientFirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            string TestData = "John";
            //assign the data to the property
            AnAppointment.PatientFirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.PatientFirstName, TestData);
        }
        [TestMethod]
        public void PatientLastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            string TestData = "Doe";
            //assign the data to the property
            AnAppointment.PatientLastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.PatientLastName, TestData);
        }
        [TestMethod]
        public void DateOfAppointmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAppointment.DateOfAppointment = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.DateOfAppointment, TestData);
        }
        [TestMethod]
        public void TimeOfAppointmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            TimeSpan TestData = new TimeSpan(5, 0, 0);
            //assign the data to the property
            AnAppointment.TimeOfAppointment = TestData;
            //test to see that the two values are the same
            Console.WriteLine(AnAppointment.TimeOfAppointment);
            Assert.AreEqual(AnAppointment.TimeOfAppointment, TestData);
        }
        [TestMethod]
        public void FloorNUmberPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnAppointment.FloorNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.FloorNumber, TestData);
        }
        [TestMethod]
        public void RoomNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnAppointment.RoomNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.RoomNumber, TestData);
        }
        [TestMethod]
        public void EmergencyAppointmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnAppointment.EmergencyAppointment = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.EmergencyAppointment, TestData);
        }
        [TestMethod]
        public void NotesPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            string TestData = "This is a test note.";
            //assign the data to the property
            AnAppointment.Notes = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.Notes, TestData);
        }
        /***********************PROPERTY DATA TESTS***********************/
        [TestMethod]
        public void TestAppointmentNumberFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentNumber = 2;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNumber);
            //check the appointment number
            if (AnAppointment.AppointmentNumber != AppointmentNumber)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        /*[TestMethod]
        public void TestPatientFirstNameFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentNumber = 2;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNumber);
            //check the patient first name
            if (AnAppointment.PatientFirstName != "David")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPatientLastNameFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentNumber = 2;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNumber);
            //check the patient last name
            if (AnAppointment.PatientLastName != "Johnston")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }*/
        [TestMethod]
        public void TestDoctorIDFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentNumber = 1;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNumber);
            //check the doctor id
            if (AnAppointment.DoctorID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPatientIDFound()
        {
            //create and instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentNumber = 1;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNumber);
            //check the patient ID
            if (AnAppointment.PatientID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfAppointmentFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentNumber = 2;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNumber);
            //check the dateof appointment
            if (AnAppointment.DateOfAppointment == null)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTimeOfAppointmentFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentNumber = 2;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNumber);
            //check the appointment time
            if (!(AnAppointment.TimeOfAppointment is TimeSpan))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFloorNumberFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentNumber = 2;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNumber);
            //check the floor number
            if (!(AnAppointment.FloorNumber is int))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestRoomNumberFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentNumber = 2;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNumber);
            //check the room number
            if (!(AnAppointment.RoomNumber is int))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmergencyAppointmentFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentNumber = 2;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNumber);
            //check the boolean
            if (!(AnAppointment.EmergencyAppointment is bool))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNotesFound()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AppointmentNumber = 2;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNumber);
            //check the notes
            if (AnAppointment.Notes == null)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        /****************MID MIN MAX PLUSONE LESSONE TESTS****************/
        /********PATIENT FIRST NAME********/
        [TestMethod]
        public void PatientFirstNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientFirstName = ""; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientFirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientFirstName = ""; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientFirstNameMin()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientFirstName = "J"; //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientFirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientFirstName = "Jo"; //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientFirstNameMid()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String PatientFirstName = "Maximilianaeuphrasiatheresaalexandriettavalerineph"; //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientFirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientFirstName = "".PadRight(99, 'a'); //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientFirstNameMax()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientFirstName = "".PadRight(100, 'a'); //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientFirstName = "".PadRight(101, 'a'); //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientFirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientFirstName = "".PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientFirstNameInvalid()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientFirstName = "John123"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Console.WriteLine(Error);
            Assert.AreNotEqual(Error, "");
        }
        /********PATIENT LAST NAME********/
        [TestMethod]
        public void PatientLastNameExtremeMin()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientLastName = ""; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientLastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientLastName = ""; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientLastNameMin()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientLastName = "J"; //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientLastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientLastName = "Jo"; //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientLastNameMid()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String PatientLastName = "".PadRight(50, 'a'); //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientLastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientLastName = "".PadRight(99, 'a'); //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientLastNameMax()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientLastName = "".PadRight(100, 'a'); //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientLastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientLastName = "".PadRight(101, 'a'); //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientLastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientLastName = "".PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientLastNameInvalid()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientLastName = "John123"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Console.WriteLine(Error);
            Assert.AreNotEqual(Error, "");
        }
        /********Appointment Date********/
        [TestMethod]
        public void AppointmentDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime DateOfAppointment = DateTime.Now; //this should trigger an error
            //change date to -100 years
            DateOfAppointment = DateOfAppointment.AddYears(-100);
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment.ToString(), TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime DateOfAppointment = DateTime.Now.Date.AddDays(-1); //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment.ToString(), TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateMin()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime DateOfAppointment = DateTime.Now.Date; //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment.ToString(), TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime DateOfAppointment = DateTime.Now.Date.AddDays(1); //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment.ToString(), TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointDateMid()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime DateOfAppointment = DateTime.Now.Date.AddDays(30); //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment.ToString(), TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime DateOfAppointment = DateTime.MaxValue; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment.ToString(), TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime DateOfAppointment = DateTime.Now.AddYears(1).AddDays(-1); //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment.ToString(), TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateMax()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime DateOfAppointment = DateTime.Now.AddYears(1); //this should be OK
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment.ToString(), TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime DateOfAppointment = DateTime.Now.AddYears(1).AddDays(1); //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment.ToString(), TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointDateInvalid()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String DateOfAppointment = "This aint no date"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /********Appointment Time********/
        [TestMethod]
        public void AppointmentTimeExtremeMin()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TimeOfAppointment = new TimeSpan(0, 0, 0).ToString(); //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMinLessOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TimeOfAppointment = new TimeSpan(8, 59, 0).ToString(); //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMin()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TimeOfAppointment = new TimeSpan(9, 0, 0).ToString(); //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMinPlusOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TimeOfAppointment = new TimeSpan(9, 0, 1).ToString(); //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMid()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TimeOfAppointment = new TimeSpan(13, 0, 0).ToString(); //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeExtremeMax()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TimeOfAppointment = new TimeSpan(24, 0, 0).ToString(); //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMaxLessOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TimeOfAppointment = new TimeSpan(16, 59, 59).ToString(); //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMax()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TimeOfAppointment = new TimeSpan(17, 0, 0).ToString(); //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMaxPlusOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TimeOfAppointment = new TimeSpan(17, 1, 0).ToString(); //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeInvalid()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String TimeOfAppointment = "This aint no TimeSpan"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /********Floor Number********/
        [TestMethod]
        public void FloorNumberExtremeMin()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FloorNumber = "-1"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FloorNumberMinLessOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FloorNumber = "-1"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FloorNumberMin()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FloorNumber = "0"; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FloorNumberMinPlusOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FloorNumber = "1"; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FloorNumberMid()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FloorNumber = "3"; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FloorNumberExtremeMax()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FloorNumber = "100"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FloorNumberMaxLessOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FloorNumber = "4"; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FloorNumberMax()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FloorNumber = "5"; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FloorNumberMaxPlusOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FloorNumber = "6"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FloorNumberInvalid()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FloorNumber = "this ain't no floor number"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /********Room Number********/
        [TestMethod]
        public void RoomNumberExtremeMin()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomNumber = "-1"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomNumberMinLessOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomNumber = "0"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomNumberMin()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomNumber = "1"; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoomNumberMinPlusOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomNumber = "2"; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoomNumberMid()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomNumber = "50"; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoomNumberExtremeMax()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomNumber = "1000"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomNumberMaxLessOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomNumber = "99"; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoomNumberMax()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomNumber = "100"; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoomNumberMaxPlusOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomNumber = "101"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomNumberInvalid()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RoomNumber = "this ain't no room number"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /********Emergency********/
        [TestMethod]
        public void EmergencyAppointmentInvalid()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmergencyAppointment = "this ain't no boolean"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /********Notes********/
        [TestMethod]
        public void NotesExtremeMin()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Notes = ""; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NotesMinLessOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Notes = ""; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NotesMin()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Notes = "I"; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NotesMinPlusOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Notes = "In"; //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NotesMid()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Notes = "".PadRight(250, 'a'); //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NotesExtremeMax()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Notes = "".PadRight(1000, 'a'); //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NotesMaxLessOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Notes = "".PadRight(499, 'a'); //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NotesMax()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Notes = "".PadRight(500, 'a'); //this should pass
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NotesMaxPlusOne()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Notes = "".PadRight(501, 'a'); //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NotesInvalid()
        {
            //create instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Notes = ".....23615134"; //this should trigger an error
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /********Emergency Appointment********/
        /************************VALID METHOD TESTS***********************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AppointmentNumber = 2;
            //invoke the method
            Found = AnAppointment.Find(AppointmentNumber);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientFirstName = "John";
            string PatientLastName = "Doe";
            string DateOfAppointment = DateTime.Now.Date.ToString();
            string TimeOfAppointment = new TimeSpan(10, 0, 0).ToString();
            string FloorNumber = "1";
            string RoomNumber = "2";
            string EmergencyAppointment = "true";
            string Notes = "This is a test note.";
            //invoke the method
            Error = AnAppointment.Valid(PatientFirstName, PatientLastName, DateOfAppointment, TimeOfAppointment, FloorNumber, RoomNumber, Notes, EmergencyAppointment);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /********** Statistics Function Tests **********/
        [TestMethod]
        public void StatStatisticsGroupedByEmergency()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            int noOfRecords = 2;
            //invoke the method
            DataTable dT = AnAppointment.StatisticsGroupedByEmergency();
            //test to see that the result is correct
            Assert.AreEqual(noOfRecords, dT.Rows.Count);
        }
        [TestMethod]
        public void StatStatisticsGroupedByDoctor()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            int noOfRecords = 3;
            //invoke the method
            DataTable dT = AnAppointment.StatisticsGroupedByDoctor();
            //test to see that the result is correct
            Assert.AreEqual(noOfRecords, dT.Rows.Count);
        }
        [TestMethod]
        public void StatStatisticsGroupedByDate()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            int noOfRecords = 9;
            //invoke the method
            DataTable dT = AnAppointment.StatisticsGroupedByDate();
            //test to see that the result is correct
            Assert.AreEqual(noOfRecords, dT.Rows.Count);
        }
        [TestMethod]
        public void StatStatisticsGroupedByFloorNumber()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            int noOfRecords = 2;
            //invoke the method
            DataTable dT = AnAppointment.StatisticsGroupedByFloorNumber();
            //test to see that the result is correct
            Assert.AreEqual(noOfRecords, dT.Rows.Count);
        }
        [TestMethod]
        public void StatStatisticsGroupedByRoomNumber()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //boolean variable to store the results of the validation
            int noOfRecords = 3;
            //invoke the method
            DataTable dT = AnAppointment.StatisticsGroupedByRoomNumber();
            //test to see that the result is correct
            Assert.AreEqual(noOfRecords, dT.Rows.Count);
        }
    }
}
