using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace baptismOfFire.Models
{
    public class Deployment
    {
        public int ID { get; set; }
        public virtual Server Server { get; set; }
        public virtual Certificate Certificate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; }
    }
}