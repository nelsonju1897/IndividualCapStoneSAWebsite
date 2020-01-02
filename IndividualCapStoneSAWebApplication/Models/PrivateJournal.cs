using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndividualCapStoneSAWebApplication.Models
{
    public class PrivateJournal
    {
        [Key]
        public int PrivateJournalId { get; set; }
        [DisplayName("Journal Title")]
        public string PrivateJournalName { get; set; }
        [DisplayName("Journal Entry")]
        public string JournalEntry { get; set; }
        [ForeignKey("Survivor")]
        public int SurvivorId { get; set; }
        public Survivor Survivor { get; set; }
    }
}