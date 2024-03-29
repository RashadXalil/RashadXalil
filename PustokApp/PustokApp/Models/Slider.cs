﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:100)]
        public string Image { get; set; }
        [StringLength(maximumLength:50)]
        public string Title1 { get; set; }
        [StringLength(maximumLength:50)]
        public string Title2 { get; set; }
        [StringLength(maximumLength:150)]
        public string Desc { get; set; }
        [StringLength(maximumLength:50)]
        public string BtnText { get; set; }
        [StringLength(maximumLength:200)]
        public string BtnUrl { get; set; }
        public int Order { get; set; }
    }
}
