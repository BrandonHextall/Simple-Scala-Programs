using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstAppointmentsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create and instance of the class we want to create
            clsAppointmentsCollection AllAppointments = new clsAppointmentsCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAppointments);
        }
        [TestMethod]
        public void AppointmentsListOK()
        {
            //create an instance of the class we want to create
            clsAppointmentsCollection AllAppointments = new clsAppointmentsCollection();
            //create some test data to assign to the property
            List<clsAppointments> TestList = new List<clsAppointments>();
            //add an item to the list
            clsAppointments TestItem = new clsAppointments();
            TestItem.AppointmentNumber = 2;
            TestItem.DoctorID = 2;
            TestItem.PatientFirstName = "Test";
            TestItem.PatientLastName = "Patient";
            TestItem.DateOfAppointment = DateTime.Now.Date;
            TestItem.TimeOfAppointment = new TimeSpan(12, 0, 0);
            TestItem.FloorNumber = 2;
            TestItem.RoomNumber = 2;
            TestItem.EmergencyAppointment = true;
            TestItem.Notes = "Test Description";
            TestList.Add(TestItem);
            //assign the data to the property
            AllAppointments.AppointmentsList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.AppointmentsList, TestList);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsAppointmentsCollection AllAppointments = new clsAppointmentsCollection();
            //create some test data to assign to the property
            List<clsAppointments> TestList = new List<clsAppointments>();
            //add an item to the list
            clsAppointments TestItem = new clsAppointments();
            TestItem.AppointmentNumber = 2;
            TestItem.DoctorID = 2;
            TestItem.PatientFirstName = "Test2";
            TestItem.PatientLastName = "Patient2";
            TestItem.DateOfAppointment = DateTime.Now.Date;
            TestItem.TimeOfAppointment = new TimeSpan(12, 0, 0);
            TestItem.FloorNumber = 2;
            TestItem.RoomNumber = 2;
            TestItem.EmergencyAppointment = false;
            TestItem.Notes = "Test Description";
            TestList.Add(TestItem);
            //assign the data to the property
            AllAppointments.AppointmentsList = TestList;
            AllAppointments.Count = TestList.Count;
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsAppointmentsCollection AllAppointments = new clsAppointmentsCollection();
            //create some test data to assign to the property
            clsAppointments TestItem = new clsAppointments();
            TestItem.AppointmentNumber = 1;
            TestItem.DoctorID = 2;
            TestItem.PatientFirstName = "Test4";
            TestItem.PatientLastName = "Patient4";
            TestItem.DateOfAppointment = DateTime.Now.Date;
            TestItem.TimeOfAppointment = new TimeSpan(12, 0, 0);
            TestItem.FloorNumber = 2;
            TestItem.RoomNumber = 2;
            TestItem.EmergencyAppointment = true;
            TestItem.Notes = "Test Description";
            AllAppointments.ThisAppointment = TestItem;
            //variable to store the primary key
            int PrimaryKey = AllAppointments.Add();
            //set the primary key of the test data
            TestItem.AppointmentNumber = PrimaryKey;
            //find the record
            AllAppointments.ThisAppointment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.ThisAppointment, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create and instance of the class we want to create
            clsAppointmentsCollection AllAppointments = new clsAppointmentsCollection();
            //create some test data to assign to the property
            clsAppointments TestItem = new clsAppointments();
            //variable to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.DoctorID = 2;
            TestItem.PatientID = 12;
            TestItem.PatientFirstName = "Test4";
            TestItem.PatientLastName = "Patient4";
            TestItem.DateOfAppointment = DateTime.Now.Date;
            TestItem.TimeOfAppointment = new TimeSpan(11, 0, 0);
            TestItem.FloorNumber = 2;
            TestItem.RoomNumber = 2;
            TestItem.EmergencyAppointment = true;
            TestItem.Notes = "Test Description";
            //set ThisAppointment to the test data
            AllAppointments.ThisAppointment = TestItem;
            //add the record
            PrimaryKey = AllAppointments.Add();
            //set the primary key of the test data
            TestItem.AppointmentNumber = PrimaryKey;
            //modify the test data
            TestItem.DoctorID = 3;
            TestItem.PatientID = 15;
            TestItem.PatientFirstName = "Test5";
            TestItem.PatientLastName = "Patient5";
            TestItem.DateOfAppointment = DateTime.Now.Date;
            TestItem.TimeOfAppointment = new TimeSpan(10, 0, 0);
            TestItem.FloorNumber = 2;
            TestItem.RoomNumber = 3;
            TestItem.EmergencyAppointment = false;
            TestItem.Notes = "Test Description 2";
            //set the record based on the new test data
            AllAppointments.ThisAppointment = TestItem;
            //update the record
            AllAppointments.Update();
            //find the record
            AllAppointments.ThisAppointment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.ThisAppointment, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsAppointmentsCollection AllAppointments = new clsAppointmentsCollection();
            //create some test data to assign to the property
            clsAppointments TestItem = new clsAppointments();
            //variable to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.DoctorID = 2;
            TestItem.PatientID = 12;
            TestItem.PatientFirstName = "Test";
            TestItem.PatientLastName = "Name2";
            TestItem.DateOfAppointment = DateTime.Now.Date;
            TestItem.TimeOfAppointment = new TimeSpan(11, 0, 0);
            TestItem.FloorNumber = 2;
            TestItem.RoomNumber = 2;
            TestItem.EmergencyAppointment = true;
            TestItem.Notes = "Test Description";
            //set ThisAppointment to the test data
            AllAppointments.ThisAppointment = TestItem;
            //add the record
            PrimaryKey = AllAppointments.Add();
            //set the primary key of the test data
            TestItem.AppointmentNumber = PrimaryKey;
            //find the record
            AllAppointments.ThisAppointment.Find(PrimaryKey);
            //delete the record
            AllAppointments.Delete();
            //now find the record
            Boolean Found = AllAppointments.ThisAppointment.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void FilterByDateMethodOK()
        {
            //create an instance of the class we want to create
            clsAppointmentsCollection AllAppointments = new clsAppointmentsCollection();
            //create an instance of the filtered data
            clsAppointmentsCollection Filtered = new clsAppointmentsCollection();
            //apply a blank string (should return all records)
            Filtered.FilterByDate("");
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.Count, Filtered.Count);
        }
        [TestMethod]
        public void FilterByDateNoneFound()
        {
            //create an instance of the class we want to create
            clsAppointmentsCollection Filtered = new clsAppointmentsCollection();
            //apply a date that doesn't exist
            Filtered.FilterByDate("01/01/1900");
            //test to see that there are no records
            Assert.AreEqual(0, Filtered.Count);
        }
        [TestMethod]
        public void FilterByDateTestDataFound()
        {
            //create an instance of the unfiltered data
            clsAppointmentsCollection Filtered = new clsAppointmentsCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a date that doesn't exist
            Filtered.FilterByDate("01/01/1900");
            //check that the correct number of records are found
            if (Filtered.Count != 0) OK = false;
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
