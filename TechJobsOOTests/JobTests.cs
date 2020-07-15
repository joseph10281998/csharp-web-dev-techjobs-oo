using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO.Tests
{
    [TestClass()]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsFalse(job1.Id == job2.Id);
            Assert.IsTrue(job2.Id - job1.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(job1.Name == "Product tester");
            Assert.IsTrue(job1.Employer.Value == "ACME");
            Assert.IsTrue(job1.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job1.JobType.Value == "Quality control");
            Assert.IsTrue(job1.JobCoreCompetency.Value == "Persistence");
        }


        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(job2.Equals(job3));
        }


        [TestMethod]
        public void TestJobsToStringContainBlankLinesBeforeAfter()
        {
            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            
            Assert.IsTrue(job4.ToString().StartsWith("\n"));
            Assert.IsTrue(job4.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void TestJobsToStringContainLabelDataEachLine()
        {
            Job job5 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //Assert.AreEqual("\nID: 1\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence\n", job1.ToString());
            Assert.IsTrue(job5.ToString().Contains("ID: 5"));
            Assert.IsTrue(job5.ToString().Contains("Name: Product tester"));
            Assert.IsTrue(job5.ToString().Contains("Employer: ACME"));
            Assert.IsTrue(job5.ToString().Contains("Location: Desert"));
            Assert.IsTrue(job5.ToString().Contains("Position Type: Quality control"));
            Assert.IsTrue(job5.ToString().Contains("Core Competency: Persistence"));

            //Assert.AreEqual(job1.Id.ToString(), "ID: 5");
            //Assert.AreEqual(job1.Name.ToString(), "Name: Product tester");
            //Assert.AreEqual(job1.Employer.ToString(), "Employer: ACME");
            //Assert.AreEqual(job1.EmployerLocation.ToString(), "Location: Desert");
            //Assert.AreEqual(job1.JobType.ToString(), "Position Type: Quality control");
            //Assert.AreEqual(job1.JobCoreCompetency.ToString(), "Core Competency: Persistence");
        }


        [TestMethod]
        public void TestJobsToStringContainsNullProperty()  //null condition
        {
            Job job6 = new Job(); // Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(job6.ToString().Contains("Name: Data not available"));
            Assert.IsTrue(job6.ToString().Contains("Employer: Data not available"));
            Assert.IsTrue(job6.ToString().Contains("Location: Data not available"));
            Assert.IsTrue(job6.ToString().Contains("Position Type: Data not available"));
            Assert.IsTrue(job6.ToString().Contains("Core Competency: Data not available"));

            //Assert.AreEqual(job1.Id.ToString(), "ID: 5");
            //Assert.AreEqual(job1.Name.ToString(), "Name: Product tester");
            //Assert.AreEqual(job1.Employer.ToString(), "Employer: ACME");
            //Assert.AreEqual(job1.Employer.ToString(), "Location: Desert");
            //Assert.AreEqual(job1.JobType.ToString(), "Position Type: Quality control");
            //Assert.AreEqual(job1.JobCoreCompetency.ToString(), "Core Competency: Persistence");
        }
    }
}