using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndividualCapStoneSAWebApplication.Models
{
    public class MessageBoard
    {
        [Key]
        public int MessageBoardId { get; set; }
        [Display(Name ="Message Board Title")]
        public string MessageBoardName { get; set; }
        [Display(Name = "Enter Your Story Here")]
        public string MessageBoardEntry { get; set; }
        [ForeignKey("Survivor")]
        public int SurvivorId { get; set; }
        public Survivor Survivor { get; set; }
    }
}