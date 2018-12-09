using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace baptismOfFire.Models
{
    public class Certificate
    {
        public int ID { get; set; }
        public string CN { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpiresDate { get; set; }

        public virtual ICollection<Deployment> Deployments { get; set; }

    }
}