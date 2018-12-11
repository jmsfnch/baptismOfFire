﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace baptismOfFire.Models
{
    public class Certificate
    {
        public int ID { get; set; }
        [Required]
        public string CN { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpiresDate { get; set; }

        public virtual ICollection<Deployment> Deployments { get; set; }

    }
}