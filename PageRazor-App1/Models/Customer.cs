﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PageRazor_App1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required, StringLength(22)]
        public string Name { get; set; }
    }
}
