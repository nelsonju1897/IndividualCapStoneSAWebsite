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
        
        public int SurvivorId { get; set; }
       
        public int AssaultTypeId { get; set;}
        
        public int AssaultLocationId { get; set; }
        
        public int AttackerRelationshipId { get; set;}
        
        public int AlcoholAndOrDrugId { get; set;}
    }
}