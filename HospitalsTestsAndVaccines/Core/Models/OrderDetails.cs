﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalsTestsAndVaccines.Models
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}


//Order ID ProductID
//  1       1
//  1       2
//  1       4