﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalsTestsAndVaccines.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Όνομα Προϊόντος")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Κατηγορία")]
        public ProductCategory ProductCategory { get; set; }
        [Required]
        [Display(Name = "Περιγραφή")]
        public string Description { get; set; }
        [Display(Name = "Τιμή")]
        public double Price { get; set; }
        public byte NumberAvailable { get; set; }


    }
    public enum ProductCategory
    {
        TestCovid, VaccineCovid
    }
}