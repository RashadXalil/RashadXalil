﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Models
{
    public class Promotions
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:150)]
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength:100)]
        public string RedirectUrl { get; set; }
    }
}
