using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Department
    {
        [Key]
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public Branch Branch { get; set; }

        public List<Employee> Employees { get; set; }
        public List<Position> Positions { get; set; }

    }
}
