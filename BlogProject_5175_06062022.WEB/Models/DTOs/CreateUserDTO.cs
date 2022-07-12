using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Models.DTOs
{
    public class CreateUserDTO
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [MinLength(3, ErrorMessage = "En az 3 karakter giriniz.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [MinLength(3, ErrorMessage = "En az 3 karakter giriniz.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [MinLength(3, ErrorMessage = "En az 3 karakter giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [MinLength(3, ErrorMessage = "En az 3 karakter giriniz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public string Image { get; set; }

        
        [NotMapped] // Tablo olmadığı için
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public IFormFile ImagePath { get; set; }

        // Identity için almayı tercih ettim
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
    }
}
