using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.IO;

namespace Testing5
{
    [TestClass]
    public class tstDoc
    {
        // some good test data
        Int32 doctorId = 1;
        String firstName = "Atana";
        String lastName = "gran";
        String address = "78 Bnull Rd";
        String email = "Agran@gmail.com";
        String phoneNumber = "123456789";
        String dateAdded = DateTime.Now.Date.ToString();
        Boolean available = true;


        [TestMethod]
        public void InstanceOk()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // check to see if it exists
            Assert.IsNotNull(newDoctor);

        }

        [TestMethod]
        public void DoctorIdOk()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();

            Int32 testData = 1;
            // initialising test data
            newDoctor.dId = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dId, testData);

        }

        [TestMethod]
        public void DAvailabilityOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            Boolean testData = true;
            // initialising test data
            newDoctor.dAvailability = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dAvailability, testData);

        }

        [TestMethod]
        public void DPhoneNumberOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "07982651421";
            // setting field to test data
            newDoctor.dPhoneNumber = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dPhoneNumber, testData);

        }

        [TestMethod]
        public void DEmailOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "doctor@gmail.com";
            // setting field to test data
            newDoctor.dEmail = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dEmail, testData);

        }

        [TestMethod]
        public void DAddressOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "81 leister drive";
            // setting field to test data
            newDoctor.dAddress = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dAddress, testData);

        }

        [TestMethod]
        public void DLastNameOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "Nullan";
            // setting field to test data
            newDoctor.dLastName = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dLastName, testData);

        }

        [TestMethod]
        public void DFirstNameOK()
        {
            //  create a new instance of a doctor
            clsDoc newDoctor = new clsDoc();
            // initialising test data
            String testData = "Nullan";
            // setting field to test data
            newDoctor.dFirstName = testData;
            // check to see if test data and the field is the same/correct
            Assert.AreEqual(newDoctor.dFirstName, testData);

        }

        [TestMethod]
        public void FindOk()
        {
            // new instance of doctor
            clsDoc aDoc = new clsDoc();
            // example doc id
            Int32 docId = 2;
            // found boolean
            Boolean found = false;
            // invoke the method
            found = aDoc.Find(docId);
            //test to see if found is true
            Assert.IsTrue(found);

        }

        [TestMethod]
        public void TestDocIdFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 docId = 1;
            // invoke the method
            found = aDoc.Find(docId);
            // chaeck the doc Id
            if (aDoc.dId != 1)
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 DoctorId = 1;
            // invoke the method
            found = aDoc.Find(DoctorId);
            // check FirstName property
            if (aDoc.dFirstName != "Thomas")
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestLastNameFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 DoctorId = 1;
            // invoke the method
            found = aDoc.Find(DoctorId);
            // check LastName property
            if (aDoc.dLastName != "Hague")
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestAddressFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 DoctorId = 1;
            // invoke the method
            found = aDoc.Find(DoctorId);
            // check Address property
            if (aDoc.dAddress != "77 nullviewrd n23ard")
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestEmailFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 DoctorId = 1;
            // invoke the method
            found = aDoc.Find(DoctorId);
            // check Email property
            if (aDoc.dEmail != "Thague@gmail.com")
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 DoctorId = 1;
            // invoke the method
            found = aDoc.Find(DoctorId);
            // check PhoneNumber property
            if (aDoc.dPhoneNumber != "394850934")
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 DoctorId = 1;
            // invoke the method
            found = aDoc.Find(DoctorId);
            // check Availability property
            if (aDoc.dAvailability != true)
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            // create instance of class
            clsDoc aDoc = new clsDoc();
            // create boolean variable to store resault of the search
            Boolean found = false;
            // boolean variable to record if the data is ok, hard coded/assumed it is
            Boolean ok = true;
            // test data
            Int32 DoctorId = 1;
            DateTime date = DateTime.Parse("28/03/2025 00:00:00");
            // invoke the method
            found = aDoc.Find(DoctorId);
            // check date time property
            if (aDoc.DDateAdded != date)
            {
                ok = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(ok);

        }


        [TestMethod]
        public void TestValidation()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // string variable to store any error message
            String error = "";
            // inove the method
            error = testDoctor.isValid(firstName, lastName, address, email, phoneNumber, dateAdded);
            // test to see if the result is correct 
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestFirstNameLessOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testFristName = "";
            // invoke the method
            error = testDoctor.isValid(testFristName, lastName, address, email, phoneNumber, dateAdded);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void TestFirstNameMin()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testFristName = "a";
            // invoke the method
            error = testDoctor.isValid(testFristName, lastName, address, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestFirstNameMinPlusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testFristName = "aa";
            // invoke the method
            error = testDoctor.isValid(testFristName, lastName, address, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestFirstNameMaxMinusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testFristName = "";
            testFristName = testFristName.PadRight(98, 'a');
            // invoke the method
            error = testDoctor.isValid(testFristName, lastName, address, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestFirstNameMax()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testFristName = "";
            testFristName = testFristName.PadRight(100, 'a');
            // invoke the method
            error = testDoctor.isValid(testFristName, lastName, address, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestFirstNameMaxPlusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testFristName = "";
            testFristName = testFristName.PadRight(101, 'a');
            // invoke the method
            error = testDoctor.isValid(testFristName, lastName, address, email, phoneNumber, dateAdded);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void TestFirstNameMid()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testFristName = "";
            testFristName = testFristName.PadRight(50, 'a');
            // invoke the method
            error = testDoctor.isValid(testFristName, lastName, address, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestLastNameLessOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testLastName = "";
            // invoke the method
            error = testDoctor.isValid(firstName, testLastName, address, email, phoneNumber, dateAdded);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void TestLastNameMin()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testLastName = "a";
            // invoke the method
            error = testDoctor.isValid(firstName, testLastName, address, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestLastNameMinPlusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testLastName = "aa";
            // invoke the method
            error = testDoctor.isValid(firstName, testLastName, address, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestLastNameMaxMinusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testLastName = "";
            testLastName = testLastName.PadRight(98, 'a');
            // invoke the method
            error = testDoctor.isValid(firstName, testLastName, address, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestLastNameMax()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testLastName = "";
            testLastName = testLastName.PadRight(100, 'a');
            // invoke the method
            error = testDoctor.isValid(firstName, testLastName, address, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestLastNameMaxPlusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testLastName = "";
            testLastName = testLastName.PadRight(101, 'a');
            // invoke the method
            error = testDoctor.isValid(firstName, testLastName, address, email, phoneNumber, dateAdded);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void TestLastNameMid()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testLastName = "";
            testLastName = testLastName.PadRight(50, 'a');
            // invoke the method
            error = testDoctor.isValid(firstName, testLastName, address, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestAddressLessOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testAddress = "aaaa";
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, testAddress, email, phoneNumber, dateAdded);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void TestAddressMin()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testAddress = "aqaqaqaqa";
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, testAddress, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestAddressMinPlusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testAddress = "aqaqaqaqaq";
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, testAddress, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestAddressMaxMinusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testAddress = "";
            testAddress = testAddress.PadRight(254, 'a');
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, testAddress, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestAddressMax()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testAddress = "";
            testAddress = testAddress.PadRight(255, 'a');
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, testAddress, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestAddressMaxPlusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testAddress = "";
            testAddress = testAddress.PadRight(256, 'a');
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, testAddress, email, phoneNumber, dateAdded);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void TestAddressMid()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testAddress = "";
            testAddress = testAddress.PadRight(127, 'a');
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, testAddress, email, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestEmailLessOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testEmail = "@";
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, testEmail, phoneNumber, dateAdded);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void TestEmailMin()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testEmail = "aqaqaq@qaq";
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, testEmail, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestEmailMinPlusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testEmail = "aqaqaqa@aqa";
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, testEmail, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestEmailMaxMinusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testEmail = "";
            testEmail = testEmail.PadRight(254, '@');
            // invoke the method
            error = testDoctor.isValid(firstName, lastName,address , testEmail, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestEmailMax()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testEmail = "";
            testEmail = testEmail.PadRight(255, '@');
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, testEmail, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestEmailMaxPlusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testEmail = "";
            testEmail = testEmail.PadRight(256, '@');
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, testEmail, phoneNumber, dateAdded);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void TestEmailMid()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testEmail = "";
            testEmail = testEmail.PadRight(127, '@');
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, testEmail, phoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestEmailContainsAt()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testEmail = "";
            testEmail = testEmail.PadRight(127, 'a');
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, testEmail, phoneNumber, dateAdded);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void TestPhoneNumberLessOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testPhoneNumber = "12345678";
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, email, testPhoneNumber, dateAdded);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void TestPhoneNumberMin()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testPhoneNumber = "123456789";
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, email, testPhoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestPhoneNumberMinPlusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testPhoneNumber = "1234567899";
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, email, testPhoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestPhoneNumberMaxMinusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testPhoneNumber = "";
            testPhoneNumber = testPhoneNumber.PadRight(49, '1');
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, email, testPhoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestPhoneNumberMax()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testPhoneNumber = "";
            testPhoneNumber = testPhoneNumber.PadRight(50, '1');
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, email, testPhoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void TestPhoneNumberMaxPlusOne()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testPhoneNumber = "";
            testPhoneNumber = testPhoneNumber.PadRight(51, '1');
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, email, testPhoneNumber, dateAdded);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void TestPhoneNumberMid()
        {
            // create an instance of a doctor
            clsDoc testDoctor = new clsDoc();
            // create variable to store any error messages
            String error = "";
            // create test data
            String testPhoneNumber = "";
            testPhoneNumber = testPhoneNumber.PadRight(25, '1');
            // invoke the method
            error = testDoctor.isValid(firstName, lastName, address, email, testPhoneNumber, dateAdded);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsDoc testDoctor = new clsDoc();
            //string variable to store any error message
            String error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string testDateAdded = TestDate.ToString();
            //invoke the method
            error = testDoctor.isValid(firstName, lastName, address, email, phoneNumber, testDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsDoc testDoctor = new clsDoc();
            //string variable to store any error message
            String error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string testDateAdded = TestDate.ToString();
            //invoke the method
            error = testDoctor.isValid(firstName, lastName, address, email, phoneNumber, testDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsDoc testDoctor = new clsDoc();
            //string variable to store any error message
            String error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string testDateAdded = TestDate.ToString();
            //invoke the method
            error = testDoctor.isValid(firstName, lastName, address, email, phoneNumber, testDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDoc testDoctor = new clsDoc();
            //string variable to store any error message
            String error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 days
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string testDateAdded = TestDate.ToString();
            //invoke the method
            error = testDoctor.isValid(firstName, lastName, address, email, phoneNumber, testDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsDoc testDoctor = new clsDoc();
            //string variable to store any error message
            String error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 days
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string testDateAdded = TestDate.ToString();
            //invoke the method
            error = testDoctor.isValid(firstName, lastName, address, email, phoneNumber, testDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void StatitsticsGroupedByLastName()
        {
            // create an instance of the class we want to create
            clsDoc testDoctor = new clsDoc();
            // invake the method

            DataTable dT = testDoctor.StatisticsGroupedByLastName();
            // according to the last execute sored procedure there should bre three rows of data 
            int noOfRecord = 10;

            // test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

    }
}
