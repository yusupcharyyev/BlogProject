using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Member.Models.DTOs
{
    public class UpdateCategoryDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [MinLength(2), MaxLength(50)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [MinLength(2), MaxLength(250)]
        public string Description { get; set; }
    }
}
