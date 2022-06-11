using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class WishList
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public Department Department { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public DateTime ResolvedDate { get; set; }

    }
}
