using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Models.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Bu alan bol bırakılamaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
