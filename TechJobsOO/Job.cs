using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        private int v1;
        private int v2;
        private string v3;
        private string v4;
        private Location location;
        private PositionType positionType;
        private CoreCompetency coreCompetency;

        public string Name { get; set; }
        public Employer Employer { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }
        public Location IsEmpty { get; private set; }

        // TODO: Add the two necessary constructors. //Completed//

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employer, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()    //constructor
        {
            Name = name;
            Employer = employer;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public Job(int v1, int v2, string v3, string v4, Employer employer, Location location, PositionType positionType, CoreCompetency coreCompetency)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            Employer = employer;
            this.location = location;
            this.positionType = positionType;
            this.coreCompetency = coreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods. //Completed//

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        //public string ToString()     //Initial ToString method is added and tested//
        //{
        //    return "\n" + "\n";    
        //    //Console.WriteLine("\n");
        //    //Console.WriteLine("\n");
        //}


        public override string ToString()
        {
            if (string.IsNullOrEmpty(Name)
                && (Employer == null || string.IsNullOrEmpty(Employer.Value))
                && (EmployerLocation == null || string.IsNullOrEmpty(EmployerLocation.Value))
                && (JobType == null || string.IsNullOrEmpty(JobType.Value))
                && (JobCoreCompetency == null || string.IsNullOrEmpty(JobCoreCompetency.Value)))
            {
                return "\n" + "ID: " + Id + "\nData not available" + "\n";
            }
            else
            {
                string Name1;

                if (!string.IsNullOrEmpty(Name))
                {
                    Name1 = Name;
                }
                else
                {
                    Name1 = "Data not available";
                }

                string Employer1;

                if (!string.IsNullOrEmpty(Employer.Value))
                {
                    Employer1 = Employer.Value;
                }
                else
                {
                    Employer1 = "Data not available";
                }

                string EmployerLocation1;

                if (!string.IsNullOrEmpty(EmployerLocation.Value))
                {
                    EmployerLocation1 = EmployerLocation.Value;
                }
                else
                {
                    EmployerLocation1 = "Data not available";
                }

                string JobType1;

                if (!string.IsNullOrEmpty(JobType.Value))
                {
                    JobType1 = JobType.Value;
                }
                else
                {
                    JobType1 = "Data not available";
                }

                string JobCoreCompetency1;

                if (!string.IsNullOrEmpty(JobCoreCompetency.Value))
                {
                    JobCoreCompetency1 = JobCoreCompetency.Value;
                }
                else
                {
                    JobCoreCompetency1 = "Data not available";
                }

                return "\n" + "ID: " + Id +
                        "\nName: " + Name1 +
                        "\nEmployer: " + Employer1 +
                        "\nLocation: " + EmployerLocation1 +
                        "\nPosition Type: " + JobType1 +
                        "\nCore Competency: " + JobCoreCompetency1 + "\n";
            }
        }
    }
}
