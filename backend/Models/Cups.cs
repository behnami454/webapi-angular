using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Cups
    {
        [Key]
        public int CupsId { get; set; }

        public string CupsName { get; set; }

        public string CupsYear { get; set; }

        public string CupsPhotoFileName { get; set; }
    }
}
