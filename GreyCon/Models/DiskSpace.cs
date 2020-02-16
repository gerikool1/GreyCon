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

        public int DisksNeeded { get; set; }

        public static int MinDrives(List<int>listUsed, List<int>listTest)
        {
            List<int> UsedTest = new List<int>();
            List<int> TotalTest = new List<int>();
            


            TotalTest.Sort();
            int SumUsed = UsedTest.Sum();
            for (var i=0; i<TotalTest.Count; i++  )
            {
            int LeftUsed = SumUsed - TotalTest[TotalTest.Count - i];
                if (LeftUsed <= 0)
                {
                    
                  return i;
                }
                else
                {
                    break;
                }

            }

            return TotalTest.Count ;
;
        }


    }
}