using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class User : IdentityUser
    {
        public int UserId { get; set; }

        public string ContactEmail { get; set; }

        public string UserPassword { get; set; }

    }
}
