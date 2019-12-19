using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndividualCapStoneSAWebApplication.Models
{
    public class SponsorGroup
    {
        [Key]
        public int SponsorGroupId { get; set; }
        [ForeignKey("Sponsor")]
        public int SponsorId { get; set; }
        public Sponsor Sponsor { get; set; }
        [ForeignKey("Survivor")]
        public int? SurvivorId { get; set; }
        public Survivor Survivor { get; set; }
    }
}