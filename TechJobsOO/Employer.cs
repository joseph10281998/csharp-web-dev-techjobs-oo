using System;
namespace TechJobsOO
{
    public class Employer : JobField
    {
        public Employer(string value) : base(value)
        {            
        }

        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }    //name of the employer

        ///// <summary>
        ///// use: var e = new Employer();
        ///// e.Value = "Equifax";
        ///// or var e = new Employer { Value = "Equifax" };
        ///// </summary>
        //public Employer()  //constructor
        //{
        //    Id = nextId;
        //    nextId++;
        //}
        ////tally -> there could many instances and nextId is continuously incremented and assigned to the intances
        ///// <summary>
        ///// use: var e = new Employer("Equifax");
        ///// </summary>
        ///// <param name="value"></param> - parameter
        //public Employer(string value) : this()    //constructor
        //{
        //    Value = value;
        //}

        //public override bool Equals(object obj)     //obj consists of employer's name and id(?)
        //{
        //    return (obj is Employer employer) &&
        //           (Id == employer.Id);
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}
    }
}
