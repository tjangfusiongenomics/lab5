﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIandCORS.Models.Clinic
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public ICollection<Ailment> Ailments { get; set; }
        public ICollection<Medication> Medications { get; set; }
    }
}