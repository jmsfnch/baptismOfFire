using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace baptismOfFire.Models
{
    public class Certificate
    {
        public int ID { get; set; }
        public string CN { get; set; }
        public DateTime ExpiresDate { get; set; }

        public virtual ICollection<Deployment> Deployments { get; set; }

    }
}