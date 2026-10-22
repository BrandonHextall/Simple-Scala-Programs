using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;


namespace Testing5
{
    [TestClass]
    public class tstDoctorCollection
    {
        [TestMethod]
        public void InstnceOk()
        {
            // intitialese an instance of the class
            clsDoctorCollection testDoctorCollection = new clsDoctorCollection();
            // test to see if the class/that exists
            Assert.IsNotNull(testDoctorCollection);
        }

        [TestMethod]
        public void DoctorCollectionOk()
        {
            // intitialese an instance of the class
            clsDoctorCollection testDoctorCollection = new clsDoctorCollection();
            // create test data to assignt to the property
            // the test data in this case is a list of objects
            List<clsDoc> testDoctorList = new List<clsDoc>();
            // add item to the list
            // create the item of test data
            clsDoc testDoctor = new clsDoc();
            // set its properties
            testDoctor.dId = 1;
            testDoctor.dFirstName = "Niche";
            testDoctor.dLastName = "cazoi";
            testDoctor.dAddress = "33 road road";
            testDoctor.dEmail = "a@d.com";
            testDoctor.dPhoneNumber = "123456789";
            testDoctor.dAvailability = true;
            testDoctor.DDateAdded = DateTime.Now.Date;
            // add the item to the test list
            testDoctorList.Add(testDoctor);
            // assign the data to the property
            testDoctorCollection.doctorList = testDoctorList;
            // test to see that the two values are the same
            Assert.AreEqual(testDoctorCollection.doctorList, testDoctorList);
        }

        //[TestMethod]

        //public void CountPropertyOk()
        //{
        //    // new instance of clsDoctorCollection
        //    clsDoctorCollection testDoctorCollection = new clsDoctorCollection();
        //    // test data
        //    Int32 testCount = 2;
        //    // assign the data to the property
        //    testDoctorCollection.count = testCount;
        //    // make sure the two values are the same
        //    Assert.AreEqual(testDoctorCollection.count, testCount);
        //}

        [TestMethod]

        public void ThisDoctorPropertyOk()
        {
            // create instance of clsDoctorCollection
            clsDoctorCollection testDoctorCollection = new clsDoctorCollection();
            // test data
            clsDoc testDoctor = new clsDoc();
            // set its properties
            testDoctor.dId = 1;
            testDoctor.dFirstName = "Niche";
            testDoctor.dLastName = "cazoi";
            testDoctor.dAddress = "33 road road";
            testDoctor.dEmail = "a@d.com";
            testDoctor.dPhoneNumber = "123456789";
            testDoctor.dAvailability = true;
            testDoctor.DDateAdded = DateTime.Now.Date;
            // assign the test data to the property
            testDoctorCollection.thisDoctor = testDoctor;
            Assert.AreEqual(testDoctorCollection.thisDoctor, testDoctor);
        }

        [TestMethod]

        public void ListAndCountOk()
        {
            // create instance of clsDoctorCollection
            clsDoctorCollection testDoctorCollection = new clsDoctorCollection();
            // test data
            List<clsDoc> testDoctorList = new List<clsDoc>();
            clsDoc testDoctor = new clsDoc();
            // set its properties
            testDoctor.dId = 1;
            testDoctor.dFirstName = "Niche";
            testDoctor.dLastName = "cazoi";
            testDoctor.dAddress = "33 road road";
            testDoctor.dEmail = "a@d.com";
            testDoctor.dPhoneNumber = "123456789";
            testDoctor.dAvailability = true;
            testDoctor.DDateAdded = DateTime.Now.Date;
            // assign the test data to the property
            testDoctorList.Add(testDoctor);
            testDoctorCollection.doctorList = testDoctorList;
            Assert.AreEqual(testDoctorCollection.count, testDoctorList.Count);
        }

        //[TestMethod]

        //public void TwoRecordsPresent()
        //{
        //    // instance of clsDoctorCollection
        //    clsDoctorCollection testDoctorCollection = new clsDoctorCollection();
        //    // see if two values are the same
        //    Assert.AreEqual(testDoctorCollection.count, 2);
        //}


        [TestMethod]

        public void AddMethodOk()
        {
            // create an instance of doctors list
            clsDoctorCollection allDoctors = new clsDoctorCollection();
            // create test data
            clsDoc testDoctor = new clsDoc();
            // variable to store the primary key
            Int32 primaryKey = 0;
            // set properties
            testDoctor.dFirstName = "ADD";
            testDoctor.dLastName = "Method";
            testDoctor.dAddress = "33 road road";
            testDoctor.dEmail = "a@d.com";
            testDoctor.dPhoneNumber = "123456789";
            testDoctor.dAvailability = true;
            testDoctor.DDateAdded = DateTime.Now.Date;
            // sett thisdoctor to the test doctor
            allDoctors.thisDoctor = testDoctor;
            // add the record
            primaryKey = allDoctors.Add();
            // set the primary key of the test data 
            testDoctor.dId = primaryKey;
            // find the record   
            allDoctors.thisDoctor.Find(primaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(allDoctors.thisDoctor, testDoctor);
        }

        [TestMethod]

        public void UpdateMethodOk()
        {
            // create an instance of doctors list
            clsDoctorCollection allDoctors = new clsDoctorCollection();
            // create test data
            clsDoc testDoctor = new clsDoc();
            // variable to store the primary key
            Int32 primaryKey = 0;
            // set properties
            testDoctor.dFirstName = "Update";
            testDoctor.dLastName = "Method";
            testDoctor.dAddress = "33 road road";
            testDoctor.dEmail = "a@d.com";
            testDoctor.dPhoneNumber = "123456789";
            testDoctor.dAvailability = true;
            testDoctor.DDateAdded = DateTime.Now.Date;
            // sett thisdoctor to the test doctor
            allDoctors.thisDoctor = testDoctor;
            // add the record
            primaryKey = allDoctors.Add();
            // set the primary key of the test data 
            testDoctor.dId = primaryKey;
            // modify the record
            testDoctor.dFirstName = "UpdatedOne";
            testDoctor.dLastName = "Method";
            testDoctor.dAddress = "34 Drive Drive";
            testDoctor.dEmail = "a@d.com";
            testDoctor.dPhoneNumber = "123456789";
            testDoctor.dAvailability = false;
            testDoctor.DDateAdded = DateTime.Now.Date;
            // update the record
            allDoctors.Update();
            // find the record
            allDoctors.thisDoctor.Find(primaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(allDoctors.thisDoctor, testDoctor);
        }

        [TestMethod]

        public void DeleteMethodOk()
        {
            // create an instance of doctors list
            clsDoctorCollection allDoctors = new clsDoctorCollection();
            // create test data
            clsDoc testDoctor = new clsDoc();
            // variable to store the primary key
            Int32 primaryKey = 0;
            // set properties
            testDoctor.dFirstName = "Tobe";
            testDoctor.dLastName = "Deleted";
            testDoctor.dAddress = "33 road road";
            testDoctor.dEmail = "a@d.com";
            testDoctor.dPhoneNumber = "123456789";
            testDoctor.dAvailability = true;
            testDoctor.DDateAdded = DateTime.Now.Date;
            // sett thisdoctor to the test doctor
            allDoctors.thisDoctor = testDoctor;
            // add the record
            primaryKey = allDoctors.Add();
            // set the primary key of the test data 
            testDoctor.dId = primaryKey;
            // find the record   
            allDoctors.thisDoctor.Find(primaryKey);
            // delete the record
            allDoctors.Delete();
            // find the record
            Boolean found = allDoctors.thisDoctor.Find(primaryKey);
            // test to see if the record was not found
            Assert.IsFalse(found);
        }

        [TestMethod]

        public void FilterByLastNameOK()
        {
            //create an instance of the class containing unfiltered results
            clsDoctorCollection doctorCollection = new clsDoctorCollection();
            // create an instance of the filtered data
            clsDoctorCollection filteredDoctorCollection = new clsDoctorCollection();
            // apply a blank string should return all records
            filteredDoctorCollection.FilterByLastName("");
            // test to see that the two values are the same
            Assert.AreEqual(doctorCollection.count, filteredDoctorCollection.count);
        }

        [TestMethod]

        public void FilterByLastNameNoneFound()
        {
            
           // create an instance of the filtered data
            clsDoctorCollection filteredDoctorCollection = new clsDoctorCollection();
            // apply a blank string should return all records
            filteredDoctorCollection.FilterByLastName("NoLol");
            // test to see that the two values are the same
            Assert.AreEqual(0, filteredDoctorCollection.count);
        }

        [TestMethod]

        public void FilterByLastNameFound()
        {

            // create an instance of the filtered data
            clsDoctorCollection filteredDoctorCollection = new clsDoctorCollection();
            // variable to store outcom
            Boolean ok = true;
            // apply a blank string should return all records
            filteredDoctorCollection.FilterByLastName("Bama");
            // check to see ithat the correct number of records is found
            if(filteredDoctorCollection.count == 2)
            {
                // check that the first record is 5
                if(filteredDoctorCollection.doctorList[0].dId != 5)
                {
                    ok = false;
                }
                // check that second record is == 12
                if (filteredDoctorCollection.doctorList[1].dId != 12)
                {
                    ok = false;
                }
            }
            else
            {
                ok = false;
            }
            // test to see that there are records
            Assert.IsTrue(ok);
        }


        
    }

}
