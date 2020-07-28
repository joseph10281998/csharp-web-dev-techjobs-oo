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

            string testOutput = "\n" + "ID: 5" + "\nName: Product tester" + "\nEmployer: ACME" +
                                "\nLocation: Desert" + "\nPosition Type: Quality control" +
                                "\nCore Competency: Persistence" + "\n";

            Assert.AreEqual(testOutput, job5.ToString());
            
        }


        [TestMethod]
        public void TestJobsToStringContainsNullProperty()  //null condition
        {
            Job job6 = new Job("", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string testOutput = "\n" + "ID: 6" + "\nName: Data not available" + "\nEmployer: Data not available" +
                                "\nLocation: Desert" + "\nPosition Type: Quality control" +
                                "\nCore Competency: Persistence" + "\n";

            Assert.AreEqual(testOutput, job6.ToString());            
        }
    }
}