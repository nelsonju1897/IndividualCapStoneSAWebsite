using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndividualCapStoneSAWebApplication.Models
{
    public class AlcoholAndOrDrugs
    {
        [Key]
        public int AlcoholAndOrDrugsId { get; set; }
        public string AlcoholAndOrDrugsName { get; set; }
        [NotMapped]
        public bool isChecked { get; set; }
        public IEnumerable<AlcoholAndOrDrugs> AlcoholAndOrDrug { get; set; }
    }
}