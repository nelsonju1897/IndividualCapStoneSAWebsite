using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndividualCapStoneSAWebApplication.Models
{
    public class AssaultType
    {
        [Key]
        public int AssaultTypeId { get; set;}
        public string AssaultTypeName { get; set;}
        [NotMapped]
        public bool isChecked { get; set; }
        public IEnumerable<AssaultType> AssaultTypes { get; set; }
    }

    
}