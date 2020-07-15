using System;


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
            //var jobString = "" + "\nID: " + Id;
            //if (string.IsNullOrEmpty(Name))
            //    jobString += "Name: Data not available";
            //else
            //{
            
            return "" 
                + "\nID: " + Id 
                + "\nName: " + ((Name == null || Name == "") ? "Data not available" : Name.ToString()) 
                + "\nEmployer: " + ((Employer == null || Employer.Value == "") ? "Data not available" : Employer.ToString())  
                + "\nLocation: " + ((EmployerLocation == null || EmployerLocation.Value == "") ? "Data not available" : EmployerLocation.ToString()) 
                + "\nPosition Type: " + ((JobType == null || JobType.Value == "") ? "Data not available" : JobType.ToString()) 
                + "\nCore Competency: " + ((JobCoreCompetency == null || JobCoreCompetency.Value == "") ? "Data not available" : JobCoreCompetency.ToString()) 
                + "\n";
        }
    }
}
