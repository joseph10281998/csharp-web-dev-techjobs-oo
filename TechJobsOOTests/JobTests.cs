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

            Assert.AreEqual("Name: Product tester", "Name: " + job5.Name.ToString());
            Assert.AreEqual("Employer: ACME", "Employer: " + job5.Employer.ToString());
            Assert.AreEqual("Location: Desert", "Location: " + job5.EmployerLocation.ToString());
            Assert.AreEqual("Position Type: Quality control", "Position Type: " + job5.JobType.ToString());
            Assert.AreEqual("CoreCompetency: Persistence", "CoreCompetency: " + job5.JobCoreCompetency.ToString());
        }


        [TestMethod]
        public void TestJobsToStringContainsNullProperty()  //null condition
        {
            Job job6 = new Job("", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("", job6.Name.ToString());            
        }
    }
}