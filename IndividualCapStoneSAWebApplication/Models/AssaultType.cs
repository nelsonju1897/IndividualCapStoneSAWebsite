using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndividualCapStoneSAWebApplication.Models
{
    public class AssaultType
    {
        [Key]
        public int AssaultTypeId { get; set;}
        public string AssaultTypeName { get; set;}
    }
}