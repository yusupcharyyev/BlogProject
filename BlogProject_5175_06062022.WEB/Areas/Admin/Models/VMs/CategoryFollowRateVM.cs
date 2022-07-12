using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Admin.Models.VMs
{
    public class CategoryFollowRateVM
    {
        public int ID { get; set; }
        public int TotalUser { get; set; }
        public string CategoryName { get; set; }
        public int FollowCategoryCount { get; set; }
        private double _rateCount;

        public double RateCount
        {
            get 
            {

                return (FollowCategoryCount*100)/TotalUser; 
            }
            set { _rateCount = value; }
        }

    }
}
