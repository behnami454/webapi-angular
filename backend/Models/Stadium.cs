using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Stadium
    {
        [Key]
        public int StadiumId { get; set; }

        public string StadiumName { get; set; }

        public string StadiumPlace { get; set; }

    }
}
