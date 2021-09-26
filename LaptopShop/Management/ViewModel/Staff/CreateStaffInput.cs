using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Management.ViewModel.Staff
{
    public class CreateStaffInput
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Không được để trống họ tên")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Không được để trống mật khẩu")]
        public string Password { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDay { get; set; }
        [Required(ErrorMessage = "Không được để trống email")]
        public string Email { get; set; }
        public string Avatar { get; set; }
    }
    public class UpdateStaffInput:CreateStaffInput
    {

    }
}
