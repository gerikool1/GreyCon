using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreyCon.Models
{
    public class Disk
    {
        public int Id { get; set; }
        public int UsedSpace { get; set; }
        public int TotalSpace { get; set; }
    }
}