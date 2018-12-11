using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace baptismOfFire.Models
{
    public class Server
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Deployment> Deployments { get; set; }
    }
}