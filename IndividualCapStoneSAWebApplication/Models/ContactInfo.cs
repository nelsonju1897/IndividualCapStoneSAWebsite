using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndividualCapStoneSAWebApplication.Models
{
    public class ContactInfo
    {
        [Key]
        public int ContactId { get; set; }

        [DisplayName("Type")]
        public string Type { get; set; }
                       
        [DisplayName("Contact Name")]
        public string Name { get; set; }
        
        [DisplayName("Number")]
        public string ContactNumber { get; set; }
        public string Location { get; set; }

        public IEnumerable<ContactInfo> contactInfos { get; set; }



    }
}