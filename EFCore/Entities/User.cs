using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace EFCore.Entities
{
    public class User : IdentityUser
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Gender { get; set; }
        public string Photo { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Direction> Directions { get; set; }
    }
}