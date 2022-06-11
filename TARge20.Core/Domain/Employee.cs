using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PIC { get; set; }
        public string Address { get; set; }

        public Branch Branch { get; set; } 
        public Department Department { get; set; }
        public Position Position { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        //Enums
        public Enums.Access Class { get; set; }

        //Lists
        //public ICollection<Vacation> Vacation { get; set; }
        public List<Vacation> Vacations { get; set; }
        public List<HealthCheck> HealthChecks { get; set; }
        public List<Hints> Hints { get; set; }
        public List<Position> Positions { get; set; }
        public List<SickLeave> SickLeaves { get; set; }
        public List<Ward> wards { get; set; }
        public List<WishList> WishLists { get; set; }

    }



}
