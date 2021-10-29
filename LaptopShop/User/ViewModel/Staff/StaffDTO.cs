﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Management.ViewModel.Staff
{
    public class StaffDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string Password { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDay { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string RoleName { get; set; }
    }
}
