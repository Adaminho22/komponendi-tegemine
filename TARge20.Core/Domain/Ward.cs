using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Ward
    {
        [Key]
        public Guid ID { get; set; }
        public Employee Employee { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PIC { get; set; }
    }
}
