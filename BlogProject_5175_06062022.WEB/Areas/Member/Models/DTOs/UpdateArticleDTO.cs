using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Areas.Member.Models.DTOs
{
    public class UpdateArticleDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Bu alan zorunlu")]
        [MinLength(3, ErrorMessage = "En az 3 karakter giriniz"), MaxLength(150)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Bu alan zorunlu")]
        [MinLength(3, ErrorMessage = "En az 3 karakter giriniz"), MaxLength(500)]
        public string Content { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImagePath { get; set; }

        [Required]
        public int AppUserID { get; set; }

        [Required]      // kategorisiz makale olmaz
        public List<int> CategoryID { get; set; } // kullanıcının seçtiği kategorinin ID'sini alır

        public List<GetCategoryDTO> Categories { get; set; }
    }
}
