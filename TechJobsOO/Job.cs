using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        

        public string Name { get; set; }
        public Employer Employer { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }
        

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
                && (string.IsNullOrEmpty(Employer.Value))
                && (string.IsNullOrEmpty(EmployerLocation.Value))
                && (string.IsNullOrEmpty(JobType.Value))
                && (string.IsNullOrEmpty(JobCoreCompetency.Value)))
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
