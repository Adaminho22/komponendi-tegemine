using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Hints
    {
        [Key]
        public Guid Id { get; set; }

        public string Content { get; set; }
        public string Receiver { get; set; }
        public DateTime DateReceived { get; set; }
        public Branch Branch { get; set; }

    }
}
