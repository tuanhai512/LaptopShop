using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Management.ViewModel.User
{
    public class CreateUserInput
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Không được để trống họ tên")]
        [Display(Name = "Họ tên")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Không được để trống mật khẩu")]
        [DataType(DataType.Password)]
        [Display(Name ="Mật khẩu")]
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDay { get; set; }
        [Required(ErrorMessage = "Không được để trống email")]
        [EmailAddress]
        public string Email { get; set; }
        public string Avatar { get; set; }

        [DataType(DataType.Password)]
        [Display(Name="Xác nhận mật khẩu")]
        [Compare("Password",ErrorMessage ="Mật khẩu không khớp")]
        public string ComfirmPassword { get; set; }
    }
    public class UpdateUserInput:CreateUserInput
    {

    }
}
