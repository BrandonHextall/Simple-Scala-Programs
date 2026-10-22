using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing4
{
    [TestClass]
    public class tstPatientCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPatientCollection allPatients = new clsPatientCollection();
            //test to see that it exists
            Assert.IsNotNull(allPatients);
        }

        [TestMethod]

        public void PatientListOK()
        {
            //create an instance of the class we want to create
            clsPatientCollection allPatients = new clsPatientCollection();
            //create some data to asign to the property
            //in this case the data needs to be a list of objects
            List<clsPatient> testList = new List<clsPatient>();
            //add an itme to the list
            //create the item of test data
            clsPatient testItem = new clsPatient
            {
                //set its properties
                PatientId = 1,
                PName = "Test Name",
                PEmail = "test.email@test.com",
                PDOB = Convert.ToDateTime("01/01/2000"),
                PHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA",
                PAccessReq = true,
                PMainDocId = 1
            };
            //add the item to the test list
            testList.Add(testItem);
            //assign the data to the property
            allPatients.PatientList = testList;
            //test to see that the two values are the same
            Assert.AreEqual(allPatients.PatientList, testList);
        }


        [TestMethod]

        public void ThisPatientPropertyOk()
        {
            //create an instance of the class we want to create
            clsPatientCollection allPatients = new clsPatientCollection();
            //create some data to asign to the property
            _ = new List<clsPatient>();
            clsPatient testPatient = new clsPatient
            {
                //set its properties
                PatientId = 1,
                PName = "Test Name",
                PEmail = "test.email@test.com",
                PDOB = Convert.ToDateTime("01/01/2000"),
                PHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA",
                PAccessReq = true,
                PMainDocId = 1
            };
            allPatients.ThisPatient = testPatient;
            Assert.AreEqual(allPatients.ThisPatient, testPatient);
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsPatientCollection allPatients = new clsPatientCollection();
            //create some data to asign to the property
            //in this case the data needs to be a list of objects
            List<clsPatient> testList = new List<clsPatient>();
            //add an itme to the list
            //create the item of test data
            clsPatient testItem = new clsPatient
            {
                //set its properties
                PatientId = 1,
                PName = "Test Name",
                PEmail = "test.email@test.com",
                PDOB = Convert.ToDateTime("01/01/2000"),
                PHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA",
                PAccessReq = true,
                PMainDocId = 1
            };
            //add the item to the test list
            testList.Add(testItem);
            //assign the data to the property
            allPatients.PatientList = testList;
            //test to see that the two values are the same
            Assert.AreEqual(allPatients.Count, testList.Count);
        }

        [TestMethod]

        public void AddMethodOK()
        {
            clsPatientCollection allPatients = new clsPatientCollection();
            clsPatient testItem = new clsPatient
            { 
                PName = "Test Name",
                PEmail = "test.email@test.com",
                PDOB = Convert.ToDateTime("01/01/2000"),
                PHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA",
                PAccessReq = true,
                PMainDocId = 1
            };
            //set ThisAddress to the test data
            allPatients.ThisPatient = testItem;
            //add the record
            int primaryKey = allPatients.Add();
            //set the primary key of the test data
            testItem.PatientId = primaryKey;
            //find the record
            allPatients.ThisPatient.Find(primaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allPatients.ThisPatient, testItem);
        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            clsPatientCollection allPatients = new clsPatientCollection();
            clsPatient testItem = new clsPatient
            { 
                PName = "Test Name",
                PEmail = "test.email@test.com",
                PDOB = Convert.ToDateTime("01/01/2000"),
                PHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA",
                PAccessReq = true,
                PMainDocId = 1
            };
            allPatients.ThisPatient = testItem;
            Int32 primaryKey = allPatients.Add();
            testItem.PatientId = primaryKey;
            //mod testItem
            testItem.PName = "Test Name2";
            testItem.PEmail = "test.email2@test.com";
            testItem.PDOB = Convert.ToDateTime("02/01/2000");
            testItem.PHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA";
            testItem.PAccessReq = false;
            testItem.PMainDocId = null;
            allPatients.ThisPatient = testItem;
            //update record
            allPatients.Update();
            //find the record
            allPatients.ThisPatient.Find(primaryKey);
            Assert.AreEqual(allPatients.ThisPatient, testItem);
        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            clsPatientCollection allPatients = new clsPatientCollection();
            clsPatient testItem = new clsPatient
            {
                PName = "Test Name",
                PEmail = "test.email@test.com",
                PDOB = Convert.ToDateTime("01/01/2000"),
                PHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA",
                PAccessReq = true,
                PMainDocId = 1
            };
            allPatients.ThisPatient = testItem;
            int primaryKey = allPatients.Add();
            testItem.PatientId = primaryKey;
            //find record
            allPatients.ThisPatient.Find(primaryKey);
            //delete the record
            allPatients.Delete();
            //now check if record is found
            Assert.IsFalse(allPatients.ThisPatient.Find(primaryKey)); 
        }

        [TestMethod]

        public void ReportByNameMethodOK()
        {
            //create a cls collection instance
            clsPatientCollection allPatients = new clsPatientCollection();
            //filter data
            clsPatientCollection filteredPatients = new clsPatientCollection();
            //apply a blank string to return all records
            filteredPatients.ReportByName("");
            //test to check are equal
            Assert.AreEqual(allPatients.Count, filteredPatients.Count);
        }

        [TestMethod]

        public void ReportByNameNoneFound()
        {
            clsPatientCollection filteredPatients = new clsPatientCollection();
            filteredPatients.ReportByName("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, filteredPatients.Count);
        }

        [TestMethod]

        public void ReportByNameTestDataFound()
        {
            clsPatientCollection filteredPatients = new clsPatientCollection();
            filteredPatients.ReportByName("Test Filter");
            Boolean OK = false;
            if (filteredPatients.Count == 2 &&
                filteredPatients.PatientList[0].PatientId == 36 &&
                filteredPatients.PatientList[1].PatientId == 37)
            {
                    OK = true;
            }

            Assert.IsTrue(OK);
        }
    }
}
