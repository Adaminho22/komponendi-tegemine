using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class SickLeave
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime SickLeaveBegin { get; set; }
        public DateTime SickLeaveEnd { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
