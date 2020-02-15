using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreyCon.Models
{
    public class DiskEntryViewModel
    {
        public int Id { get; set; }
        public int UsedSpace { get; set; }
        public int TotalSpace { get; set; }
        public List<int> UsedMbs { get; set; } = new List<int>();
        public List<int> TotalMbs { get; set; } = new List<int>();
    }
}