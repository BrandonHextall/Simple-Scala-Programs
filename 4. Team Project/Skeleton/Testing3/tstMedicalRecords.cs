using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.Design;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Testing3
{
    [TestClass]
    public class tstMedicalRecords
    {
        // good test data
        string AppNotes = "This is a test note";
        string Date = DateTime.Now.Date.ToString();
        string pendingApp = true.ToString();
        string DoctorID = 1.ToString();
        string PatientID = 1.ToString();
        string AppID = 1.ToString();
        string RecordID = 1.ToString();


        [TestMethod]
        public void ImstanceOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //test to see that it exists
            Assert.IsNotNull(AMedicalRecords);
        }

        [TestMethod]
        public void RecordIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMedicalRecords.recordId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.recordId, TestData);
        }

        [TestMethod]
        public void PatientIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMedicalRecords.patientId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.patientId, TestData);
        }
        [TestMethod]
        public void DoctorIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMedicalRecords.DoctorID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.DoctorID, TestData);
        }
        [TestMethod]
        public void AppIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMedicalRecords.appID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.appID, TestData);
        }
        [TestMethod]
        public void DatePropertyOk()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AMedicalRecords.Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.Date, TestData);
        }

        [TestMethod]
        public void PendingAppPropertyOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AMedicalRecords.pendingApp = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.pendingApp, TestData);
        }


        [TestMethod]
        public void AppNotesPropertyOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            string TestData = "This is a test note";
            //assign the data to the property
            AMedicalRecords.appNotes = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.appNotes, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 recordId = 1;
            //invoke the method
            Found = AMedicalRecords.Find(recordId);
            //test to see that the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestRecordIDFound()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            // create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 recordId = 1;
            //invoke the method
            Found = AMedicalRecords.Find(recordId);
            //check the record id
            if (AMedicalRecords.recordId != 1)
            {
                OK = false;
            }
            //return the result of the test
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPatientIDFound()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            // create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 recordId = 1;
            //invoke the method
            Found = AMedicalRecords.Find(recordId);
            //check the patient id
            if (AMedicalRecords.patientId != 456)
            {
                OK = false;
            }
            //return the result of the test
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDoctorIDFound()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            // create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 recordId = 1;
            //invoke the method
            Found = AMedicalRecords.Find(recordId);
            //check the doctor id
            if (AMedicalRecords.doctorId != 123)
            {
                OK = false;
            }
            //return the result of the test
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestAppIDFound()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            // create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 recordId = 1;
            //invoke the method
            Found = AMedicalRecords.Find(recordId);
            //check the app id
            if (AMedicalRecords.appID != 1)
            {
                OK = false;
            }
            //return the result of the test
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void pendingAppFound()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            // create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 recordId = 1;
            //invoke the method
            Found = AMedicalRecords.Find(recordId);
            //check the pending app
            if (AMedicalRecords.pendingApp != true)
            {
                OK = false;
            }
            //return the result of the test
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void AppNotesFound()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            // create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 recordId = 1;
            //invoke the method
            Found = AMedicalRecords.Find(recordId);
            //check the app notes
            if (AMedicalRecords.appNotes != "Test note")
            {
                OK = false;
            }
            //return the result of the test
            Assert.IsTrue(OK);
        }

        // valid method tests

        [TestMethod]
        public void validMethodOk()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        // record id tests //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        [TestMethod]
        public void RecordIDmin()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RecordID = "1";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, RecordID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RecordIDMinPlusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RecordID = "2";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, RecordID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RecordIDMaxLessOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RecordID = "999";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, RecordID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RecordIDMax()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RecordID = "1000";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, RecordID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RecordIDMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RecordID = "1001";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, RecordID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void RecordIDMaxMid()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RecordID = "500";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, RecordID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RecordIDMaxExtreme()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string RecordID = "5000";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, RecordID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        // doctor tests //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void DoctorIDMinMax()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DoctorID = "1";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DoctorIDminMinusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DoctorID = "1";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DoctorIDminPlusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DoctorID = "2";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DoctorIDMaxMin1()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DoctorID = "99";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DoctorIDMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DoctorID = "101";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DoctorIDMax()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DoctorID = "100";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DoctorIDMaxExtream()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DoctorID = "500";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DoctorIDMid()
        {
            //create am instance of the class we want to create 
            clsMedicalRecords AmedicalRecords = new clsMedicalRecords();
            // string cariable to store any error message in 
            string Error = "";
            // create some test data to pass to the method
            string DoctorID = "500";
            //invoke the method
            Error = AmedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Patient tests //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void PatientIDMinMax()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientID = "1";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIDminMinusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientID = "1";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIDminPlusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientID = "2";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientIDMaxMin1()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientID = "99";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientIDMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientID = "101";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientIDMax()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientID = "100";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIDMaxExtream()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientID = "500";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIDMid()
        {
            //create am instance of the class we want to create 
            clsMedicalRecords AmedicalRecords = new clsMedicalRecords();
            // string cariable to store any error message in 
            string Error = "";
            // create some test data to pass to the method
            string PatientID = "500";
            //invoke the method
            Error = AmedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        // app ID tests ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void AppIDMinMax()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppID = "1";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AppIDminMinusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppID = "1";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AppIDminPlusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppID = "2";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppIDMaxMin1()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppID = "99";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppIDMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppID = "101";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppIDMax()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppID = "100";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AppIDMaxExtream()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppID = "500";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AppIDMid()
        {
            //create am instance of the class we want to create 
            clsMedicalRecords AmedicalRecords = new clsMedicalRecords();
            // string cariable to store any error message in 
            string Error = "";
            // create some test data to pass to the method
            string AppID = "500";
            //invoke the method
            Error = AmedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        // app notes tests ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void AppNotesMinMax()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppNotes = "";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AppNotesminMinusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppNotes = "";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AppNotesminPlusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppNotes = "a";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppNotesMaxMin1()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppNotes = "a * 999";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppNotesMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppNotes = "a * 1001";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppNotesMax()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppNotes = "a * 1000";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AppNotesMaxExtream()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppNotes = "a * 5000";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AppNotesMid()
        {
            //create am instance of the class we want to create 
            clsMedicalRecords AmedicalRecords = new clsMedicalRecords();
            // string cariable to store any error message in 
            string Error = "";
            // create some test data to pass to the method
            string AppNotes = "a * 500";
            //invoke the method
            Error = AmedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        // date tests ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // date temp 
        public void DateTemp()
        {
            //create a variable to store the date
            DateTime DateTemp;
            //set the date to todays date
            DateTemp = DateTime.Now.Date;
            //check if the date is less than todays date
            if (DateTemp < DateTime.Now.Date) ;

        }
        [TestMethod]
        public void DateMin()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //Convert the date to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateMax()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            // set the date to todays date 
            DateTime TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years 
            TestDate = TestDate.AddYears(100);
            //convert to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the date
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus one day
            TestDate = TestDate.AddDays(1);
            //convert the date to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateminMinusOne()
        {
            //create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the date
            DateTime TestDate;
            // set date to todays date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is minus one day
            TestDate = TestDate.AddDays(-1);
            //convert the date to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            // set the date to todays date
            DateTime TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus one year
            TestDate = TestDate.AddYears(-1);
            //convert to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            // set the date to todays date
            DateTime TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 101 years
            TestDate = TestDate.AddYears(101);
            //convert to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMaxExtreme()
        {
            //create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            // set the date to todays date
            DateTime TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(500);
            //convert to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMid()
        {
            //create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            // set the date to todays date
            DateTime TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 50 years
            TestDate = TestDate.AddYears(50);
            //convert to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        // all of the invalid data tests 

        [TestMethod]
        public void DateInvalidData()
        {
            //create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Date = "this is not a date";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DoctorIDInvalidData()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DoctorID = "this is not a doctor ID";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PatientIDInvalidData()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PatientID = "this is not a patient ID";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AppIDInvalidData()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppID = "this is not a Appointment ID";
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AppNotesInvalidData()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AppNotes = new string('a', 1001);
            //invoke the method
            Error = AMedicalRecords.Valid(AppNotes, Date, pendingApp, DoctorID, PatientID, AppID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StatisticsGroupedBypatientID()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            // invoke the method
            DataTable dT = AMedicalRecords.StatisticsGroupedBypatientId();
            // according to the last test they should see 5 records in the database
            int noOfRecords = 5;

            // test to see that the result is correct
            Assert.AreEqual(noOfRecords, dT.Rows.Count);
        }



        //pending app tests //////////////////////////////////////////////////////////////////////////////////////////////////////////

        // -- dont do that shi

    }
    }
