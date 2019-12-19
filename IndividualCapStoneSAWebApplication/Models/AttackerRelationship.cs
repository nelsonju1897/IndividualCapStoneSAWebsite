using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndividualCapStoneSAWebApplication.Models
{
    public class AttackerRelationship
    {
        [Key]
        public int AttackerRelationshipId { get; set; }
        public string AttackerRelationshipName { get; set; }
    }
}