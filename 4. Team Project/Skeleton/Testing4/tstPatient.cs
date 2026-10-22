using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Linq;

namespace Testing4
{
    [TestClass]
    public class tstPatient
    {
        //good test data
        private string patientName = "Test Name";
        private string email = "testemail@test.com";
        private string address = "1TestDrive,TestCity,Testshire,TE11ST";
        private string dateOfBirthStr ="01/01/2000";
        private string drIdStr = "1";

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //test to see that it exists
            Assert.IsNotNull(aPatient);
        }
        [TestMethod]
        public void PatientIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            int testData = 1;
            //assign the data to the property
            aPatient.PatientId = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.PatientId, testData);

        }

        [TestMethod]
        public void PNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            string testData = "Test Name";
            //assign the data to the property
            aPatient.PName = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.PName, testData);

        }

        [TestMethod]
        public void PEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            string testData = "test.email@testemail.com";
            //assign the data to the property
            aPatient.PEmail = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.PEmail, testData);

        }

        [TestMethod]
        public void PDOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            DateTime testData = DateTime.Now.Date;
            //assign the data to the property
            aPatient.PDOB = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.PDOB, testData);

        }

        [TestMethod]
        public void PHomeAddPropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            string testData = "Test Street,Leicster,LE11AA";
            //assign the data to the property
            aPatient.PHomeAdd = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.PHomeAdd, testData);

        }

        [TestMethod]
        public void PAccessReqPropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            Boolean testData = true;
            //assign the data to the property
            aPatient.PAccessReq = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.PAccessReq, testData);

        }

        [TestMethod]
        public void PMainDocID()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to assign to the property
            int testData = 1;
            //assign the data to the property
            aPatient.PMainDocId = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aPatient.PMainDocId, testData);

        }
    

    [TestMethod]

        public void FindMethodOk()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create some test data to use with the method
            int patientId = 2;
            //invoke mthe method
            Boolean found = aPatient.Find(patientId);
            //test to see if result is true
            Assert.IsTrue(found);
        }

        [TestMethod]

        public void TestPatientIdFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean ok = true;
            //create some test data to use with the method
            int patientId = 6;
            //invoke mthe method
            aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.PatientId != 6)
            {
                ok = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestPNameFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean ok = true;
            //create some test data to use with the method
            int patientId = 6;
            aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.PName != "Test Name")
            {
                ok = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestPEmailFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean ok = true;
            //create some test data to use with the method
            int  patientId = 6;
            //invoke mthe method
            aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.PEmail != "test.email@testemail.com")
            {
                ok = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestPDOBFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean ok = true;
            //create some test data to use with the method
            int patientId = 6;
            //invoke mthe method
            aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.PDOB != Convert.ToDateTime("01/01/2000"))
            {
                ok = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestPHomeAddFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean ok = true;
            //create some test data to use with the method
            int patientId = 6;
            //invoke mthe method
            aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.PHomeAdd != "1 Test Steet,TestTown,TestShire,TE11AA")
            {
                ok = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestPAccessReqFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean ok = true;
            //create some test data to use with the method
            int patientId = 6;
            //invoke mthe method
            aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.PAccessReq != false)
            {
                ok = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestPMainDocIdFound()
        {
            //create and instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean ok = true;
            //create some test data to use with the method
            int patientId = 6;
            //invoke mthe method
            aPatient.Find(patientId);
            //chech the patient id
            if (aPatient.PMainDocId != 4)
            {
                ok = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsPatient aPatient = new clsPatient();
            //invoke method
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PNameMinLessOne()
        {
            clsPatient aPatient = new clsPatient();
            string patientName = "";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PNameMin()
        {
            clsPatient aPatient = new clsPatient();
            String patientName = "A";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PNameMinMoreOne()
        {
            clsPatient aPatient = new clsPatient();
            String patientName = "aa";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PNameMaxLessOne()
        {
            clsPatient aPatient = new clsPatient();
            String patientName = new string('a', 99);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PNameMax()
        {
            clsPatient aPatient = new clsPatient();
            String patientName = new string('a', 100);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PNameMaxMoreOne()
        {
            clsPatient aPatient = new clsPatient();
            String patientName = new string('a', 101);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PNameMid()
        {
            clsPatient aPatient = new clsPatient();
            String patientName = new string('a', 50);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PNameExtremeMax()
        {
            clsPatient aPatient = new clsPatient();
            String patientName = new string('a', 500);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PEmailMin()
        {
            clsPatient aPatient = new clsPatient();
            String email = "";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PEmailMinMoreOne()
        {
            clsPatient aPatient = new clsPatient();
            String email = "b";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PEmailMaxLessOne()
        {
            clsPatient aPatient = new clsPatient();
            String email = new String('b', 254);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PEmailMax()
        {
            clsPatient aPatient = new clsPatient();
            String email = new String('b', 255);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PEmailMaxMoreOne()
        {
            clsPatient aPatient = new clsPatient();
            String email = new String('b', 256);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PEmailMid()
        {
            clsPatient aPatient = new clsPatient();
            String email = new String('b', 129);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PEmailExtreme()
        {
            clsPatient aPatient = new clsPatient();
            String email = new String('b', 1000);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PHomeAddMin()
        {
            clsPatient aPatient = new clsPatient();
            String address = "c";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PHomeAddMinMoreOne()
        {
            clsPatient aPatient = new clsPatient();
            String address = "cc";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PHomeAddMaxLessOne()
        {
            clsPatient aPatient = new clsPatient();
            String address = new String('c', 124);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PHomeAddMax()
        {
            clsPatient aPatient = new clsPatient();
            String address = new String('c', 125);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PHomeAddMaxMoreOne()
        {
            clsPatient aPatient = new clsPatient();
            String address = new String('c', 126);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PHomeAddMid()
        {
            clsPatient aPatient = new clsPatient();
            String address = new String('c', 63);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PHomeAddExtremeMax()
        {
            clsPatient aPatient = new clsPatient();
            String address = new String('c', 750);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PDOBExtremeMin()
        {
            clsPatient aPatient = new clsPatient();
            String dateOfBirthStr = "01/01/1784";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PDOBMinLessOne()
        {
            clsPatient aPatient = new clsPatient();
            String dateOfBirthStr = "31/12/1883";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PDOBMin()
        {
            clsPatient aPatient = new clsPatient();
            String dateOfBirthStr = "01/01/1884";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }
        
        [TestMethod]

        public void PDOBMinMoreOne()
        {
            clsPatient aPatient = new clsPatient();
            String dateOfBirthStr = "02/01/1884";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PDOBMaxLessOne()
        {
            clsPatient aPatient = new clsPatient();
            String dateOfBirthStr = Convert.ToString(DateTime.Now.Date.AddDays(-1));
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PDOBMax()
        {
            clsPatient aPatient = new clsPatient();
            String dateOfBirthStr = Convert.ToString(DateTime.Now.Date);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PDOBMaxMoreOne()
        {
            clsPatient aPatient = new clsPatient();
            String dateOfBirthStr = Convert.ToString(DateTime.Now.Date.AddDays(1));
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PDOBMid()
        {
            clsPatient aPatient = new clsPatient();
            int year = 1884 + ((DateTime.Now.Date.Year - 1844) / 2);
            String dateOfBirthStr = "20/6/" + Convert.ToString(year);
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PDOBExtremeMax()
        {
            clsPatient aPatient = new clsPatient();
            String dateOfBirthStr = Convert.ToString(DateTime.Now.Date.AddYears(100));
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PDOBInvalidDataType()
        {
            clsPatient aPatient = new clsPatient();
            String dateOfBirthStr = "not a date!";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PMainDocIdExtremeMin()
        {
            clsPatient aPatient = new clsPatient();
            String drIdStr = "-2147483648";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PMainDocIdMinLessOne()
        {
            clsPatient aPatient = new clsPatient();
            String drIdStr = "0";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void PMainDocIdMin()
        {
            clsPatient aPatient = new clsPatient();
            String drIdStr = "1";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PMainDocIdMinMoreOne()
        {
            clsPatient aPatient = new clsPatient();
            String drIdStr = "2";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PMainDocIdMaxLessOne()
        {
            clsPatient aPatient = new clsPatient();
            String drIdStr = "2147483646";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PMainDocIdMax()
        {
            clsPatient aPatient = new clsPatient();
            String drIdStr = "2147483647";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]

        public void PMainDocIdMid()
        {
            clsPatient aPatient = new clsPatient();
            String drIdStr = "1073741824";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PMainDocIdInvalidDataType()
        {
            clsPatient aPatient = new clsPatient();
            String drIdStr = "test";
            string error = aPatient.Valid(patientName, email, address, dateOfBirthStr, drIdStr);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]

        public void StatStatisticsGroupedByDocId()
        {
            clsPatient aPatient = new clsPatient();
            DataTable dT = aPatient.StatisticsGroupedByDoctorId();
            //last recording was 4 rows of data
            int noOfRecord = 4;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

        [TestMethod]

        public void StatStatisticsGroupedByDOB()
        {
            clsPatient aPatient = new clsPatient();
            DataTable dT = aPatient.StatisticsGroupedByDOB();
            //last recording was 6 rows of data
            int noOfRecord = 6;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
    }
}
