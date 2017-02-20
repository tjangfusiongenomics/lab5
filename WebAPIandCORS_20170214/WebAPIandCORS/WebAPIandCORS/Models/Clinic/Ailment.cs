using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIandCORS.Models.Clinic
{
    public class Ailment
    {
        [Key]
        public string Name { get; set; }
    }
}