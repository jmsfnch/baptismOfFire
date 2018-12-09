using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace baptismOfFire.Models
{
    public class Deployment
    {
        public int ID { get; set; }
        public Server Server { get; set; }
        public DateTime CreateDate { get; set; }
    }
}