using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndividualCapStoneSAWebApplication.Models
{
    public class AssaultRecord
    {        
        [Key]
        public int AssaultRecordId { get; set; }
        [ForeignKey("Survivor")]
        public int SurvivorId { get; set; }
        public Survivor Survivor { get; set; }
        [ForeignKey("AssaultType")]
        public int AssaultTypeId { get; set;}
        public AssaultType AssaultType { get; set; }
        [ForeignKey("AssaultLocation")]
        public int AssaultLocationId { get; set; }
        public AssaultLocation AssaultLocation { get; set; }
        [ForeignKey("AttackerRelationship")]
        public int AttackerRelationshipId { get; set;}
        public AttackerRelationship AttackerRelationship { get; set; }
        [ForeignKey("AlcoholAndOrDrugs")]
        public int AlcoholAndOrDrugId { get; set;}
        public AlcoholAndOrDrugs AlcoholAndOrDrugs { get; set; }
    }
}