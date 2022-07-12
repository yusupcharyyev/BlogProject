using BlogProject_5175_06062022.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Admin.Models.DTOs
{
    public class GetAllCategoryDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Statu Statu { get; set; }
    }
}
