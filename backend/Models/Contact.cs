using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        public string ContactEmail { get; set; }

        public string ContactDiscription { get; set; }

        public DateTime ContactCreateDate { get; set; }
    }
}
