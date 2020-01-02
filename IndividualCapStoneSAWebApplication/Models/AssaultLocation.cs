using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndividualCapStoneSAWebApplication.Models
{
    public class AssaultLocation
    {
        [Key]
        public int AssaultLocationId { get; set; }
        public string AssaultLocationName { get; set; }
        public IEnumerable<AssaultLocation> AssaultLocations { get; set; }
    }
}