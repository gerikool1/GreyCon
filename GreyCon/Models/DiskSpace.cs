using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreyCon.Models
{
    public class DiskSpace
    {
        public List<int> Used { get; set; }
        public List<int> Total { get; set; }
    }
}