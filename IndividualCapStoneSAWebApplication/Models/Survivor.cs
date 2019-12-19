using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndividualCapStoneSAWebApplication.Models
{
    public class Survivor
    {
        [Key]
        public int SurvivorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string EmailAddress { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}