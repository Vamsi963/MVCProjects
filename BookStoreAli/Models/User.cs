﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStoreAli.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }=string.Empty;

        [Required]
        public string Password { get; set; }=string.Empty;
    }
}