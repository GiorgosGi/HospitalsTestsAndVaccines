﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HospitalsTestsAndVaccines.Models
{
    public class ContactDetails
    {
        [ForeignKey("CustomerId")]
        public int CustomerlId { get; set; }
        [ForeignKey("HospitalId")]
        public int HospitalId { get; set; }
        [Required]
        [Phone]
        [MinLength(10)]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; } 
        [Required]
        public string City { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string State { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
        public Customer Customer { get; set; }
        public Hospital Hospital { get; set; }

    }
}